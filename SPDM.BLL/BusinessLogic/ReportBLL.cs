using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class ReportBLL
    {
        public DataSet GetWorkOrders(string whereClause = "")
        {
            try
            {
                ReportDLL reportDLL = new ReportDLL();
                return reportDLL.GetWorkOrders(whereClause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetWOWithDetailTest(string whereClause = "")
        {
            try
            {
                ReportDLL reportDLL = new ReportDLL();
                return reportDLL.GetWOWithDetailTest(whereClause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchWorkOrder(string workOrderNo, int? partyId, int? status)
        {
            try
            {
                ReportDLL reportDLL= new ReportDLL();
                return reportDLL.SearchWorkOrder(workOrderNo, partyId, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetStock(string whereClause = "")
        {
            try
            {
                ReportDLL reportDLL = new ReportDLL();
                return reportDLL.GetStock(whereClause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
