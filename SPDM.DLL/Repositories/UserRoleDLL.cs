using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Repositories
{
    public class UserRoleDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public UserRoleDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public UserRoleDLL(SqlTransaction sqlTrans)
        {

            if (sqlTrans == null)
            {
                throw new ArgumentNullException("SqlTransaction is required");
            }
            if (sqlTrans.Connection == null)
            {
                throw new ArgumentNullException("SqlConnection is required in Transaction");
            }
            this.sqlConnection = sqlTrans.Connection;
            this.sqlTransaction = sqlTrans;
            isEnableTransaction = true;

        }
        public int Delete(int id)
        {
            int noOfRowAffected = 0;
            
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Delete from UserRole where Id = " + id.ToString();
                noOfRowAffected = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return noOfRowAffected;

        }

        public List<UserRole> GetAll(string whereClause = "")
        {
            var userroles = new List<UserRole>();
            
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from UserRole" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        UserRole userrole = new UserRole(id, createTime);
                        userrole.UserId = Convert.ToInt32(reader["UserId"]);
                        userrole.RoleId = Convert.ToInt32(reader["RoleId"]);
                        userroles.Add(userrole);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return userroles;
        }

        public UserRole GetById(int id)
        {
            var userrole = new UserRole();
            

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from UserRole where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        userrole = new UserRole(id, createTime);
                        userrole.UserId = Convert.ToInt32(reader["UserId"]);
                        userrole.RoleId = Convert.ToInt32(reader["RoleId"]);

                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return userrole;
        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            var userrole = new UserRole();
           

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select count(*) from UserRole " + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return count;
        }

        public int Save(UserRole userrole)
        {
            int primaryKey = 0;
            //var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            //SqlConnection conn = new SqlConnection();
            try
            {
                //conn.ConnectionString = myConnectionString;
                //conn.Open();

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                if (userrole.IsNew)
                {
                    comm.CommandText = "INSERT INTO UserRole(CreateTime, UserId, RoleId," +
                        ") VALUES(@CreateTime, @UserId, @RoleId" +
                        "); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update UserRole SET UserId = @UserId, RoleId = @RoleId WHERE Id = @Id";
                         
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = userrole.Id;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = userrole.UserId;
                comm.Parameters.Add("@RoleId", SqlDbType.VarChar).Value = userrole.RoleId;
                
                if (userrole.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    userrole.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = userrole.Id;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return primaryKey;
        }


    }

}