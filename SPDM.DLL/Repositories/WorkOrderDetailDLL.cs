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
    public class WorkOrderDetailDLL
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
                comm.CommandText = "Delete from WorkOrderDetail where Id = " + id.ToString();
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


        public List<WorkOrderDetail> GetAll(string whereClause = "")
        {
            var workorders = new List<WorkOrderDetail>();
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
                comm.CommandText = "Select * from WorkOrderDetail" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime Updatetime = Convert.ToDateTime(reader["UpdateTime"]);
                        WorkOrderDetail workorderdetail = new WorkOrderDetail(id, createTime);
                        workorderdetail.ItemId = Convert.ToInt32(reader["UserId"]);
                        workorderdetail.WorkOrderId = Convert.ToInt32(reader["WorkOrderNo"]);
                        workorderdetail.Unit = Convert.ToInt32(reader["Unit"]);
                        workorderdetail.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                        workorderdetail.Length = Convert.ToDouble(reader["DeliveryDate"]);
                        workorderdetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        workorderdetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);

                        if (reader["Discount"] is DBNull)
                        {
                            workorderdetail.Discount = null;
                        }
                        else
                        {
                            workorderdetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["DiscountPercent"] is DBNull)
                        {
                            workorderdetail.DiscountPercent = null;
                        }
                        else
                        {
                            workorderdetail.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }


                        if (reader["VatPercent"] is DBNull)
                        {
                            workorderdetail.VatPercent = null;
                        }
                        else
                        {
                            workorderdetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        
                        workorders.Add(workorderdetail);
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
            return workorders;
        }


        public WorkOrderDetail GetById(int id)
        {
            WorkOrderDetail workorderdetail = new WorkOrderDetail();
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * from WorkOrderDetail where id = " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        DateTime updateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        workorderdetail.ItemId = Convert.ToInt32(reader["UserId"]);
                        workorderdetail.WorkOrderId = Convert.ToInt32(reader["WorkOrderNo"]);
                        workorderdetail.Unit = Convert.ToInt32(reader["Unit"]);
                        workorderdetail.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                        workorderdetail.Length = Convert.ToDouble(reader["DeliveryDate"]);
                        workorderdetail.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        workorderdetail.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);

                        if (reader["Discount"] is DBNull)
                        {
                            workorderdetail.Discount = null;
                        }
                        else
                        {
                            workorderdetail.Discount = Convert.ToDouble(reader["Discount"]);
                        }

                        if (reader["DiscountPercent"] is DBNull)
                        {
                            workorderdetail.DiscountPercent = null;
                        }
                        else
                        {
                            workorderdetail.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }


                        if (reader["VatPercent"] is DBNull)
                        {
                            workorderdetail.VatPercent = null;
                        }
                        else
                        {
                            workorderdetail.VatPercent = Convert.ToDouble(reader["VatPercent"]);
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
            return workorderdetail;


        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            WorkOrderDetail workorderdetail = new WorkOrderDetail();
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
                comm.CommandText = "Select count(*) from WorkOrderDetail " + whereClause;
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

        public int Save(WorkOrderDetail workorderdetail)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (workorderdetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO Sale(CreateTime, UpdateTime, WorkOrderId, ItemId, Unit, " +
                                       "UnitPrice, Length, TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, Vat Percent, " +
                                       ") VALUES(@CreateTime, @UpdateTime, @WorkOrderId," +
                                       " @ItemId, @Unit, @UnitPrice, @Length, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @Vat Percent, " +
                                       "); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Sale SET  CreateTime = @CreateTime, UpdateTime =@Updatetime, " +
                                       "WorkOrderId = @WorkOrderId, " +
                                       "ItemId = @ItemId, Unit = @Unit, UnitPrice = @UnitPrice, Length = @Length ," +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, Vat Percent= @VatPercent, " +
                                       " " +
                                       " WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = workorderdetail.Id;
                }
                comm.Parameters.Add("@WorkOrderId", SqlDbType.VarChar).Value = workorderdetail.WorkOrderId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = workorderdetail.ItemId;
                comm.Parameters.Add("@Unit", SqlDbType.Int).Value = workorderdetail.Unit;
                comm.Parameters.Add("@UnitPrice", SqlDbType.Int).Value = workorderdetail.UnitPrice;
                comm.Parameters.Add("@Length", SqlDbType.DateTime).Value = workorderdetail.Length;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = workorderdetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = workorderdetail.TotalIncvat;
                comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = workorderdetail.Discount;
                comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = workorderdetail.DiscountPercent;
                comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = workorderdetail.VatPercent;
                

                if (workorderdetail.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    workorderdetail.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = workorderdetail.Id;
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
