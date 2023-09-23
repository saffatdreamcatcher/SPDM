using DevExpress.XtraReports;
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

namespace SPDM.UI.Reports
{
    public partial class frmReportItem : Form
    {
        public frmReportItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemBLL itemBLL = new ItemBLL();
            RptItem rptItem = new RptItem();

            List<Item> items = new List<Item>();
            
            string where = "CategoryId = " + cmoCategory.SelectedValue;

            if (cmoCategory.Text == "All")
            {
                items = itemBLL.GetAll();   
            }
            else
            {
                items = itemBLL.GetAll(where);
            }

            rptItem.DataSource = items;
            rptItem.Parameters["CategoryName"].Value = cmoCategory.Text;
            rptItem.CreateDocument();
            documentViewer1.DocumentSource = rptItem;

        }

        private void frmReportItem_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            Category category = new Category();
            category.Id = -1;
            category.Name = "All";

            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> categories = categoryBLL.GetAll();
            categories.Insert(0, category);
            cmoCategory.DataSource = categories;
            cmoCategory.ValueMember = "Id";
            cmoCategory.DisplayMember = "Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
