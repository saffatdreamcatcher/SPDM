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

            //string where = "UserId = 3 and CategoryId = 2 and ItemId = 5";
            int UserId = 3;
            int CategoryId = 2;
            int ItemId = 5;
            //string where = "UserId= " + UserId + " and  CategoryId= " + CategoryId + " and  ItemId=" + ItemId;

            string where = $"{"UserId= " + UserId} {" and  CategoryId= " + CategoryId} {" and  ItemId=" + ItemId}";

            StockHistoryBLL stockHistoryBLL = new StockHistoryBLL();
            int stockhistory = stockHistoryBLL.GetCount(where);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string search = "";

            //if (txtUser.Text != "")
            //{
            //    if (search != string.Empty)

            //       search += "UserId =" + txtUser.Text;

            //}

            //if (txtCategory.Text != "")
            //{
            //    if (search != string.Empty)
            //        //search += " AND ";
            //        search += "CategoryId =" + txtCategory.Text;
            //}

            //if (txtItem.Text != "")
            //{
            //    //search += " AND ";
            //    search += "ItemId =" + txtItem.Text;
            //}

            //using interpolation 

            //string search = "";

            //if (txtUser.Text != "")
            //{
            //    //if (search != string.Empty)

            //        search += $"{"UserId =" + txtUser.Text}";

            //}

            //if (txtCategory.Text != "")
            //{
            //    if (search != string.Empty)
            //        //search += " AND ";
            //        search += $"{"CategoryId =" + txtCategory.Text}";
            //}

            //if (txtItem.Text != "")
            //{
            //    search += " AND ";
            //    //search += $"{"ItemId =" + txtItem.Text}";
            //}


            //USING FORMAT

            string search = "";

            if (txtUser.Text != "")
            {
                //if (search != string.Empty)

                search += String.Format("UserId =" + txtUser.Text);

            }

            if (txtCategory.Text != "")
            {
                if (search != string.Empty)
                    //search += " AND ";
                    search += String.Format("CategoryId =" + txtCategory.Text);
            }

            if (txtItem.Text != "")
            {
                search += " AND ";
                search += String.Format("ItemId =" + txtItem.Text);
            }




            StockHistoryBLL stockHistoryBLL = new StockHistoryBLL();
            List<StockHistory> stockhistories = stockHistoryBLL.GetAll(search);
        }
    }
}