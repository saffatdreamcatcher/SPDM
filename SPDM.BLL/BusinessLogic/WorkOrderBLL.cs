using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class WorkOrderBLL
    {
        public int Save(WorkOrder workorder)
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.Save(workorder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WorkOrder> GetAll(string whereclause = "")
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkOrder GetById(int id)
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(string whereclause = "")
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.GetCount(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Delete(int id)
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
