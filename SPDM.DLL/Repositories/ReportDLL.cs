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
    }
}