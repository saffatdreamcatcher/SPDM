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
        public int Delete(int id)
        {
            int noOfRowAffected = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Delete from StockHistory where Id = " + id.ToString();
                noOfRowAffected = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return noOfRowAffected;

        }


        public List<StockHistory> GetAll(string whereClause = "")
        {
            var stockhistories = new List<StockHistory>();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from StockHistory" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime Updatetime = Convert.ToDateTime(reader["UpdateTime"]);
                        StockHistory stockhistory = new StockHistory(id, createTime);
                        stockhistory.UserId = Convert.ToInt32(reader["UserId"]);
                        stockhistory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stockhistory.Fiscalyear = reader["FiscalYear"].ToString();
                        stockhistory.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stockhistory.Drum = reader["Drum"].ToString();
                        stockhistory.CoilNo = reader["CoilNo"].ToString();
                        stockhistory.Unit = Convert.ToInt32(reader["Unit"]);



                        if (reader["Din"] is DBNull)
                        {
                            stockhistory.Din = null;
                        }
                        else
                        {
                            stockhistory.Din = reader["VatPercent"].ToString();
                        }

                        stockhistory.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stockhistory.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
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
                conn.Close();
            }
            return stockhistories;
        }


        public StockHistory GetById(int id)
        {
            StockHistory stockhistory = new StockHistory();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from StockHistory where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read()) 
                    {
                        id = Convert.ToInt32(reader["id"]);  
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            stockhistory.UpdateTime = null;
                        }
                        else
                        {
                            stockhistory.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        stockhistory.UserId = Convert.ToInt32(reader["UserId"]);
                        stockhistory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                        stockhistory.Fiscalyear = reader["FiscalYear"].ToString();
                        stockhistory.ItemId = Convert.ToInt32(reader["ItemId"]);
                        stockhistory.Drum = reader["Drum"].ToString();
                        stockhistory.CoilNo = reader["CoilNo"].ToString();
                        stockhistory.Unit = Convert.ToInt32(reader["Unit"]);



                        if (reader["Din"] is DBNull)
                        {
                            stockhistory.Din = null;
                        }
                        else
                        {
                            stockhistory.Din = reader["VatPercent"].ToString();
                        }

                        stockhistory.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stockhistory.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
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
                conn.Close();
            }
            return stockhistory;


        }



        public int GetCount(string whereClause = "")
        {

            int count = 0;
            StockHistory stockhistory = new StockHistory();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select count(*) from StockHistory " + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public int Save(StockHistory stockhistory)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (stockhistory.IsNew)
                {
                    comm.CommandText = "INSERT INTO StockHistory(CreateTime, UpdateTime, UserId, CategoryId, ItemId, FiscalYear " +
                                       "Drum, CoilNo, Din, Unit, OpeningQuantityInKM, OpeningQuantityInFKM " +
                                       "CurrentQuantityInKM, CurrentQuantityInFKM, Status, Note " +
                                       ") VALUES(@CreateTime, @UpdateTime, @UserId, @CategoryId, @ItemId, @FiscalYear" +
                                       " @Drum, @CoilNo, @Din, @Unit, @OpeningQuantityInKM, @OpeningQuantityInFKM" +
                                       //" @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, " +
                                       " @CurrentQuantityInKM, @CurrentQuantityInFKM, @Status, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update StockHistory SET  CreateTime = @CreateTime, UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, CategoryId = @CategoryId  " +
                                       "ItemId = @ItemId, Drum =@Drum, CoilNo = @CoilNo, Din = @Din, Unit= @Unit" +
                                       "OpeningQuantityInKM = @OpeningQuantityInKM, OpeningQuantityInFKM= @OpeningQuantityInKM, " +
                                       "CurrentQuantityInKM = @CurrentQuantityInKM, CurrentQuantityInFKM =  @CurrentQuantityInFKM, " +
                                       " Status = @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = stockhistory.Id;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = stockhistory.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = stockhistory.Fiscalyear;
                comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = stockhistory.CategoryId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = stockhistory.ItemId;
                comm.Parameters.Add("@Drum", SqlDbType.Int).Value = stockhistory.Drum;
                comm.Parameters.Add("@CoilNo", SqlDbType.DateTime).Value = stockhistory.CoilNo;
                comm.Parameters.Add("@Din", SqlDbType.Decimal).Value = stockhistory.Din;
                comm.Parameters.Add("@unit", SqlDbType.Decimal).Value = stockhistory.Unit;
                comm.Parameters.Add("@OpeningQuantityInKM", SqlDbType.Decimal).Value = stockhistory.OpeningQuantityInKM;
                comm.Parameters.Add("@OpeningQuantityInFKM", SqlDbType.Decimal).Value = stockhistory.OpeningQuantityInFKM;
                comm.Parameters.Add("@CurrentQuantityInKM", SqlDbType.Decimal).Value = stockhistory.CurrentQuantityInKM;
                comm.Parameters.Add("@CurrentQuantityInFKM", SqlDbType.VarChar).Value = stockhistory.CurrentQuantityInFKM;
                comm.Parameters.Add("@Status", SqlDbType.VarChar).Value = stockhistory.Status;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = stockhistory.Note;

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
                conn.Close();
            }
            return primaryKey;
        }



    }
}
