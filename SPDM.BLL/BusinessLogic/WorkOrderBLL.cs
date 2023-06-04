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
        public int Save(WorkOrder workorder, List<WorkOrderDetail> newWorkOrderDetails)
        {
            try
            {
                bool isFound = false;
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                WorkOrderDetailDLL workorderDetailDLL = new WorkOrderDetailDLL();
                List<WorkOrderDetail> oldWorkOrderDetailList = new List<WorkOrderDetail>();
                if(!workorder.IsNew)
                {
                    string where = "workorderId= " + workorder.Id;
                    WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
                    oldWorkOrderDetailList = workOrderDetailBLL.GetAll(where);
                }
                workorderDLL.Save(workorder);

                // Remove oldWorkOrderDetails which are deleted from grid
                foreach (WorkOrderDetail oldWorkOrderDetail in oldWorkOrderDetailList)

                {
                    isFound = false;
                    foreach (WorkOrderDetail newWorkOrderDetail in newWorkOrderDetails)
                    {
                        if(oldWorkOrderDetail.Id == newWorkOrderDetail.Id)
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
                // new WorkOrderDetails and update old WorkOrderDetails
                foreach (WorkOrderDetail detail in newWorkOrderDetails)
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

        public bool IsExist(string whereClause = "")
        {
            try
            {
                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.IsExist(whereClause);
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
                string where = "workorderId= " + id;
                WorkOrderDetailDLL workOrderDetailDLL = new WorkOrderDetailDLL();
                List<WorkOrderDetail> workOrderDetails = workOrderDetailDLL.GetAll(where);

                foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
                {
                    workOrderDetailDLL.Delete(workOrderDetail.Id);
                }

                WorkOrderDLL workorderDLL = new WorkOrderDLL();
                return workorderDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SendToProduction(int workOrderId, int userId)
        {
            WorkOrderDLL workOrderDLL = new WorkOrderDLL();
            WorkOrderDetailDLL workOrderDetailDLL = new WorkOrderDetailDLL();
            ProductionDLL productionDLL = new ProductionDLL();
            ProductionDetailDLL productionDetailDLL = new ProductionDetailDLL();    

            WorkOrder workOrder = GetById(workOrderId);
            string where = "WorkOrderId=" + workOrderId;
            List<WorkOrderDetail> workOrderDetails = workOrderDetailDLL.GetAll(where);
            Production production = new Production();
            production.UserId = userId;
            production.ProductionNo = "P-" + workOrder.WorkOrderNo;
            production.Fiscalyear = workOrder.Fiscalyear;
            production.PartyId = workOrder.PartyId;
            production.WorkOrderId = workOrder.Id;
            production.WorkOrderDate = workOrder.WorkOrderDate; 
            production.TotalExvat = workOrder.TotalExvat;
            production.TotalIncvat = workOrder.TotalIncvat;
            production.Discount = workOrder.Discount;
            production.DiscountPercent = workOrder.DiscountPercent;
            production.VatPercent = workOrder.VatPercent;
            production.Note = workOrder.Note;

            productionDLL.Save(production);

            foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
            {
                ProductionDetail productionDetail = new ProductionDetail();
                productionDetail.ProductionId = production.Id;
                productionDetail.WorkOrderDetailId = workOrderDetail.Id;
                productionDetail.ItemId = workOrderDetail.ItemId;
                productionDetail.Unit = workOrderDetail.Unit;
                productionDetail.UnitPrice = workOrderDetail.UnitPrice;
                productionDetail.Length = workOrderDetail.Length;
                productionDetail.TotalExvat = workOrderDetail.TotalExvat;
                productionDetail.TotalIncvat = workOrderDetail.TotalIncvat;
                productionDetail.Discount = workOrderDetail.Discount;
                productionDetail.DiscountPercent = workOrderDetail.DiscountPercent;
                productionDetail.VatPercent = workOrderDetail.VatPercent;
                productionDetailDLL.Save(productionDetail);
            }

            workOrder.Status = WorkOrderStatus.InProduction;
            workOrderDLL.Save(workOrder);
        }
    }
}
