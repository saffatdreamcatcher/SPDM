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
            category.Id = -1;
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
            Item item = new Item();
            item.Id = -1;
            item.Name = "Please Select-";
            ItemBLL itemBLL = new ItemBLL();
            int comboCategory = Convert.ToInt32(cmoCategory.SelectedValue);
            if (comboCategory > -1)
            {
                string where = "CategoryId= " + comboCategory;
                List<Item> items = itemBLL.GetAll(where);
                cmoItem.DataSource = items;
                
                cmoItem.ValueMember = "Id";
                cmoItem.DisplayMember = "Name";
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = "";
            if (txtDrum.Text != "")
            {
                
                search += "Drum LIKE '%" + txtDrum.Text + "%'";
                
            }

            if (txtCoil.Text != "")
            {
                if (search != string.Empty)
                { 
                    search += " AND "; 
                  
                }

                search += "CoilNo LIKE '%" + txtCoil.Text + "%'";

            }

            StockBLL stockBLL = new StockBLL();
            List<Stock> stocks = stockBLL.GetAll(search);
            gvStock.DataSource = stocks;

        }

        private void cmoCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmoCategory.SelectedIndex > 0)
            {
                LoadItem();
            }
        }
    }
}
