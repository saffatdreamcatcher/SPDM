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
    public partial class frmStockList : Form
    {
        public frmStockList()
        {
            InitializeComponent();
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            LoadStock();
            LoadCategory();

            //this.dTPFromDate.Format = DateTimePickerFormat.Custom;
            //dTPFromDate.CustomFormat = " ";
            

        }

        private void LoadStock()
        {
            StockBLL stockBLL = new StockBLL();
            List<Stock> stocks = stockBLL.GetAll();
            gvStock.DataSource = stocks;
        }

        private void LoadCategory()
        {
            Category category = new Category();
            category.Id = 0;
            category.Name = "Please Select-";
            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> categories = categoryBLL.GetAll();
            cmoCategory.DataSource = categories;
            categories.Insert(0, category);
            cmoCategory.ValueMember = "Id";
            cmoCategory.DisplayMember = "Name";

        }

        private void LoadItem()
        {
            
            int comboCategory = Convert.ToInt32(cmoCategory.SelectedValue);
            if (comboCategory > 0)
            {
                Item item = new Item();
                item.Id = 0;
                item.Name = "Please Select-";
                ItemBLL itemBLL = new ItemBLL();

                string where = "CategoryId= " + comboCategory;
                List<Item> items = itemBLL.GetAll(where);
                cmoItem.DataSource = items;
                items.Insert(0, item);
                cmoItem.ValueMember = "Id";
                cmoItem.DisplayMember = "Name";
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = "";

            StringBuilder sB = new StringBuilder();
            

            //if (Convert.ToInt32(cmoCategory.SelectedValue) > 0)

            //{
            //    search += " Stock.CategoryId =" + cmoCategory.SelectedValue;
            //    //sB.Append(" Stock.CategoryId =");
            //    //sB.Append(cmoCategory.SelectedValue);

            //}

            //if (Convert.ToInt32(cmoItem.SelectedValue) > 0)
            //{
            //    if (search != string.Empty)
            //    {
            //        search += " AND";
            //    }
            //    search += " ItemId =" + cmoItem.SelectedValue;

            //}

            //if (txtDrum.Text != "")
            //{

            //        if (search != string.Empty)
            //        {
            //            search += " AND";

            //        }
            //        search += " Drum LIKE '%" + txtDrum.Text + "%'";

            //}

            //if (txtCoil.Text != "")
            //{
            //    if (search != string.Empty)
            //    { 
            //        search += " AND"; 

            //    }

            //    search += " CoilNo LIKE '%" + txtCoil.Text + "%'";

            //}

            //if (dTPFromDate.Value.ToString() != "")
            //{

            //    if (search != string.Empty)
            //    {
            //        search += " AND";

            //    }
            //    search += " Format(Stock.CreateTime, 'yyyy-MM-dd') >= '" + dTPFromDate.Value.ToString("yyyy-MM-dd") + "'";
            //}

            //if (dTPToDate.Value.ToString() != "")
            //{

            //    if (search != string.Empty)
            //    {
            //        search += " AND";

            //    }
            //    search += " Format(Stock.CreateTime, 'yyyy-MM-dd') <= '" + dTPToDate.Value.ToString("yyyy-MM-dd") + "'";


            //}


            //StockBLL stockBLL = new StockBLL();
            //List<Stock> stocks = stockBLL.GetAll(search);
            //gvStock.DataSource = stocks;

            if (Convert.ToInt32(cmoCategory.SelectedValue) > 0)

            {

                sB.Append(" Stock.CategoryId =");
                sB.Append(cmoCategory.SelectedValue);

            }

            if (Convert.ToInt32(cmoItem.SelectedValue) > 0)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }
               
                sB.Append(" ItemId =");
                sB.Append(cmoItem.SelectedValue);
            }

            if (txtDrum.Text != "")
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }
                
                sB.Append(" Drum LIKE '%");
                sB.Append(txtDrum.Text);
                sB.Append("%'");

            }

            if (txtCoil.Text != "")
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                
                sB.Append(" CoilNo LIKE '%");
                sB.Append(txtCoil.Text);
                sB.Append("%'");
            }

            if (dTPFromDate.Value.ToString() != "")
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }
               
                sB.Append(" Format(Stock.CreateTime, 'yyyy-MM-dd') <= '");
                sB.Append(dTPFromDate.Value.ToString("yyyy-MM-dd"));
                sB.Append("'");
            }

            if (dTPToDate.Value.ToString() != "")
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append("AND");

                }
                
                sB.Append(" Format(Stock.CreateTime, 'yyyy-MM-dd') >= '");
                sB.Append(dTPToDate.Value.ToString("yyyy - MM - dd"));
                sB.Append("'");

            }

            string ss = sB.ToString();

            StockBLL stockBLL = new StockBLL();
            List<Stock> stocks = stockBLL.GetAll(ss);
            gvStock.DataSource = stocks;

        }

        private void cmoCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmoCategory.SelectedIndex > 0)
            {
                LoadItem();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
