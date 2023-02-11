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

        public List<WorkOrderDetail> GetAll()
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public WorkOrderDetail GetById()
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(WorkOrderDetail workorderdetail)
        {
            try
            {
                WorkOrderDetailDLL workorderdetailDLL = new WorkOrderDetailDLL();
                return workorderdetailDLL.GetCount();
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
