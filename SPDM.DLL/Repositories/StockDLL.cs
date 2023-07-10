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
    
    public class StockDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public StockDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public StockDLL(SqlTransaction sqlTrans) 
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

                comm.CommandText = "Delete from Stock where Id = " + id.ToString();
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

        public List<Stock> GetAll(string whereClause = "")
        {
            var stocks = new List<Stock>();
            
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

                comm.CommandText = "Select Stock.*, Category.Name AS CategoryName, Item.Name AS ItemName from Stock " +
                                    "inner join Category on Stock.CategoryId = Category.Id " +
                                    "inner join Item on Stock.ItemId = Item.Id" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        
                        Stock stock = new Stock(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            stock.UpdateTime = null;
                        }
                        else
                        {
                            stock.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        stock.Id = id;
                        stock.UserId = Convert.ToInt32(reader["UserId"]);
                        stock.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stock.Fiscalyear = reader["FiscalYear"].ToString();
                        stock.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stock.Drum = reader["Drum"].ToString();
                        stock.CoilNo = reader["CoilNo"].ToString();
                        stock.Unit = Convert.ToInt32(reader["Unit"]);


                        if (reader["Din"] is DBNull)
                        {
                            stock.Din = null;
                        }
                        else
                        {
                            stock.Din = Convert.ToDouble(reader["Din"]);
                        }

                        stock.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stock.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
                        stock.CurrentQuantityInKM = Convert.ToInt32(reader["CurrentQuantityInKM"]);
                        stock.CurrentQuantityInFKM = Convert.ToInt32(reader["CurrentQuantityInFKM"]);
                        stock.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        stock.CategoryName = reader["CategoryName"].ToString();
                        stock.ItemName = reader["ItemName"].ToString();
                        stock.Length = Convert.ToDouble(reader["Length"]);
                        stocks.Add(stock);
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
            return stocks;
        }


        public Stock GetById(int id)
        {
            Stock stock = new Stock();
            

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "Select * from Stock where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            stock.UpdateTime = null;
                        }
                        else
                        {
                            stock.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        stock.Id = id;
                        stock.UserId = Convert.ToInt32(reader["UserId"]);
                        stock.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stock.Fiscalyear = reader["FiscalYear"].ToString();
                        stock.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stock.Drum = reader["Drum"].ToString();
                        stock.CoilNo = reader["CoilNo"].ToString();
                        stock.Unit = Convert.ToInt32(reader["Unit"]);

                        if (reader["Din"] is DBNull)
                        {
                            stock.Din = null;
                        }
                        else
                        {
                            stock.Din = Convert.ToDouble(reader["Din"]);
                        }

                        stock.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stock.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
                        stock.CurrentQuantityInKM = Convert.ToInt32(reader["CurrentQuantityInKM"]);
                        stock.CurrentQuantityInFKM = Convert.ToInt32(reader["CurrentQuantityInFKM"]);
                        stock.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        stock.CategoryName = reader["CategoryName"].ToString();
                        stock.ItemName = reader["ItemName"].ToString();
                        stock.Length = Convert.ToDouble(reader["Length"]);

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
            return stock;


        }



        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Stock stock = new Stock();
            

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
                comm.CommandText = "Select count(*) from Stock " + whereClause;
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


        public bool IsExist(string whereClause = "")
        {
            bool isExist = false;
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "SELECT " +
                        "CASE WHEN COUNT( Id ) >= 1 THEN " +
                        "CAST( 1 as BIT ) " +
                        "ELSE " +
                        " CAST( 0 as BIT ) " +
                        "END As IsPresent " +
                        "FROM [dbo].[Stock] " +
                        "WHERE " + whereClause;
                isExist = Convert.ToBoolean(comm.ExecuteScalar());
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

            return isExist;
        }

        public int Save(Stock stock)
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
               
                if (stock.IsNew)
                {
                    comm.CommandText = "INSERT INTO Stock(CreateTime, UserId, CategoryId, ItemId, FiscalYear, " +
                                       "Drum, CoilNo, Din, Unit, OpeningQuantityInKM, OpeningQuantityInFKM, " +
                                       "CurrentQuantityInKM, CurrentQuantityInFKM, Note, Length " +
                                       ") VALUES(@CreateTime, @UserId, @CategoryId, @ItemId, @FiscalYear, " +
                                       "@Drum, @CoilNo, @Din, @Unit, @OpeningQuantityInKM, @OpeningQuantityInFKM, " +
                                       "@CurrentQuantityInKM, @CurrentQuantityInFKM, @Note, @Length); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    comm.CommandText = "Update Stock SET  UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, CategoryId = @CategoryId, " +
                                       "ItemId = @ItemId, Drum =@Drum, CoilNo = @CoilNo, Din = @Din, Unit= @Unit, " +
                                       "OpeningQuantityInKM = @OpeningQuantityInKM, OpeningQuantityInFKM= @OpeningQuantityInFKM, " +
                                       "CurrentQuantityInKM = @CurrentQuantityInKM, CurrentQuantityInFKM =  @CurrentQuantityInFKM, " +
                                       "Note= @Note, Length= @Length WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = stock.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.Int).Value = stock.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = stock.Fiscalyear;
                comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = stock.CategoryId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = stock.ItemId;
                comm.Parameters.Add("@Drum", SqlDbType.VarChar).Value = stock.Drum;
                comm.Parameters.Add("@CoilNo", SqlDbType.VarChar).Value = stock.CoilNo;
                
                if (stock.Din.HasValue)
                {
                    comm.Parameters.Add("@Din", SqlDbType.Decimal).Value = stock.Din.Value;
                }
                else
                {
                    comm.Parameters.Add("@Din", SqlDbType.Decimal).Value = DBNull.Value;
                }
                comm.Parameters.Add("@Unit", SqlDbType.Decimal).Value = stock.Unit;
                comm.Parameters.Add("@OpeningQuantityInKM", SqlDbType.Decimal).Value = stock.OpeningQuantityInKM;
                comm.Parameters.Add("@OpeningQuantityInFKM", SqlDbType.Decimal).Value = stock.OpeningQuantityInFKM;
                comm.Parameters.Add("@CurrentQuantityInKM", SqlDbType.Decimal).Value = stock.CurrentQuantityInKM;
                comm.Parameters.Add("@CurrentQuantityInFKM", SqlDbType.Decimal).Value = stock.CurrentQuantityInFKM;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = stock.Note;
                comm.Parameters.Add("@Length", SqlDbType.Decimal).Value = stock.Length;
                if (stock.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    stock.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = stock.Id;
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