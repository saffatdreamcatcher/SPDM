using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class SaleBLL
    {
        public int Save(Sale sale, List<SaleDetail> saleDetails)
        {
            try
            {
                WorkOrderDetailDLL workOrderDetailDLL = new WorkOrderDetailDLL();
                string where = "WorkOrderId = " + sale.WorkOrderId;
                List<WorkOrderDetail> workOrderDetails = workOrderDetailDLL.GetAll(where);
                StockDLL stockDLL = new StockDLL();
                StockHistoryDLL stockHistoryDLL = new StockHistoryDLL();
                SaleDLL saleDLL = new SaleDLL();
                SaleDetailDLL saleDetailDLL = new SaleDetailDLL();
                WorkOrderDLL workOrderDLL = new WorkOrderDLL();

                foreach (SaleDetail sd in saleDetails)
                {
                    foreach (WorkOrderDetail wod in workOrderDetails)
                    {
                        if (sd.ItemId == wod.ItemId)
                        {
                            string where1 = "Drum= '" + wod.Drum + "'";
                            where1 = where1 + " and ItemId= " + sd.ItemId;
                            List<Stock> stocks = stockDLL.GetAll(where1);

                            if (stocks.Count > 0)
                            {
                                Stock stock = stocks[0];
                                stock.CurrentQuantityInKM = stock.CurrentQuantityInKM - (int)wod.Length;
                                stockDLL.Save(stock);

                                StockHistory stockHistory = new StockHistory();
                                stockHistory.UserId = stock.UserId;
                                stockHistory.CategoryId = stock.CategoryId;
                                stockHistory.ItemId = stock.ItemId;
                                stockHistory.CategoryId = 2;
                                stockHistory.Fiscalyear = stock.Fiscalyear;
                                stockHistory.Drum = stock.Drum;
                                stockHistory.CoilNo = stock.CoilNo;
                                stockHistory.Unit = stock.Unit;
                                stockHistory.QuantityInKM = -(int)wod.Length;
                                //stockHistory.QuantityInFKM = stock.OpeningQuantityInFKM;
                                stockHistory.Note = stock.Note;
                                stockHistoryDLL.Save(stockHistory);
                            }

                            break;

                        }
                    }
                }


                WorkOrder workOrder1 = workOrderDLL.GetById(sale.WorkOrderId);
                workOrder1.Status = WorkOrderStatus.Sold;
                workOrderDLL.Save(workOrder1);


                saleDLL.Save(sale);


                foreach (SaleDetail saleDetail in saleDetails)
                {
                    saleDetail.SaleId = sale.Id;
                    saleDetailDLL.Save(saleDetail);
                }
                return sale.Id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sale> GetAll(string whereclause = "")
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sale GetById(int id)
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetById(id);
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
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetCount(whereclause);
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
                SaleDLL saleDLL = new SaleDLL();
                Sale sale = saleDLL.GetById(id);
                SaleDetailDLL saleDetailDLL = new SaleDetailDLL();
                string whereSale = "SaleId = " + id;
                List<SaleDetail> saleDetails = saleDetailDLL.GetAll(whereSale);

                WorkOrderDetailDLL workOrderDetailDLL = new WorkOrderDetailDLL();
                string whereWorkOrder = "WorkOrderId = " + sale.WorkOrderId;
                List<WorkOrderDetail> workOrderDetails = workOrderDetailDLL.GetAll(whereWorkOrder);
                StockDLL stockDLL = new StockDLL();
                StockHistoryDLL stockHistoryDLL = new StockHistoryDLL();
                WorkOrderDLL workOrderDLL = new WorkOrderDLL();

                foreach (SaleDetail sd in saleDetails)
                {
                    foreach (WorkOrderDetail wod in workOrderDetails)
                    {
                        if (sd.ItemId == wod.ItemId)
                        {
                            string whereStock = "Drum= '" + wod.Drum + "'";
                            whereStock = whereStock + " and ItemId= " + sd.ItemId;
                            List<Stock> stocks = stockDLL.GetAll(whereStock);

                            if (stocks.Count > 0)
                            {
                                Stock stock = stocks[0];
                                stock.CurrentQuantityInKM = stock.CurrentQuantityInKM + (int)wod.Length;
                                stockDLL.Save(stock);

                                StockHistory stockHistory = new StockHistory();
                                stockHistory.UserId = stock.UserId;
                                stockHistory.CategoryId = stock.CategoryId;
                                stockHistory.ItemId = stock.ItemId;
                                stockHistory.CategoryId = 2;
                                stockHistory.Fiscalyear = stock.Fiscalyear;
                                stockHistory.Drum = stock.Drum;
                                stockHistory.CoilNo = stock.CoilNo;
                                stockHistory.Unit = stock.Unit;
                                stockHistory.QuantityInKM = (int)wod.Length;
                                stockHistory.Note = stock.Note;
                                stockHistoryDLL.Save(stockHistory);
                            }

                            break;

                        }
                    }
                }


                WorkOrder workOrder1 = workOrderDLL.GetById(sale.WorkOrderId);
                workOrder1.Status = WorkOrderStatus.InProduction;
                workOrderDLL.Save(workOrder1);


                foreach (SaleDetail saleDetail in saleDetails)
                {
                    saleDetailDLL.Delete(saleDetail.Id); 
                }
                saleDLL.Delete(id);
                return 0;
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
