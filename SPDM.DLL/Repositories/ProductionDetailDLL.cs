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
                comm.CommandText = "Delete from ProductionDetail where Id = " + id.ToString();
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
                        productiondetail.ProductionId = Convert.ToInt32(reader["ProductionId"]);
                        productiondetail.WorkOrderDetailId = Convert.ToInt32(reader["WorkOrderDetailId"]);
                        productiondetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        productiondetail.Unit = Convert.ToInt32(reader["Unit"]);
                        productiondetail.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                        productiondetail.Length = Convert.ToDouble(reader["Length"]);
                        productiondetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        productiondetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        productiondetail.Discount = Convert.ToDouble(reader["Discount"]);
                       
                        if (reader["DiscountPercent"] is DBNull)
                        {
                            productiondetail.DiscountPercent = null;
                        }
                        else
                        {
                            productiondetail.DiscountPercent = Convert.ToDouble(reader["Discount"]);
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
                        productiondetail.ProductionId = Convert.ToInt32(reader["ProductionId"]);
                        productiondetail.WorkOrderDetailId = Convert.ToInt32(reader["WorkOrderDetailId"]);
                        productiondetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        productiondetail.Unit = Convert.ToInt32(reader["Unit"]);
                        productiondetail.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                        productiondetail.Length = Convert.ToDouble(reader["Length"]);
                        productiondetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        productiondetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        productiondetail.Discount = Convert.ToDouble(reader["Discount"]);
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
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (productiondetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO ProductionDetail(CreateTime, UpdateTime, UserId, ProductionId," +
                        "PartyId, WorkOrderDetailId, ItemId, Unit, UnitPrice, Length, TotalExVat, TotalIncVat, Discount, " +
                        "DiscountPercent, Vat Percent, Status, Note) VALUES(@CreateTime, @UpdateTime, @UserId, @ProductionId " +
                        "@FiscalYear, @PartyId, @WorkOrderDetailId, @ItemId, @Unit, @UnitPrice, @Length, @TotalExVat," +
                        " @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, @Status @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update ProductionDetail SET  CreateTime = @CreateTime, UpdateTime =@Updatetime," +
                        "ProductionId = @ProductionId, " +
                        "WorkOrderDetailId = @WorkOrderDetailId, ItemId =@ItemId, Unit = @Unit, Length= @Length TotalExVat= @TotalExVat, " +
                        "TotalIncVat = @TotalIncVat, Discount =@Discount, DiscountPercent = @DiscountPercent, " +
                        "Status= @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = productiondetail.Id;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = productiondetail.ProductionId;
                comm.Parameters.Add("@WorkOrderDetailId", SqlDbType.Int).Value = productiondetail.WorkOrderDetailId;
                comm.Parameters.Add("@ItemId", SqlDbType.VarChar).Value = productiondetail.ItemId;
                comm.Parameters.Add("@Unit", SqlDbType.VarChar).Value = productiondetail.Unit;
                comm.Parameters.Add("@UnitPrice", SqlDbType.VarChar).Value = productiondetail.UnitPrice;
                comm.Parameters.Add("@Length", SqlDbType.VarChar).Value = productiondetail.Length;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = productiondetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = productiondetail.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = productiondetail.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = productiondetail.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.VarChar).Value = productiondetail.VatPercent;
                

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
                conn.Close();
            }
            return primaryKey;
        }




    }
}
