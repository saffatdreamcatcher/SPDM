using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmSaleList : Form
    {
        public frmSaleList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmSale myform = new frmSale();
            myform.ShowDialog();
            myform.StartPosition = FormStartPosition.CenterParent;
            LoadSale();

        }

        private void LoadSale()
        {
            SaleBLL saleBLL = new SaleBLL();
            List<Sale> sales = saleBLL.GetAll();
            gridControl1.DataSource = sales;
            gridControl1.ForceInitialize();
        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {
            LoadSale();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            StringBuilder sB = new StringBuilder();


            if (!string.IsNullOrEmpty(txtChallanNo.Text))
            {
                sB.Append(" ChallanNo LIKE '%");
                sB.Append(txtChallanNo.Text);
                sB.Append("%'");
            }

            if (!string.IsNullOrEmpty(txtDeliveryAddress.Text))
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }
                sB.Append(" DeliveryAddress LIKE '%");
                sB.Append(txtDeliveryAddress.Text);
                sB.Append("%'");
            }


            string saleSearch = sB.ToString();

            SaleBLL saleBLL = new SaleBLL();
            List<Sale> sales = saleBLL.GetAll(saleSearch);
            gridControl1.DataSource = sales;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemHyperLinkEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int saleId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                SaleBLL saleBLL = new SaleBLL();
                saleBLL.Delete(saleId);
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView gridViewWelds = sender as GridView;
            GridView gridViewTests = gridViewWelds.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridViewTests.BeginUpdate();
            gridViewTests.Columns["Id"].Visible = false;
            gridViewTests.Columns["IsNew"].Visible = false;
            gridViewTests.Columns["UpdateTime"].Visible = false;
            gridViewTests.Columns["SaleId"].Visible = false;
            gridViewTests.Columns["ItemId"].Visible = false;
            gridViewTests.Columns["Discount"].Visible = false;
            gridViewTests.Columns["CreateTime"].Visible = false;
            gridViewTests.Columns["ItemName"].VisibleIndex = 0;

            gridViewTests.EndUpdate();
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            List<SaleDetail> saleDetails = new List<SaleDetail>();

            Sale data = (Sale)gridView1.GetRow(e.RowHandle);
            string where = "SaleId = " + data.Id;
            SaleDetailBLL saleDetailBLL = new SaleDetailBLL();
            saleDetails = saleDetailBLL.GetAll(where);
            e.ChildList = saleDetails;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int saleId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));


        }
    } 
}