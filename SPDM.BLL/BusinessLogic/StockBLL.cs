using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPDM.DLL.Enums;
using System.Configuration;
using SPDM.DLL;

namespace SPDM.BLL.BusinessLogic
{
    public class StockBLL
    {
       
        public void Save(int productionId, List<Stock> stocks)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            DbManager dbManager = new DbManager(myConnectionString);
            try
            {
                dbManager.OpenTransaction();
               
                StockDLL stockDLL = new StockDLL(dbManager.Transaction);
                StockHistoryDLL stockHistoryDLL = new StockHistoryDLL(dbManager.Transaction);
                ProductionDLL productionDLL = new ProductionDLL(dbManager.Transaction);
                WorkOrderDLL workOrderDLL = new WorkOrderDLL(dbManager.Transaction);
                ProductionDetailDLL productionDetailDLL = new ProductionDetailDLL(dbManager.Transaction);
                Production production = productionDLL.GetById(productionId);

                if (production.Id == 0)
                {
                    throw new Exception("Production doesnt exist!");       
                }
                WorkOrderDetailDLL workOrderDetailDLL = new WorkOrderDetailDLL(dbManager.Transaction);
               
                foreach (Stock stock in stocks)
                {
                    //Save To Stock
                    stockDLL.Save(stock);

                    //Save To StockHistory
                    StockHistory stockHistory = new StockHistory();
                    stockHistory.UserId = stock.UserId;
                    stockHistory.CategoryId = stock.CategoryId;
                    stockHistory.ItemId = stock.ItemId;
                    stockHistory.Fiscalyear = stock.Fiscalyear;
                    stockHistory.Drum = stock.Drum;
                    stockHistory.CoilNo = stock.CoilNo;
                    stockHistory.Unit = stock.Unit;
                    stockHistory.QuantityInKM = stock.OpeningQuantityInKM;
                    stockHistory.QuantityInFKM = stock.OpeningQuantityInFKM;
                    stockHistory.Note = stock.Note;
                    stockHistoryDLL.Save(stockHistory);

                    //Update drum in workOrderDeatail
                    string where1 = $"{"WorkOrderId= " + production.WorkOrderId} {" and  ItemId= " + stock.ItemId}";

                    List<WorkOrderDetail> workOrderDetails = workOrderDetailDLL.GetAll(where1);
                    WorkOrderDetail workOrderDetail = workOrderDetails[0];
                    
                    workOrderDetail.Drum = Convert.ToDouble(stock.Drum);
                    workOrderDetailDLL.Save(workOrderDetail);
                }
               

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

                dbManager.CommitTransaction();

            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                throw ex;
            }
            finally
            {
                dbManager.Dispose();
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

        public bool IsExist(string whereClause = "")
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.IsExist(whereClause);
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
