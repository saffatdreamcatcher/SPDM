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
    public class PaymentDetailDLL
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
                comm.CommandText = "Delete from PaymentDetail where Id = " + id.ToString();
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

        public List<PaymentDetail> GetAll(string whereClause = "")
        {
            var paymentdetails = new List<PaymentDetail>();
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
                comm.CommandText = "Select * from PaymentDetail" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        PaymentDetail paymentdetail = new PaymentDetail(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            paymentdetail.UpdateTime = null;
                        }
                        else
                        {
                            paymentdetail.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        paymentdetail.Id = id;
                        paymentdetail.PaymentId = Convert.ToInt32(reader["PaymentId"]);
                        paymentdetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        paymentdetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                      

                        if (reader["Discount"] is DBNull)
                        {
                            paymentdetail.Discount = null;
                        }
                        else
                        {
                            paymentdetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["DiscountPercent"] is DBNull)
                        {
                            paymentdetail.DiscountPercent = null;
                        }
                        else
                        {
                            paymentdetail.DiscountPercent = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["VatPercent"] is DBNull)
                        {
                            paymentdetail.VatPercent = null;
                        }
                        else
                        {
                            paymentdetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }
                        
                        
                        paymentdetail.TransactionType = Convert.ToInt16(reader["TransactionType"]);
                        paymentdetail.BankName = reader["BankName"] is DBNull ? null : reader["BankName"].ToString();
                        paymentdetail.CheckNo = reader["CheckNo"] is DBNull ? null : reader["CheckNo"].ToString();
                        paymentdetail.BkashTransactionNo = reader["BkashTransactionNo"] is DBNull ? null : reader["BkashTransactionNo"].ToString();
                        paymentdetails.Add(paymentdetail);
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
            return paymentdetails;
        }


        public PaymentDetail GetById(int id)
        {
            PaymentDetail paymentdetail = new PaymentDetail();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from PaymentDetail where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                       
                        
                        
                        if (reader["UpdateTime"] is DBNull)
                        {
                            paymentdetail.UpdateTime = null;
                        }
                        else
                        {
                            paymentdetail.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        paymentdetail.Id = id;
                        paymentdetail.PaymentId = Convert.ToInt32(reader["PaymentId"].ToString());
                        paymentdetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"].ToString());
                        paymentdetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"].ToString());

                        if (reader["Discount"] is DBNull)
                        {
                            paymentdetail.Discount = null;
                        }
                        else
                        {
                            paymentdetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["DiscountPercent"] is DBNull)
                        {
                            paymentdetail.DiscountPercent = null;
                        }
                        else
                        {
                            paymentdetail.DiscountPercent = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["VatPercent"] is DBNull)
                        {
                            paymentdetail.VatPercent = null;
                        }
                        else
                        {
                            paymentdetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        paymentdetail.TransactionType = Convert.ToInt16(reader["TransactionType"].ToString());
                        paymentdetail.BankName = reader["BankName"] is DBNull ? null : reader["BankName"].ToString();
                        paymentdetail.CheckNo = reader["CheckNo"] is DBNull ? null : reader["CheckNo"].ToString();
                        paymentdetail.BkashTransactionNo = reader["BkashTransactionNo"] is DBNull ? null : reader["BkashTransactionNo"].ToString();




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
            return paymentdetail;

        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            PaymentDetail payment = new PaymentDetail();
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
                comm.CommandText = "Select count(*) from PaymentDetail " + whereClause;
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

        public int Save(PaymentDetail paymentdetail)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (paymentdetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO PaymentDetail(CreateTime, PaymentId," +
                                       " TotalExVat, TotalIncVat, Discount, DiscountPercent, VatPercent," +
                                       " TransactionType, BankName, CheckNo, BkashTransactionNo) VALUES(@CreateTime," +
                                       " @PaymentId, @TotalExVat, @TotalIncVat, @Discount," +
                                       " @DiscountPercent, @VatPercent, @TransactionType, @BankName," +
                                       " @CheckNo, @BkashTransactionNo); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update PaymentDetail SET  UpdateTime =@Updatetime," +
                                       " PaymentId = @PaymentId, TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, " +
                                       " Discount =@Discount, DiscountPercent = @DiscountPercent, VatPercent= @VatPercent," +
                                       " TransactionType= @TransactionType, BankName = @BankName," +
                                       "BkashTransactionNo = @BkashTransactionNo WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = paymentdetail.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                
                comm.Parameters.Add("@PaymentId", SqlDbType.Int).Value = paymentdetail.PaymentId;
                
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = paymentdetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = paymentdetail.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = paymentdetail.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = paymentdetail.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = paymentdetail.VatPercent;
                comm.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = paymentdetail.TransactionType;
                comm.Parameters.Add("@BankName", SqlDbType.VarChar).Value = paymentdetail.BankName;
                comm.Parameters.Add("@CheckNo", SqlDbType.VarChar).Value = paymentdetail.CheckNo;
                comm.Parameters.Add("@BkashTransactionNo", SqlDbType.VarChar).Value = paymentdetail.BkashTransactionNo;


                if (paymentdetail.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    paymentdetail.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = paymentdetail.Id;
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
