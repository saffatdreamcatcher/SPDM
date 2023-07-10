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
    public class StockHistoryDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public StockHistoryDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }

        public StockHistoryDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from StockHistory where Id = " + id.ToString();
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


        public List<StockHistory> GetAll(string whereClause = "")
        {
            var stockhistories = new List<StockHistory>();
            
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

                comm.CommandText = "Select * from StockHistory" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        
                        StockHistory stockhistory = new StockHistory(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            stockhistory.UpdateTime = null;
                        }
                        else
                        {
                            stockhistory.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        stockhistory.Id = id;
                        stockhistory.UserId = Convert.ToInt32(reader["UserId"]);
                        stockhistory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stockhistory.Fiscalyear = reader["FiscalYear"].ToString();
                        stockhistory.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stockhistory.Drum = reader["Drum"].ToString();
                        stockhistory.CoilNo = reader["CoilNo"].ToString();
                        stockhistory.Unit = Convert.ToInt32(reader["Unit"]);
                        stockhistory.QuantityInKM = Convert.ToInt32(reader["QuantityInKM"]);
                        stockhistory.QuantityInFKM = Convert.ToInt32(reader["QuantityInFKM"]);
                        stockhistory.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        stockhistory.Status = Convert.ToInt32(reader["Status"]);
                        stockhistories.Add(stockhistory);
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
            return stockhistories;
        }


        public StockHistory GetById(int id)
        {
            StockHistory stockhistory = new StockHistory();
            

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from StockHistory where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read()) 
                    {
                        id = Convert.ToInt32(reader["id"]);  
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            stockhistory.UpdateTime = null;
                        }
                        else
                        {
                            stockhistory.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        stockhistory.Id = id;
                        stockhistory.UserId = Convert.ToInt32(reader["UserId"]);
                        stockhistory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stockhistory.Fiscalyear = reader["FiscalYear"].ToString();
                        stockhistory.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stockhistory.Drum = reader["Drum"].ToString();
                        stockhistory.CoilNo = reader["CoilNo"].ToString();
                        stockhistory.Unit = Convert.ToInt32(reader["Unit"]);
                        stockhistory.QuantityInKM = Convert.ToInt32(reader["QuantityInKM"]);
                        stockhistory.QuantityInFKM = Convert.ToInt32(reader["QuantityInFKM"]);
                        stockhistory.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        stockhistory.Status = Convert.ToInt32(reader["Status"]);




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
            return stockhistory;


        }



        public int GetCount(string whereClause = "")
        {

            int count = 0;
            StockHistory stockhistory = new StockHistory();
           

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

                comm.CommandText = "Select count(*) from StockHistory " + whereClause;
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

        public int Save(StockHistory stockhistory)
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

                if (stockhistory.IsNew)
                {
                    comm.CommandText = "INSERT INTO StockHistory(CreateTime, UserId, CategoryId, ItemId, FiscalYear, " +
                                       "Drum, CoilNo, Unit, QuantityInKM, QuantityInFKM, " +
                                       "Status, Note " +
                                       ") VALUES(@CreateTime, @UserId, @CategoryId, @ItemId, @FiscalYear, " +
                                       " @Drum, @CoilNo, @Unit, @QuantityInKM, @QuantityInFKM, " +
                                       " @Status, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update StockHistory SET UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, CategoryId = @CategoryId,  " +
                                       "ItemId = @ItemId, Drum =@Drum, CoilNo = @CoilNo, Unit= @Unit, " +
                                       "QuantityInKM = @QuantityInKM, QuantityInFKM= @QuantityInFKM, " +
                                       " Status = @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = stockhistory.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.Int).Value = stockhistory.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = stockhistory.Fiscalyear;
                comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = stockhistory.CategoryId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = stockhistory.ItemId;
                comm.Parameters.Add("@Drum", SqlDbType.VarChar).Value = stockhistory.Drum;
                comm.Parameters.Add("@CoilNo", SqlDbType.VarChar).Value = stockhistory.CoilNo;
                comm.Parameters.Add("@Unit", SqlDbType.SmallInt).Value = stockhistory.Unit;
                comm.Parameters.Add("@QuantityInKM", SqlDbType.Decimal).Value = stockhistory.QuantityInKM;
                comm.Parameters.Add("@QuantityInFKM", SqlDbType.Decimal).Value = stockhistory.QuantityInFKM;
                comm.Parameters.Add("@Status", SqlDbType.SmallInt).Value = stockhistory.Status;
                comm.Parameters.Add("@Note", SqlDbType.Text).Value = stockhistory.Note;

                if (stockhistory.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    stockhistory.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = stockhistory.Id;
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
