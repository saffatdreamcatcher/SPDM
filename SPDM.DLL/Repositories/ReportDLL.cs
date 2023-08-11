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
    public class ReportDLL
    {
        private SqlConnection sqlConnection;

        public ReportDLL()
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }

        public DataSet GetWorkOrders(string whereClause = "")
        {
            DataSet ds = new DataSet();
            try
            {
                //if (!string.IsNullOrEmpty(whereClause))
                //{
                //    whereClause = " Where " + whereClause;
                //}

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "WorkOrderSPTest";
                comm.Parameters.Add("@whereClause", SqlDbType.VarChar).Value = whereClause;
                SqlDataAdapter da = new SqlDataAdapter();
               
                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                ds.Tables[0].TableName = "Result1";
                ds.Tables[1].TableName = "Result2";

                ds.Relations.Add("hhh", ds.Tables["Result1"].Columns["Id"], ds.Tables["Result2"].Columns["WorkOrderId"]);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

                sqlConnection.Close();
            }
            return ds;
        }

        public DataSet GetWOWithDetailTest(string whereClause = "")
        {
            DataSet ds = new DataSet();
            try
            {
               

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "WorkOrderSPTest2";
                
                
                SqlDataAdapter da = new SqlDataAdapter();

                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                

            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {

                sqlConnection.Close();
            }
            return ds;
        }


        public DataSet SearchWorkOrder(string workOrderNo, int? partyId, int? status)
        {
            DataSet ds = new DataSet();
            try
            {


                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "SearchWorkOrder";
                if(String.IsNullOrEmpty(workOrderNo))
                {
                    comm.Parameters.Add("WorkOrderNo", SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("WorkOrderNo", SqlDbType.VarChar).Value = workOrderNo;
                }
                //comm.Parameters.Add("WorkOrderNo", SqlDbType.VarChar).Value = workOrderNo;
                if (partyId.HasValue && partyId.Value > 0)
                {
                    comm.Parameters.Add("PartyId", SqlDbType.Int).Value = partyId;
                }
                else
                {
                    comm.Parameters.Add("PartyId", SqlDbType.Int).Value = DBNull.Value;
                }
                if (status.HasValue)
                {
                    comm.Parameters.Add("@Status", SqlDbType.TinyInt).Value = status;
                }
                else
                {
                    comm.Parameters.Add("@Status", SqlDbType.TinyInt).Value = DBNull.Value;
                }
                SqlDataAdapter da = new SqlDataAdapter();

                da = new SqlDataAdapter(comm);
                da.Fill(ds);


            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {

                sqlConnection.Close();
            }
            return ds;
        }

        public DataTable SearchStock(int? categoryId, int? itemId, string drum, string coil)
        {
            DataTable dt = new DataTable();
            try
            {

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "SerachStock";

                if (categoryId.HasValue)
                {
                    comm.Parameters.Add("CategoryId", SqlDbType.Int).Value = categoryId;
                }
                else
                {
                    comm.Parameters.Add("CategoryId", SqlDbType.Int).Value = DBNull.Value;
                }

                if (itemId.HasValue)
                {
                    comm.Parameters.Add("ItemId", SqlDbType.Int).Value = itemId;
                }
                else
                {
                    comm.Parameters.Add("ItemId", SqlDbType.Int).Value = DBNull.Value;
                }


                if (String.IsNullOrEmpty(drum))
                {
                    comm.Parameters.Add("Drum", SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("Drum", SqlDbType.VarChar).Value = drum;
                }
                if (String.IsNullOrEmpty(coil))
                {
                    comm.Parameters.Add("Coil", SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("Coil", SqlDbType.VarChar).Value = coil;
                }


                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(comm);
                da.Fill(dt);


            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {

                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable GetStock(string whereClause = "" )
        {
            DataTable dt = new DataTable();
            try
            {


                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "StockSPTest";


                SqlDataAdapter da = new SqlDataAdapter();

                da = new SqlDataAdapter(comm);
                da.Fill(dt);


            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {

                sqlConnection.Close();
            }
            return dt;
        }

        public DataSet SearchSale(String challanNo)
        {
            DataSet ds = new DataSet();
            try
            {


                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand comm = sqlConnection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "SearchSale";
                if (String.IsNullOrEmpty(challanNo))
                {
                    comm.Parameters.Add("ChallanNo", SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    comm.Parameters.Add("ChallanNo", SqlDbType.VarChar).Value = challanNo;
                }
                
                SqlDataAdapter da = new SqlDataAdapter();

                da = new SqlDataAdapter(comm);
                da.Fill(ds);


            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {

                sqlConnection.Close();
            }
            return ds;
        }
    }

    }
