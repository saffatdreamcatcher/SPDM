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
    public class PaymentDLL
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
                comm.CommandText = "Delete from Payment where Id = " + id.ToString();
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

        public List<Payment> GetAll(string whereClause = "")
        {
            var payments = new List<Payment>();
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
                comm.CommandText = "Select * from Payment" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        Payment payment = new Payment(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            payment.UpdateTime = null;
                        }
                        else
                        {
                            payment.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        payment.Id = id;
                        payment.UserId = Convert.ToInt32(reader["UserId"]);
                        payment.Fiscalyear = reader["FiscalYear"].ToString();
                        payment.SaleId = Convert.ToInt32(reader["SaleId"]);
                        payment.PartyId = Convert.ToInt32(reader["PartyId"]);
                        payment.PaymentType = Convert.ToInt32(reader["PaymentType"]);
                        payment.TransactionDate = Convert.ToDateTime(reader["TransactionDate"]);
                        payment.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        payment.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                       
                        if (reader["Discount"] is DBNull)
                        {
                            payment.Discount = null;
                        }
                        else
                        {
                            payment.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["VatPercent"] is DBNull)
                        {
                            payment.VatPercent = null;
                        }
                        else
                        {
                            payment.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        payment.TransactionType = Convert.ToInt32(reader["TransactionType"]);

                        if (reader["BankName"] is DBNull)
                        {
                            payment.BankName = null;
                        }
                        else
                        {
                            payment.BankName = reader["BankName"].ToString();
                        }

                        if (reader["CheckNo"] is DBNull)
                        {
                            payment.CheckNo = null;
                        }
                        else
                        {
                            payment.CheckNo = reader["CheckNo"].ToString();
                        }

                        if (reader["BkashTransactionNo"] is DBNull)
                        {
                            payment.BkashTransactionNo = null;
                        }
                        else
                        {
                            payment.BkashTransactionNo = reader["BkashTransactionNo"].ToString();
                        }
                        payment.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        payments.Add(payment);
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
            return payments;
        }

        public Payment GetById(int id)
        {
            Payment payment = new Payment();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Payment where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            payment.UpdateTime = null;
                        }
                        else
                        {
                            payment.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        payment.Id = id;
                        payment.UserId = Convert.ToInt32(reader["UserId"]);
                        payment.Fiscalyear = reader["FiscalYear"].ToString();
                        payment.SaleId = Convert.ToInt32(reader["SaleId"]);
                        payment.PartyId = Convert.ToInt32(reader["PartyId"]);
                        payment.PaymentType = Convert.ToInt32(reader["PaymentType"]);
                        payment.TransactionDate = Convert.ToDateTime(reader["TransactionDate"]);
                        payment.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        payment.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);

                        if (reader["Discount"] is DBNull)
                        {
                            payment.Discount = null;
                        }
                        else
                        {
                            payment.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["VatPercent"] is DBNull)
                        {
                            payment.VatPercent = null;
                        }
                        else
                        {
                            payment.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        payment.TransactionType = Convert.ToInt32(reader["TransactionType"]);

                        if (reader["BankName"] is DBNull)
                        {
                            payment.BankName = null;
                        }
                        else
                        {
                            payment.BankName = reader["BankName"].ToString();
                        }

                        if (reader["CheckNo"] is DBNull)
                        {
                            payment.CheckNo = null;
                        }
                        else
                        {
                            payment.CheckNo = reader["CheckNo"].ToString();
                        }

                        if (reader["BkashTransactionNo"] is DBNull)
                        {
                            payment.BkashTransactionNo = null;
                        }
                        else
                        {
                            payment.BkashTransactionNo = reader["BkashTransactionNo"].ToString();
                        }
                        payment.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();




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
            return payment;

        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Payment payment = new Payment();
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
                comm.CommandText = "Select count(*) from Payment " + whereClause;
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

        public int Save(Payment payment)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (payment.IsNew)
                {
                    comm.CommandText = "INSERT INTO Payment(CreateTime, UserId, FiscalYear, SaleId, PartyId, PaymentType, TransactionDate, " +
                        "TotalExVat, TotalIncVat, Discount, DiscountPercent, VatPercent, TransactionType, BankName, CheckNo, BkashTransactionNo" +
                        " Note) VALUES(@CreateTime, @UserId, @FiscalYear, @SaleId, @PartyId, @PaymentType, @TransactionDate, " +
                        "@TotalExVat, @TotalIncVat, @Discount, @DiscountPercent, @VatPercent, @TransactionType, @BankName, @CheckNo, @BkashTransactionNo" +
                        " @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Payment SET  UpdateTime =@Updatetime, UserId = @UserId, FiscalYear = @FiscalYear, SaleId = @SaleId," +
                        " PartyId = @PartyId, PaymentType = @PaymentType,TransactionDate = @TransactionDate, TotalExVat= @TotalExVat, " +
                        "TotalIncVat = @TotalIncVat, Discount =@Discount, DiscountPercent = @DiscountPercent, VatPercent= @VatPercent," +
                        "TransactionType = @TransactionType, BankName = @BankName , CheckNo = @CheckNo, BkashTransactionNo = @BkashTransactionNo," +
                        " Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = payment.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = payment.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = payment.Fiscalyear;
                comm.Parameters.Add("@SaleId", SqlDbType.Int).Value = payment.SaleId;
                comm.Parameters.Add("@PartyId", SqlDbType.Int).Value = payment.PartyId;
                comm.Parameters.Add("@PaymentType", SqlDbType.Int).Value = payment.PaymentType;
                comm.Parameters.Add("@TransactionDate", SqlDbType.DateTime).Value = payment.TransactionDate;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = payment.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = payment.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = payment.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = payment.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = payment.VatPercent;
                comm.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = payment.TransactionType;
                comm.Parameters.Add("@BankName", SqlDbType.VarChar).Value = payment.BankName;
                comm.Parameters.Add("@CheckNo", SqlDbType.VarChar).Value = payment.CheckNo;
                comm.Parameters.Add("@BkashTransactionNo", SqlDbType.VarChar).Value = payment.BkashTransactionNo;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = payment.Note;

                if (payment.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    payment.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = payment.Id;
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
