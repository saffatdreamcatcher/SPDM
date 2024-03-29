﻿using SPDM.DLL.Entities;
using SPDM.DLL.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SPDM.DLL.Repositories
{
    public class WorkOrderDLL
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
        private bool isEnableTransaction = false;
        public WorkOrderDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }

        public WorkOrderDLL(SqlTransaction sqlTrans)
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

                comm.CommandText = "Delete from WorkOrder where Id = " + id.ToString();
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

        public List<WorkOrder> GetAll(string whereClause = "")
        {
            var workorders = new List<WorkOrder>();
            
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

                //comm.CommandText = "Select * from  WorkOrder " + whereClause;
                comm.CommandText = "Select WorkOrder.*, Party.Name  AS PartyName from Party " +
                                    "inner join WorkOrder on WorkOrder.PartyId = Party.Id " + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        WorkOrder workorder = new WorkOrder(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            workorder.UpdateTime = null;
                        }
                        else
                        {
                            workorder.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        workorder.Id = id;
                        workorder.UserId = Convert.ToInt32(reader["UserId"]);
                        workorder.WorkOrderNo = reader["WorkOrderNo"].ToString();
                        workorder.Fiscalyear = reader["FiscalYear"].ToString();
                        workorder.PartyId = Convert.ToInt32(reader["PartyId"]);
                        workorder.WorkOrderDate = Convert.ToDateTime(reader["WorkOrderDate"]);
                        workorder.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                        workorder.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        workorder.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);


                        if (reader["VatPercent"] is DBNull)
                        {
                            workorder.VatPercent = null;
                        }
                        else
                        {
                            workorder.VatPercent = Convert.ToDouble(reader["VatPercent"]); 
                        }

                        workorder.Status = (WorkOrderStatus)Convert.ToInt32(reader["Status"]);
                        workorder.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        workorder.PartyName = reader["PartyName"].ToString();
                        workorders.Add(workorder);
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


        public WorkOrder GetById(int id)
        {
            WorkOrder workorder = new WorkOrder();
            

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.Transaction = sqlTransaction;

                //comm.CommandText = "Select * from WorkOrder where id = " + id;
                comm.CommandText = "Select WorkOrder.*, Party.Name  AS PartyName from Party " +
                                    "inner join WorkOrder on WorkOrder.PartyId = Party.Id and WorkOrder.Id= " + id;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            workorder.UpdateTime = null;
                        }
                        else
                        {
                            workorder.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        workorder.Id = id;
                        workorder.UserId = Convert.ToInt32(reader["UserId"]);
                        workorder.WorkOrderNo = reader["WorkOrderNo"].ToString();
                        workorder.Fiscalyear = reader["FiscalYear"].ToString();
                        workorder.PartyId = Convert.ToInt32(reader["PartyId"]);
                        workorder.WorkOrderDate = Convert.ToDateTime(reader["WorkOrderDate"]);
                        workorder.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                        workorder.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        workorder.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);


                        if (reader["VatPercent"] is DBNull)
                        {
                            workorder.VatPercent = null;
                        }
                        else
                        {
                            workorder.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        workorder.Status = (WorkOrderStatus)Convert.ToInt32(reader["Status"]);
                        workorder.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        workorder.PartyName = reader["PartyName"].ToString();

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
            return workorder;


        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            WorkOrder workorder = new WorkOrder();
            

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

                comm.CommandText = "Select count(*) from WorkOrder " + whereClause;
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

        public bool IsExist(string whereClause = "")
        {
            bool isExist = false;
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();

                comm.CommandText = "SELECT " +
                        "CASE WHEN COUNT( Id ) >= 1 THEN " +
                        "CAST( 1 as BIT ) " +
                        "ELSE " +
                        " CAST( 0 as BIT ) " +
                        "END As IsPresent " +
                        "FROM [dbo].[WorkOrder] " +
                        "WHERE " + whereClause ;
                isExist = Convert.ToBoolean(comm.ExecuteScalar());
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

            return isExist;
        }

        public int Save(WorkOrder workorder)
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

                if (workorder.IsNew)
                {
                    comm.CommandText = "INSERT INTO WorkOrder(CreateTime, UserId, FiscalYear, PartyId, " +
                                       "WorkOrderNo, WorkOrderDate, DeliveryDate, TotalExVat, TotalIncVat, Discount, " +
                                       "DiscountPercent, VatPercent, " +
                                       "Status, Note) VALUES(@CreateTime, @UserId," +
                                       "@FiscalYear, @PartyId, @WorkOrderNo, @WorkOrderDate, @DeliveryDate, @TotalExVat," +
                                       " @TotalIncVat, @Discount, @DiscountPercent, @VatPercent, " +
                                       " @Status, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                else
                {
                    comm.CommandText = "Update WorkOrder SET UpdateTime =@Updatetime, " +
                                       "UserId = @UserId, FiscalYear = @FiscalYear, " +
                                       "PartyId = @PartyId, WorkOrderNo = @WorkOrderNo, WorkOrderDate = @WorkOrderDate," +
                                       "TotalExVat= @TotalExVat, TotalIncVat = @TotalIncVat, Discount =@Discount," +
                                       "DiscountPercent = @DiscountPercent, VatPercent= @VatPercent, " +
                                       "DeliveryDate =  @DeliveryDate, " +
                                       "Status = @Status, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = workorder.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = workorder.UserId;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = workorder.Fiscalyear;
                comm.Parameters.Add("@PartyId", SqlDbType.Int).Value = workorder.PartyId;
                comm.Parameters.Add("@WorkOrderNo", SqlDbType.VarChar).Value = workorder.WorkOrderNo;
                comm.Parameters.Add("@WorkOrderDate", SqlDbType.DateTime).Value = workorder.WorkOrderDate;
                comm.Parameters.Add("@DeliveryDate", SqlDbType.DateTime).Value = workorder.DeliveryDate;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = workorder.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = workorder.TotalIncvat;

                if (workorder.Discount.HasValue)
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = workorder.Discount.Value;
                }
                else
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (workorder.DiscountPercent.HasValue)
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = workorder.DiscountPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (workorder.VatPercent.HasValue)
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = workorder.VatPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                comm.Parameters.Add("@Status", SqlDbType.SmallInt).Value = (Int16)workorder.Status;
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = workorder.Note;

                if (workorder.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    workorder.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = workorder.Id;
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
