using System;
using System.Data;
using System.Data.SqlClient;

namespace SPDM.DLL
{
    /// <summary>
    /// 
    /// </summary>
    public class DbManager : IDisposable    
    {
        private bool _disposed;
        private SqlConnection _connection;
        private SqlTransaction _transaction = null;

        public SqlConnection Connection
        {
            get 
            {
                return _connection; 
            }
        }

        public SqlTransaction Transaction
        {
            get
            {
                return _transaction;
            }
        }

        public DbManager(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void OpenTransaction()
        {
            if (_transaction == null)
            {
                OpenConnection();
                _transaction = _connection.BeginTransaction();
            }
        }

        public void CommitTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
            CloseConnection();
        }

        public void RollbackTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
            }
            CloseConnection();
        }

        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_transaction == null)
            {
                if (_connection != null)
                {
                    if (_connection.State == ConnectionState.Open)
                    {
                        _connection.Close();
                        //_connection = null;
                    }
                }
            }
        }

        public SqlCommand CreateCommand()
        {
            SqlCommand sqlCommand = _connection.CreateCommand();
            if (_transaction != null)
            {
                sqlCommand.Transaction = _transaction;
            }
            return sqlCommand;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }

                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }
        }
    }
}
