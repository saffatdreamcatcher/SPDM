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
    public class ProductionDetailDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public ProductionDetailDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }


        public ProductionDetailDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from ProductionDetail where Id = " + id.ToString();
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

        public List<ProductionDetail> GetAll(string whereClause = "")
        {
            var productiondetails = new List<ProductionDetail>();
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
                comm.CommandText = "Select * from ProductionDetail " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        ProductionDetail productiondetail = new ProductionDetail(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            productiondetail.UpdateTime = null;
                        }
                        else
                        {
                            productiondetail.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        productiondetail.Id = id;
                        productiondetail.ProductionId = Convert.ToInt32(reader["ProductionId"]);
                        productiondetail.WorkOrderDetailId = Convert.ToInt32(reader["WorkOrderDetailId"]);
                        productiondetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        productiondetail.Unit = Convert.ToInt32(reader["Unit"]);
                        productiondetail.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                        productiondetail.Length = Convert.ToDouble(reader["Length"]);
                        productiondetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        productiondetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        

                        if (reader["Discount"] is DBNull)
                        {
                            productiondetail.Discount = null;
                        }
                        else
                        {
                            productiondetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["DiscountPercent"] is DBNull)
                        {
                            productiondetail.DiscountPercent = null;
                        }
                        else
                        {
                            productiondetail.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }

                        if (reader["VatPercent"] is DBNull)
                        {
                            productiondetail.VatPercent = null;
                        }
                        else
                        {
                            productiondetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }
                            

                        productiondetails.Add(productiondetail);
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
            return productiondetails;
        }

        public ProductionDetail GetById(int id)
        {
            ProductionDetail productiondetail = new ProductionDetail();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from Production where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            productiondetail.UpdateTime = null;
                        }
                        else
                        {
                            productiondetail.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        productiondetail.Id = id;
                        productiondetail.ProductionId = Convert.ToInt32(reader["ProductionId"]);
                        productiondetail.WorkOrderDetailId = Convert.ToInt32(reader["WorkOrderDetailId"]);
                        productiondetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        productiondetail.Unit = Convert.ToInt32(reader["Unit"]);
                        productiondetail.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                        productiondetail.Length = Convert.ToDouble(reader["Length"]);
                        productiondetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        productiondetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        if (reader["Discount"] is DBNull)
                        {
                            productiondetail.Discount = null;
                        }
                        else
                        {
                            productiondetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }
                        productiondetail.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"] is DBNull ? null : reader["DiscountPercent"].ToString());
                        productiondetail.VatPercent = Convert.ToDouble(reader["VatPercent"] is DBNull ? null : reader["VatPercent"].ToString());


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
            return productiondetail;

        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            ProductionDetail productiondetail = new ProductionDetail();
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
                comm.CommandText = "Select count(*) from ProductionDetail " + whereClause;
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


        public int Save(ProductionDetail productiondetail)
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

                if (productiondetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO ProductionDetail(CreateTime, ProductionId," +
                        "WorkOrderDetailId, ItemId, Unit, UnitPrice, Length, TotalExVat, TotalIncVat, Discount, " +
                        "DiscountPercent, VatPercent) VALUES (@CreateTime, @ProductionId, " +
                        "@WorkOrderDetailId, @ItemId, @Unit, @UnitPrice, @Length, @TotalExVat," +
                        " @TotalIncVat, @Discount, @DiscountPercent, @VatPercent); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update ProductionDetail SET UpdateTime =@Updatetime," +
                        "ProductionId = @ProductionId, " +
                        "WorkOrderDetailId = @WorkOrderDetailId, ItemId =@ItemId, Unit = @Unit, Length= @Length, TotalExVat= @TotalExVat, " +
                        "TotalIncVat = @TotalIncVat, Discount =@Discount, DiscountPercent = @DiscountPercent, " +
                        "VatPercent = @VatPercent WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = productiondetail.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@ProductionId", SqlDbType.VarChar).Value = productiondetail.ProductionId;
                comm.Parameters.Add("@WorkOrderDetailId", SqlDbType.Int).Value = productiondetail.WorkOrderDetailId;
                comm.Parameters.Add("@ItemId", SqlDbType.VarChar).Value = productiondetail.ItemId;
                comm.Parameters.Add("@Unit", SqlDbType.VarChar).Value = productiondetail.Unit;
                comm.Parameters.Add("@UnitPrice", SqlDbType.VarChar).Value = productiondetail.UnitPrice;
                comm.Parameters.Add("@Length", SqlDbType.VarChar).Value = productiondetail.Length;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = productiondetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = productiondetail.TotalIncvat;
                
                if (productiondetail.Discount.HasValue)
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = productiondetail.Discount.Value;
                }
                else
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (productiondetail.DiscountPercent.HasValue)
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = productiondetail.DiscountPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }
                
                if (productiondetail.VatPercent.HasValue)
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = productiondetail.VatPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }


                if (productiondetail.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    productiondetail.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = productiondetail.Id;
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
