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

        public List<StockHistory> GetAll(string whereclause = "")
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public StockHistory GetById(int id)
        {
            try
            {
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetById(id);
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
                StockHistoryDLL stockhistoryDLL = new StockHistoryDLL();
                return stockhistoryDLL.GetCount(whereclause);
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
