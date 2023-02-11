using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class StockHistoryBLL
    {
        public int Save(StockHistory stockhistory)
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.Save(stockhistory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StockHistory> GetAll()
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StockHistory GetById()
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(StockHistory stockhistory)
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetCount();
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
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
