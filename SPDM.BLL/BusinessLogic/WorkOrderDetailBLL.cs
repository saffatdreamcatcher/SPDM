using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class WorkOrderDetailBLL
    {
        public int Save(WorkOrderDetail workorderdetail)
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.Save(workorderdetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WorkOrderDetail> GetAll(string whereclause = "")
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkOrderDetail GetById(int id)
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetById(id);
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
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetCount(whereclause);
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
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
