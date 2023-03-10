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
    public class SaleDetailDLL
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
                comm.CommandText = "Delete from SaleDetail where Id = " + id.ToString();
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


        public List<SaleDetail> GetAll(string whereClause = "")
        {
            var saledetails = new List<SaleDetail>();
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
                comm.CommandText = "Select * from SaleDetail" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime Updatetime = Convert.ToDateTime(reader["UpdateTime"]);
                        SaleDetail saledetail = new SaleDetail(id, createTime);
                        saledetail.SaleId = Convert.ToInt32(reader["SaleId"]);
                        saledetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        saledetail.Unit = Convert.ToInt32(reader["Unit"]);
                        saledetail.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                        saledetail.Length = Convert.ToDouble(reader["Length"]);
                        saledetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        saledetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);


                        if (reader["Discount"] is DBNull)
                        {
                            saledetail.Discount = null;
                        }
                        else
                        {
                            saledetail.Discount = Convert.ToDouble(reader["VatPercent"]);
                        }


                        if (reader["DiscountPercent"] is DBNull)
                        {
                            saledetail.DiscountPercent = null;
                        }
                        else
                        {
                            saledetail.DiscountPercent = Convert.ToDouble(reader["VatPercent"]);
                        }


                        if (reader["VatPercent"] is DBNull)
                        {
                            saledetail.VatPercent = null;
                        }
                        else
                        {
                            saledetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }


                        saledetails.Add(saledetail);
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
            return saledetails;
        }


        public SaleDetail GetById(int id)
        {
            SaleDetail saledetail = new SaleDetail();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from SaleDetail where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);


                        saledetail.SaleId = Convert.ToInt32(reader["SaleId"]);
                        saledetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        saledetail.Unit = Convert.ToInt32(reader["Unit"]);
                        saledetail.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                        saledetail.Length = Convert.ToDouble(reader["Length"]);
                        saledetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        saledetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);




                        if (reader["VatPercent"] is DBNull)
                        {
                            saledetail.VatPercent = null;
                        }
                        else
                        {
                            saledetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }





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
            return saledetail;


        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            SaleDetail saledetail = new SaleDetail();
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
                comm.CommandText = "Select count(*) from SaleDetail " + whereClause;
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


        public int Save(SaleDetail saledetail)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (saledetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO Sale(CreateTime, UpdateTime, SaleId, ItemId, " +
                                       "Unit, UnitPrice, Length TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, Vat Percent, " +
                                       ") VALUES(@CreateTime, @UpdateTime, @UserId," +
                                       " @SaleId, @ItemId, @Unit, @UnitPrice, @Length, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, " +
                                       " ); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Sale SET  CreateTime = @CreateTime, UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, " +
                                       "ItemId = @ItemId, Unit = @Unit, UnitPrice = @UnitPrice, Length= @Length" +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, Vat Percent= @VatPercent, " +
                                       "DeliveryAddress = @DeliveryAddress, DeliveryDate =  @DeliveryDate, " +
                                       "Status = @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = saledetail.Id;
                }
                comm.Parameters.Add("@SaleId", SqlDbType.VarChar).Value = saledetail.SaleId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = saledetail.ItemId;
                comm.Parameters.Add("@Unit", SqlDbType.Int).Value = saledetail.Unit;
                comm.Parameters.Add("@UnitPrice", SqlDbType.Int).Value = saledetail.UnitPrice;
                comm.Parameters.Add("@Length", SqlDbType.DateTime).Value = saledetail.Length;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = saledetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = saledetail.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = saledetail.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = saledetail.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = saledetail.VatPercent;
                

                if (saledetail.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    saledetail.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = saledetail.Id;
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