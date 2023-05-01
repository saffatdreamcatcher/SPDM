using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class StockBLL
    {
        public void Save(int productionId, List<Stock> stocks)
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                StockHistoryDLL stockHistoryDLL = new StockHistoryDLL();
                ProductionDLL productionDLL = new ProductionDLL();
                WorkOrderDLL workOrderDLL = new WorkOrderDLL();
                ProductionDetailDLL productionDetailDLL = new ProductionDetailDLL();
                foreach (Stock stock in stocks)
                {
                    //Save To Stock
                    stockDLL.Save(stock);

                    //Save To StockHistory
                    StockHistory stockHistory = new StockHistory();
                    stockHistory.UserId = stock.UserId;
                    stockHistory.CategoryId = stock.CategoryId;
                    stockHistory.ItemId = stock.ItemId;
                    stockHistory.CategoryId = 2;
                    stockHistory.Fiscalyear = stock.Fiscalyear;
                    stockHistory.Drum = stock.Drum;
                    stockHistory.CoilNo = stock.CoilNo;
                    stockHistory.Unit = stock.Unit;
                    stockHistory.QuantityInKM = stock.OpeningQuantityInKM;
                    stockHistory.QuantityInFKM = stock.OpeningQuantityInFKM;
                    stockHistory.Note = stock.Note;
                    stockHistoryDLL.Save(stockHistory);
                    
                }
                

                Production production = productionDLL.GetById(productionId);

                //Update WorkOrder
                WorkOrder workOrder = workOrderDLL.GetById(production.WorkOrderId);
                workOrder.Status = WorkOrderStatus.InStock;
                workOrderDLL.Save(workOrder);

                // Delete ProductionDetail
                string where = "productionId= " + productionId;
                List<ProductionDetail> productionDetails = productionDetailDLL.GetAll(where);
                foreach (ProductionDetail productionDetail in productionDetails)
                {
                    productionDetailDLL.Delete(productionDetail.Id);
                }

                // Delete Production
                productionDLL.Delete(productionId);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Stock> GetAll(string whereclause = "")
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stock GetById(int id)
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetById(id);
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
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetCount(whereclause);
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
                StockDLL stockDLL = new StockDLL();
                return stockDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
