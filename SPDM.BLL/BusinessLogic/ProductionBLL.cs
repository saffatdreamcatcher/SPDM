using SPDM.DLL.Entities;
using SPDM.DLL.Enums;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;

namespace SPDM.BLL.BusinessLogic
{
    public class ProductionBLL
    {
        public int Save(Production production)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.Save(production);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Production> GetAll(string whereclause = "")
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Production GetById(int id)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetById(id);
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
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetCount(whereclause);
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
                ProductionDLL productionDLL = new ProductionDLL();
                ProductionDetailDLL productionDetailDLL = new ProductionDetailDLL();
                WorkOrderDLL workOrderDLL = new WorkOrderDLL();
                Production production = productionDLL.GetById(id);
                string where = "ProductionId=" + id;
                List<ProductionDetail> productionDetails= productionDetailDLL.GetAll(where);
                WorkOrder workOrder = workOrderDLL.GetById(production.WorkOrderId);

                foreach (ProductionDetail productionDetail in productionDetails)
                {
                    productionDetailDLL.Delete(productionDetail.Id);
                }

                workOrder.Status = WorkOrderStatus.Placed;
                workOrderDLL.Save(workOrder);
                return productionDLL.Delete(id); 
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddToStock(int productionId, int userId)
        {
            ProductionDLL productionDLL = new ProductionDLL();
            ProductionDetailDLL productionDetailDLL = new ProductionDetailDLL();
            StockDLL stockDLL = new StockDLL();
            StockHistoryDLL stockHistoryDLL = new StockHistoryDLL();

            Production production = GetById(productionId);
            string where = "ProductionId=" + productionId;
            List<ProductionDetail> productionDetails = productionDetailDLL.GetAll(where);
            Stock stock = new Stock();
            stock.UserId = userId;
            stock.Fiscalyear = production.Fiscalyear;
            
        }

    }
}
