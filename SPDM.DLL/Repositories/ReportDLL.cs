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
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection2"].ConnectionString;
            sqlConnection = new SqlConnection(myConnectionString);
        }

        public DataSet GetWorkOrders(string whereClause = "")
        {
            DataSet ds = new DataSet();
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
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "WorkOrderSP";

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