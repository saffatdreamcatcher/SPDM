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
    public class SaleDLL
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
                comm.CommandText = "Delete from Sale where Id = " + id.ToString();
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

        public List<Sale> GetAll(string whereClause = "")
        {
            var sales = new List<Sale>();
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
                comm.CommandText = "Select * from Sale" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime Updatetime = Convert.ToDateTime(reader["UpdateTime"]);
                        Sale sale = new Sale(id, createTime);
                        sale.UserId = Convert.ToInt32(reader["UserId"]);
                        sale.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        sale.Fiscalyear = reader["FiscalYear"].ToString();
                        sale.PartyId = Convert.ToInt32(reader["PartyId"]);
                        sale.ChallanNo = Convert.ToInt32(reader["ChallanNo"]);
                        sale.SaleDate = Convert.ToDateTime(reader["SaleDate"]);
                        sale.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        sale.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);



                        if (reader["VatPercent"] is DBNull)
                        {
                            sale.VatPercent = null;
                        }
                        else
                        {
                            sale.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        sale.DeliveryAddress = reader["DeliveryAddress"].ToString();
                        sale.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                        sale.Status = Convert.ToInt32(reader["Note"] is DBNull ? null : reader["Note"]);
                        sale.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        sales.Add(sale);
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
            return sales;
        }


        public Sale GetById(int id)
        {
            Sale sale = new Sale();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Sale where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        sale.UserId = Convert.ToInt32(reader["UserId"]);
                        sale.WorkOrderId = Convert.ToInt32(reader["UserId"]);
                        sale.Fiscalyear = reader["FiscalYear"].ToString();
                        sale.PartyId = Convert.ToInt32(reader["PartyId"]);
                        sale.ChallanNo = Convert.ToInt32(reader["ChallanNo"]);
                        sale.SaleDate = Convert.ToDateTime(reader["SaleDate"]);
                        sale.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        sale.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);



                        if (reader["VatPercent"] is DBNull)
                        {
                            sale.VatPercent = null;
                        }
                        else
                        {
                            sale.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        sale.DeliveryAddress = reader["DeliveryAddress"].ToString();
                        sale.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                        sale.Status = Convert.ToInt32(reader["Note"] is DBNull ? null : reader["Note"]);
                        sale.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();



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
            return sale;


        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Sale sale = new Sale();
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
                comm.CommandText = "Select count(*) from Sale " + whereClause;
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


        public int Save(Sale sale)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (sale.IsNew)
                {
                    comm.CommandText = "INSERT INTO Sale(CreateTime, UpdateTime, UserId, FiscalYear, SaleId, PartyId, " +
                                       "ChallanNo, SaleDate, TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, Vat Percent, DeliveryAddress, DeliveryDate, " +
                                       "Status, Note) VALUES(@CreateTime, @UpdateTime, @UserId," +
                                       "@FiscalYear, @SaleId, @PartyId, @ChallanNo, @SaleDate, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, " +
                                       " @DeliveryAddress, @DeliveryDate, @Status @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Sale SET  CreateTime = @CreateTime, UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, " +
                                       "PartyId = @PartyId, ChallanNo = @ChallanNo, SaleDate = @SaleDate," +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, Vat Percent= @VatPercent, " +
                                       "DeliveryAddress = @DeliveryAddress, DeliveryDate =  @DeliveryDate, " +
                                       "Status = @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = sale.Id;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = sale.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = sale.Fiscalyear;
                comm.Parameters.Add("@SaleId", SqlDbType.Int).Value = sale.UserId;
                comm.Parameters.Add("@PartyId", SqlDbType.Int).Value = sale.PartyId;
                comm.Parameters.Add("@ChallanNo", SqlDbType.Int).Value = sale.ChallanNo;
                comm.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = sale.SaleDate;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = sale.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = sale.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = sale.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = sale.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = sale.VatPercent;
                comm.Parameters.Add("@Status", SqlDbType.VarChar).Value = sale.Status;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = sale.Note;

                if (sale.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    sale.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = sale.Id;
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
