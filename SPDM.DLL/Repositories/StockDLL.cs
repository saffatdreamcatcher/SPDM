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
                comm.CommandText = "Delete from Stock where Id = " + id.ToString();
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

        public List<Stock> GetAll(string whereClause = "")
        {
            var stocks = new List<Stock>();
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
                comm.CommandText = "Select * from Stock" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime Updatetime = Convert.ToDateTime(reader["UpdateTime"]);
                        Stock stock = new Stock(id, createTime);
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
                            stock.Din = reader["VatPercent"].ToString();
                        }

                        stock.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stock.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
                        stock.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();

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
                conn.Close();
            }
            return stocks;
        }


        public Stock GetById(int id)
        {
            Stock stock = new Stock();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Stock where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);
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
                            stock.Din = reader["VatPercent"].ToString();
                        }

                        stock.OpeningQuantityInKM = Convert.ToInt32(reader["OpeningQuantityInKM"]);
                        stock.OpeningQuantityInFKM = Convert.ToInt32(reader["OpeningQuantityInFKM"]);
                        stock.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();




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
            return stock;


        }



        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Stock stock = new Stock();
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
                comm.CommandText = "Select count(*) from Stock " + whereClause;
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


        public int Save(Stock stock)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (stock.IsNew)
                {
                    comm.CommandText = "INSERT INTO Stock(CreateTime, UpdateTime, UserId, CategoryId, ItemId, FiscalYear " +
                                       "Drum, CoilNo, Din, Unit, OpeningQuantityInKM, OpeningQuantityInFKM " +
                                       "CurrentQuantityInKM, CurrentQuantityInFKM " +
                                       ") VALUES(@CreateTime, @UpdateTime, @UserId, @CategoryId, @ItemId, @FiscalYear" +
                                       " @Drum, @CoilNo, @Din, @Unit, @OpeningQuantityInKM, @OpeningQuantityInFKM" +
                                       //" @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, " +
                                       " @CurrentQuantityInKM, @CurrentQuantityInFKM @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Stock SET  CreateTime = @CreateTime, UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, CategoryId = @CategoryId  " +
                                       "ItemId = @ItemId, Drum =@Drum, CoilNo = @CoilNo, Din = @Din, Unit= @Unit" +
                                       "OpeningQuantityInKM = @OpeningQuantityInKM, OpeningQuantityInFKM= @OpeningQuantityInKM, " +
                                       "CurrentQuantityInKM = @CurrentQuantityInKM, CurrentQuantityInFKM =  @CurrentQuantityInFKM, " +
                                       "Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = stock.Id;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = stock.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = stock.Fiscalyear;
                comm.Parameters.Add("@CategoryId", SqlDbType.Int).Value = stock.CategoryId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = stock.ItemId;
                comm.Parameters.Add("@Drum", SqlDbType.Int).Value = stock.Drum;
                comm.Parameters.Add("@CoilNo", SqlDbType.DateTime).Value = stock.CoilNo;
                comm.Parameters.Add("@Din", SqlDbType.Decimal).Value = stock.Din;
                comm.Parameters.Add("@unit", SqlDbType.Decimal).Value = stock.Unit;
                comm.Parameters.Add("@OpeningQuantityInKM", SqlDbType.Decimal).Value = stock.OpeningQuantityInKM;
                comm.Parameters.Add("@OpeningQuantityInFKM", SqlDbType.Decimal).Value = stock.OpeningQuantityInFKM;
                comm.Parameters.Add("@CurrentQuantityInKM", SqlDbType.Decimal).Value = stock.CurrentQuantityInKM;
                comm.Parameters.Add("@CurrentQuantityInFKM", SqlDbType.VarChar).Value = stock.CurrentQuantityInFKM;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = stock.Note;

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
                conn.Close();
            }
            return primaryKey;
        }
    }
}