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
    public class ProductionDLL
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
                comm.CommandText = "Delete from Production where Id = " + id.ToString();
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

        public List<Production> GetAll(string whereClause = "")
        {
            var productions = new List<Production>();
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
                comm.CommandText = "Select * from Production" + whereClause;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
                        Production production = new Production(id, createTime);
                        if (reader["UpdateTime"] is DBNull)
                        {
                            production.UpdateTime = null;
                        }
                        else
                        {
                            production.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        production.Id = id;
                        production.ProductionNo = reader["ProductionNo"].ToString();
                        production.UserId = Convert.ToInt32(reader["UserId"]);
                        production.Fiscalyear = reader["FiscalYear"].ToString();
                        production.PartyId = Convert.ToInt32(reader["PartyId"]);
                        production.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        production.WorkOrderDate = Convert.ToDateTime(reader["WorkOrderDate"]);
                        production.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        production.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        if (reader["Discount"] is DBNull)
                        {
                            production.Discount = null;
                        }
                        else
                        {
                            production.Discount = Convert.ToDouble(reader["Discount"]);
                        }
                        if (reader["DiscountPercent"] is DBNull)
                        {
                            production.DiscountPercent = null;
                        }
                        else
                        {
                            production.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }
                        if (reader["VatPercent"] is DBNull)
                        {
                            production.VatPercent = null;
                        }
                        else
                        {
                            production.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }
                        production.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
                        productions.Add(production);
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
            return productions;
        }

        public Production GetById(int id)
        {
            Production production = new Production();
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
                            production.UpdateTime = null;
                        }
                        else
                        {
                            production.UpdateTime = Convert.ToDateTime(reader["UpdateTime"]);
                        }
                        production.Id = id;
                        production.ProductionNo = reader["ProductionNo"].ToString();
                        production.UserId = Convert.ToInt32(reader["UserId"]);
                        production.Fiscalyear = reader["FiscalYear"].ToString();
                        production.PartyId = Convert.ToInt32(reader["PartyId"]);
                        production.WorkOrderId = Convert.ToInt32(reader["WorkOrderId"]);
                        production.WorkOrderDate = Convert.ToDateTime(reader["WorkOrderDate"]);
                        production.TotalExvat = Convert.ToDouble(reader["TotalExVat"]);
                        production.TotalIncvat = Convert.ToDouble(reader["TotalIncVat"]);
                        if (reader["Discount"] is DBNull)
                        {
                            production.Discount = null;
                        }
                        else
                        {
                            production.Discount = Convert.ToDouble(reader["Discount"]);

                        }
                        if (reader["DiscountPercent"] is DBNull)
                        {
                            production.DiscountPercent = null;
                        }
                        else
                        {
                            production.DiscountPercent = Convert.ToDouble(reader["DiscountPercent"]);
                        }
                        if (reader["VatPercent"] is DBNull)
                        {
                            production.VatPercent = null;
                        }
                        else
                        {
                            production.VatPercent = Convert.ToDouble(reader["VatPercent"]);
                        }

                        production.Note = reader["Note"] is DBNull ? null : reader["Note"].ToString();
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
            return production;

        }


        public int GetCount(string whereClause = "")
        {

            int count = 0;
            Production production = new Production();
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
                comm.CommandText = "Select count(*) from Production " + whereClause;
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

        public int Save(Production production)
        {
            int primaryKey = 0;
            var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                SqlCommand comm = conn.CreateCommand();

                if (production.IsNew)
                {
                    comm.CommandText = "INSERT INTO Production(CreateTime, UserId, ProductionNo, FiscalYear," +
                        "PartyId, WorkOrderId, WorkOrderDate, TotalExVat, TotalIncVat, Discount, " +
                        "DiscountPercent, VatPercent, Note) VALUES (@CreateTime, @UserId, @ProductionNo, " +
                        "@FiscalYear, @PartyId, @WorkOrderId, @WorkOrderDate, @TotalExVat," +
                        " @TotalIncVat, @Discount, @DiscountPercent, @VatPercent, @Note); SELECT SCOPE_IDENTITY()";
                    comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
                }
                else
                {
                    comm.CommandText = "Update Production SET  UpdateTime = @Updatetime," +
                        "UserId = @UserId, ProductionNo = @ProductionNo, FiscalYear = @FiscalYear, PartyId = @PartyId, " +
                        "WorkOrderId = @WorkOrderId, WorkOrderDate = @WorkOrderDate, TotalExVat= @TotalExVat, " +
                        "TotalIncVat = @TotalIncVat, Discount = @Discount, DiscountPercent = @DiscountPercent, " +
                        "VatPercent = @VatPercent, Note= @Note WHERE Id = @Id";
                    comm.Parameters.Add("@Id", SqlDbType.Int).Value = production.Id;
                    comm.Parameters.Add("@UpdateTime", SqlDbType.DateTime).Value = DateTime.Now;
                }
                comm.Parameters.Add("@UserId", SqlDbType.VarChar).Value = production.UserId;
                comm.Parameters.Add("@ProductionNo", SqlDbType.VarChar).Value = production.ProductionNo;
                comm.Parameters.Add("@FiscalYear", SqlDbType.VarChar).Value = production.Fiscalyear;
                comm.Parameters.Add("@PartyId", SqlDbType.Int).Value = production.PartyId;
                comm.Parameters.Add("@WorkOrderId", SqlDbType.Int).Value = production.WorkOrderId;
                comm.Parameters.Add("@WorkOrderDate", SqlDbType.DateTime).Value = production.WorkOrderDate;
                comm.Parameters.Add("@TotalExVat", SqlDbType.Decimal).Value = production.TotalExvat;
                comm.Parameters.Add("@TotalIncVat", SqlDbType.Decimal).Value = production.TotalIncvat;
                if (production.Discount.HasValue)
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = production.Discount.Value;
                }
                else
                {
                    comm.Parameters.Add("@Discount", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (production.DiscountPercent.HasValue)
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = production.DiscountPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@DiscountPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (production.VatPercent.HasValue)
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = production.VatPercent.Value;
                }
                else
                {
                    comm.Parameters.Add("@VatPercent", SqlDbType.Decimal).Value = DBNull.Value;
                }
                
                comm.Parameters.Add("@Note", SqlDbType.VarChar).Value = production.Note;

                if (production.IsNew)
                {
                    primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                    production.Id = primaryKey;
                }
                else
                {
                    comm.ExecuteNonQuery();
                    primaryKey = production.Id;
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
