﻿using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmStockHistory : Form
    {
        public frmStockHistory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStockHistory();
        }

        private void SaveStockHistory()
        {
            //StockHistory stockhistory = new StockHistory();
            ////stockhistory.Id = 4;
            //stockhistory.UserId = Global.Userid;
            //stockhistory.CategoryId = 2;
            //stockhistory.ItemId = 5;
            //stockhistory.Fiscalyear = "June-July 2025";
            //stockhistory.Drum = "A 11";
            //stockhistory.CoilNo = "12B";
            //stockhistory.Unit = 15;
            //stockhistory.QuantityInKM = 110;
            //stockhistory.QuantityInFKM = 11;
            //stockhistory.Note = "";

            //StockHistoryBLL stockhistoryBLL = new StockHistoryBLL();
            //stockhistoryBLL.Save(stockhistory);


            //string where = "UserId = 3 and CategoryId = 2 and ItemId = 5";
            //StockHistoryBLL stockHistoryBLL = new StockHistoryBLL();
            //List<StockHistory> stockhistories = stockHistoryBLL.GetAll(where);

            string where = "UserId = 3 and CategoryId = 2 and ItemId = 5";
            StockHistoryBLL stockHistoryBLL = new StockHistoryBLL();
            int stockhistory = stockHistoryBLL.GetCount(where);
        }
    }
}