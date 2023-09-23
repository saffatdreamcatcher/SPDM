using DevExpress.XtraReports.UI;
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
    public partial class frmReportStock : Form
    {
       
        public frmReportStock()
        {
            InitializeComponent();
        }

        private void frmReportStock_Load(object sender, EventArgs e)
        {
            //LoadStockReport();
            LoadCategory();
            LoadItem();
        }

        private void LoadStockReport()
        {
            RptStock rptStock = new RptStock();
            ReportBLL reportBLL = new ReportBLL();


            string where = "";

            DataTable dt = reportBLL.GetStock(where);
            dt.TableName = "Stock_1";
            rptStock.DataSource = dt;
            rptStock.DataMember = "Stock_1";


            rptStock.CreateDocument();
            documentViewer1.DocumentSource = rptStock;

            //rptStock.ShowPreview();
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

        private void cmoCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmoCategory.SelectedIndex > 0)
            {
                LoadItem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int? cName = null;
            int? iName = null;

            if(Convert.ToInt32(cmoCategory.SelectedValue)> 0) 
            { 
               cName = Convert.ToInt32(cmoCategory.SelectedValue);
            }

            if (Convert.ToInt32(cmoItem.SelectedValue) > 0)
            {
                iName = Convert.ToInt32(cmoItem.SelectedValue);
            }


            RptStock rptStock = new RptStock();
            ReportBLL reportBLL = new ReportBLL();

            DataTable dt = reportBLL.SearchStock(cName, iName, txtDrum.Text, txtCoil.Text);
            dt.TableName = "Stock_1";
            rptStock.DataSource = dt;
            rptStock.DataMember = "Stock_1";

            rptStock.Parameters["CategoryName"].Value = cmoCategory.SelectedValue;
            rptStock.Parameters["ItemName"].Value = cmoItem.SelectedValue;
            rptStock.Parameters["Drum"].Value = txtDrum.Text;
            rptStock.Parameters["Coil"].Value = txtCoil.Text;

            rptStock.CreateDocument();
            documentViewer1.DocumentSource = rptStock;
            documentViewer1.InitiateDocumentCreation();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
