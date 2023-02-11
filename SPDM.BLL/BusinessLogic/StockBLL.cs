﻿using SPDM.DLL.Entities;
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
        public int Save(Stock stock)
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.Save(stock);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Stock> GetAll()
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stock GetById()
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(Stock stock)
        {
            try
            {
                StockDLL stockDLL = new StockDLL();
                return stockDLL.GetCount();
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
