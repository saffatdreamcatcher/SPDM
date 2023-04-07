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
        public int Save(WorkOrder workorder, List<WorkOrderDetail> workOrderDetails)
        {
            try
            {
                bool isFound = false;
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                WorkOrderDetailDLL workorderDetailDLL = new WorkOrderDetailDLL();
                List<WorkOrderDetail> oldWorkOrderDetailList = new List<WorkOrderDetail>();
                if(workorder.IsNew)
                {
                    string where = "workorderId= " + workorder.Id;
                    WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
                    oldWorkOrderDetailList = workOrderDetailBLL.GetAll(where);
                }
                workorderDLL.Save(workorder);

                foreach (WorkOrderDetail oldWorkOrderDetail in oldWorkOrderDetailList)
                {
                    foreach(WorkOrderDetail workOrderDetail in workOrderDetails)
                    {
                        if(oldWorkOrderDetail.Id == workOrderDetail.Id)
                        {
                            isFound = true;
                            break;  
                        }
                    }
                    if(!isFound)
                    {
                        workorderDetailDLL.Delete(oldWorkOrderDetail.Id);
                    }
                }

                foreach (WorkOrderDetail detail in workOrderDetails)
                {
                    detail.WorkOrderId = workorder.Id;
                    workorderDetailDLL.Save(detail);
                }
                return workorder.Id;

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
