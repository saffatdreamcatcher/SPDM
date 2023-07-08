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
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public SaleDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public SaleDLL(SqlTransaction sqlTrans)
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
                        
                        Sale sale = new Sale(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            sale.UpdateTime = null;
                        }
                        else
                        {
                            sale.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        sale.Id = id;
                        sale.UserId = Convert.ToInt32(reader["UserId"]);
                        sale.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        sale.Fiscalyear = reader["FiscalYear"].ToString();
                        sale.PartyId = Convert.ToInt32(reader["PartyId"]);
                        sale.ChallanNo = Convert.ToInt32(reader["ChallanNo"]);
                        sale.SaleDate = Convert.ToDateTime(reader["SaleDate"]);
                        sale.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        sale.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        if (reader["Discount"] is DBNull)
                        {
                            sale.Discount = null;
                        }
                        else
                        {
                            sale.Discount = Convert.ToDouble(reader["Discount"]);
                        }
                        if (reader["DiscountPercent"] is DBNull)
                        {
                            sale.DiscountPercent = null;
                        }
                        else
                        {
                            sale.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }

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
                        if (reader["UpdateTime"] is DBNull)
                        {
                            sale.UpdateTime = null;
                        }
                        else
                        {
                            sale.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        sale.Id = id;
                        sale.UserId = Convert.ToInt32(reader["UserId"]);
                        sale.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        sale.Fiscalyear = reader["FiscalYear"].ToString();
                        sale.PartyId = Convert.ToInt32(reader["PartyId"]);
                        sale.ChallanNo = Convert.ToInt32(reader["ChallanNo"]);
                        sale.SaleDate = Convert.ToDateTime(reader["SaleDate"]);
                        sale.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        sale.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);

                        if (reader["Discount"] is DBNull)
                        {
                            sale.Discount = null;
                        }
                        else
                        {
                            sale.Discount = Convert.ToDouble(reader["Discount"]);
                        }
                        if (reader["DiscountPercent"] is DBNull)
                        {
                            sale.DiscountPercent = null;
                        }
                        else
                        {
                            sale.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }

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

                if (sale.IsNew)
                {
                    comm.CommandText = "INSERT INTO Sale(CreateTime, UserId, FiscalYear, WorkOrderId, PartyId, " +
                                       "ChallanNo, SaleDate, TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, VatPercent, DeliveryAddress, DeliveryDate, " +
                                       "Note) VALUES(@CreateTime, @UserId," +
                                       "@FiscalYear, @WorkOrderId, @PartyId, @ChallanNo, @SaleDate, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @VatPercent, " +
                                       " @DeliveryAddress, @DeliveryDate, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    comm.CommandText = "Update Sale SET UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, " +
                                       "PartyId = @PartyId, ChallanNo = @ChallanNo, SaleDate = @SaleDate," +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, VatPercent= @VatPercent, " +
                                       "DeliveryAddress = @DeliveryAddress, DeliveryDate =  @DeliveryDate, " +
                                       "Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = sale.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = sale.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = sale.Fiscalyear;
                comm.Parameters.Add("@WorkOrderId", SqlDbType.Int).Value = sale.WorkOrderId;
                comm.Parameters.Add("@PartyId", SqlDbType.Int).Value = sale.PartyId;
                comm.Parameters.Add("@ChallanNo", SqlDbType.Int).Value = sale.ChallanNo;
                comm.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = sale.SaleDate;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = sale.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = sale.TotalIncvat;
                
                if (sale.Discount.HasValue)
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = sale.Discount.Value;
                }
                else
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = DBNull.Value;
                }
                if (sale.DiscountPercent.HasValue)
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = sale.DiscountPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (sale.VatPercent.HasValue)
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = sale.VatPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                comm.Parameters.Add("@DeliveryAddress", SqlDbType.Text).Value = sale.DeliveryAddress;
                comm.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = sale.DeliveryDate;
                comm.Parameters.Add("@Note", SqlDbType.Text).Value = sale.Note;

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
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return primaryKey;
        }


    }
}
