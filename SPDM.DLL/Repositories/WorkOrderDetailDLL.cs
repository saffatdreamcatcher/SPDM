﻿using SPDM.DLL.Entities;
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
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public WorkOrderDetailDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }

        public WorkOrderDetailDLL(SqlTransaction sqlTrans)
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
            
            try
            {
                
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Delete from WorkOrderDetail where Id = " + id.ToString();
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

        

        public List<WorkOrderDetail> GetAll(string whereClause = "")
        {
            var workorders = new List<WorkOrderDetail>();
            
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Select WorkOrderDetail.*, Item.Name AS ItemName from WorkOrderDetail " +
                                     "inner join Item on WorkOrderDetail.ItemId = Item.Id " + whereClause;

                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        WorkOrderDetail workorderdetail = new WorkOrderDetail(id, createTime);

                        if (reader["UpdateTime"] is DBNull)
                        {
                            workorderdetail.UpdateTime = null;
                        }
                        else
                        {
                            workorderdetail.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        
                        workorderdetail.ItemId = Convert.ToInt32(reader["ItemId"]);
                        workorderdetail.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        workorderdetail.Unit = Convert.ToInt32(reader["Unit"]);
                        workorderdetail.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                        workorderdetail.Length = Convert.ToDouble(reader["Length"]);
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
                        workorderdetail.ItemName = reader["ItemName"].ToString();

                        if (reader["Drum"] is DBNull)
                        {
                            workorderdetail.Drum = null;
                        }
                        else
                        {
                            workorderdetail.Drum = Convert.ToDouble(reader["Drum"]);
                        }

                        workorders.Add(workorderdetail);
                    }
                }

            }
            catch (Exception ex)
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
            return workorders;
        }


        public WorkOrderDetail GetById(int id)
        {
            WorkOrderDetail workorderdetail = new WorkOrderDetail();
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Select WorkOrderDetail.*, Item.Name AS ItemName from WorkOrderDetail " +
                                   "inner join Item on WorkOrderDetail.ItemId = Item.Id where WorkOrderDetail.Id =" + id;
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

                        workorderdetail.ItemName = reader["ItemName"].ToString();


                        if (reader["Drum"] is DBNull)
                        {
                            workorderdetail.Drum = null;
                        }
                        else
                        {
                            workorderdetail.Drum = Convert.ToDouble(reader["Drum"]);
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
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return workorderdetail;


        }

        public int GetCount(string whereClause = "")
        {

            int count = 0;
            WorkOrderDetail workorderdetail = new WorkOrderDetail();

            try
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    whereClause = " Where " + whereClause;
                }

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                comm.CommandText = "Select count(*) from WorkOrderDetail " + whereClause;
                count = Convert.ToInt32(comm.ExecuteScalar());
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
            return count;
        }

        public int Save(WorkOrderDetail workorderdetail)
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

                if (workorderdetail.IsNew)
                {
                    comm.CommandText = "INSERT INTO WorkOrderDetail(CreateTime, WorkOrderId, ItemId, Unit, " +
                                       "UnitPrice, Length, TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, VatPercent, Drum " +
                                       ") VALUES(@CreateTime, @WorkOrderId," +
                                       " @ItemId, @Unit, @UnitPrice, @Length, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @VatPercent, @Drum " +
                                       "); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    comm.CommandText = "Update  WorkOrderDetail SET UpdateTime =@Updatetime, " +
                                       "WorkOrderId = @WorkOrderId, " +
                                       "ItemId = @ItemId, Unit = @Unit, UnitPrice = @UnitPrice, Length = @Length ," +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, VatPercent = @VatPercent, Drum = @Drum " +
                                       " WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = workorderdetail.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@WorkOrderId", SqlDbType.VarChar).Value = workorderdetail.WorkOrderId;
                comm.Parameters.Add("@ItemId", SqlDbType.Int).Value = workorderdetail.ItemId;
                comm.Parameters.Add("@Unit", SqlDbType.Int).Value = workorderdetail.Unit;
                comm.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = workorderdetail.UnitPrice;
                comm.Parameters.Add("@Length", SqlDbType.Decimal).Value = workorderdetail.Length;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = workorderdetail.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = workorderdetail.TotalIncvat;
                if (workorderdetail.Discount.HasValue)
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = workorderdetail.Discount.Value;
                }
                else
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (workorderdetail.DiscountPercent.HasValue)
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = workorderdetail.DiscountPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (workorderdetail.VatPercent.HasValue)
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = workorderdetail.VatPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (workorderdetail.Drum.HasValue)
                {
                    comm.Parameters.Add("@Drum", SqlDbType.Decimal).Value = workorderdetail.Drum.Value;
                }
                else
                {
                    comm.Parameters.Add("@Drum", SqlDbType.Decimal).Value = DBNull.Value;
                }


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
                if (!isEnableTransaction)
                {
                    sqlConnection.Close();
                }
            }
            return primaryKey;
        }


    }
}
