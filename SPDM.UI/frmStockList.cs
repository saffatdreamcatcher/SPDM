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
            //LoadStock();
            LoadCategory();
            LoadItem();
            SearchStock();

        }

        //private void LoadStock()
        //{
        //    StockBLL stockBLL = new StockBLL();
        //    List<Stock> stocks = stockBLL.GetAll();
        //    gvStock.DataSource = stocks;
        //}

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
            List<Item> items = new List<Item>();
            
            int comboCategory = Convert.ToInt32(cmoCategory.SelectedValue);

            if (comboCategory > 0)
            {
                ItemBLL itemBLL = new ItemBLL();

                string where = "CategoryId= " + comboCategory;
                items = itemBLL.GetAll(where);
               
            }

            Item item = new Item();
            item.Id = 0;
            item.Name = "Please Select-";
            items.Insert(0, item);
            cmoItem.DataSource = items;
            cmoItem.ValueMember = "Id";
            cmoItem.DisplayMember = "Name";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStock();

        }

        private void SearchStock()
        {
            StringBuilder sB = new StringBuilder();

            if (Convert.ToInt32(cmoCategory.SelectedValue) > 0)

            {

                sB.Append(" Stock.CategoryId =");
                sB.Append(cmoCategory.SelectedValue);

            }

            if (Convert.ToInt32(cmoItem.SelectedValue) > 0)
            {
                if (!string.IsNullOrEmpty(sB.ToString()))
                {
                    sB.Append(" AND");

                }

                sB.Append(" ItemId =");
                sB.Append(cmoItem.SelectedValue);
            }

            if (!string.IsNullOrEmpty(txtDrum.Text))
            {

                if (!string.IsNullOrEmpty(sB.ToString()))
                {
                    sB.Append(" AND");

                }

                sB.Append(" Drum LIKE '%");
                sB.Append(txtDrum.Text);
                sB.Append("%'");

            }

            if (!string.IsNullOrEmpty(txtCoil.Text))
            {
                if (!string.IsNullOrEmpty(sB.ToString()))
                {
                    sB.Append(" AND");

                }


                sB.Append(" CoilNo LIKE '%");
                sB.Append(txtCoil.Text);
                sB.Append("%'");
            }

            //if (dTPFromDate.Value.ToString() != "")
            if (dTPFromDate.EditValue != null)
            {

                if (!string.IsNullOrEmpty(sB.ToString()))
                {
                    sB.Append(" AND");

                }

                sB.Append(" Format(Stock.CreateTime, 'yyyy-MM-dd') <= '");
                sB.Append(dTPFromDate.DateTime.ToString("yyyy-MM-dd"));
                sB.Append("'");
            }

            //if (dTPToDate.Value.ToString() != "")
            if (dTPToDate.EditValue != null)
            {

                if (!string.IsNullOrEmpty(sB.ToString()))
                {
                    sB.Append("AND");

                }

                sB.Append(" Format(Stock.CreateTime, 'yyyy-MM-dd') >= '");
                sB.Append(dTPToDate.DateTime.ToString("yyyy - MM - dd"));
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
