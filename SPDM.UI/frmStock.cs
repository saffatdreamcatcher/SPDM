using SPDM.BLL.BusinessLogic;
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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            SaveStock();
        }

        private void SaveStock()
        {
            Stock stock = new Stock();
            stock.Id = 4;
            stock.UserId = Global.Userid;
            stock.CategoryId = 2;
            stock.ItemId = 5;
            stock.Fiscalyear = "June-July 2025";
            stock.Drum = "A 11";
            stock.CoilNo = "12B";
            //stock.Din = "9";
            stock.Unit = 15;
            stock.OpeningQuantityInKM = 110;
            stock.OpeningQuantityInFKM = 11;
            stock.CurrentQuantityInKM = 150;
            stock.CurrentQuantityInFKM = 16;
            stock.Note = "";

            StockBLL stockBLL = new StockBLL();
            stockBLL.Save(stock);

            //StockBLL stockBLL = new StockBLL();
            //List<Stock> stocks = stockBLL.GetAll();

            //StockBLL stockBLL = new StockBLL();
            //Stock stock = stockBLL.GetById(2);

            //StockBLL stockBLL = new StockBLL();
            //int stock = stockBLL.GetCount();
        }
    }
}
