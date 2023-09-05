using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;

namespace SPDM.UI
{
    public partial class frmProductionList : Form
    {
        public frmProductionList()
        {
            InitializeComponent();
        }

        private void frmProductionList_Load(object sender, EventArgs e)
        {
            //LoadProduction();
            LoadParty();
            SearchProduction();
        }

        //private void LoadProduction()
        //{
        //    ProductionBLL productionBLL = new ProductionBLL();
        //    List<Production> productions = productionBLL.GetAll();
        //    gridControl1.DataSource = productions;
        //    gridControl1.ForceInitialize();
        //}


        private void LoadParty()
        {
            
                Party party = new Party();
                party.Id = 0;
                party.Name = "Please Select-";
                PartyBLL partyBLL = new PartyBLL();
                List<Party> parties = partyBLL.GetAll();
                cmoParty.DataSource = parties;
                parties.Insert(0, party);
                cmoParty.ValueMember = "Id";
                cmoParty.DisplayMember = "Name";


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
            gridViewTests.Columns["CreateTime"].Visible = false;
            gridViewTests.Columns["TotalExvat"].Visible = false;
            gridViewTests.Columns["ProductionId"].Visible = false;
            gridViewTests.Columns["WorkOrderDetailId"].Visible = false;
            gridViewTests.EndUpdate();
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            List<ProductionDetail> productionDetails = new List<ProductionDetail>();

            Production data = (Production)gridView1.GetRow(e.RowHandle);
            string where = "ProductionId = " + data.Id;
            ProductionDetailBLL productionDetailBLL = new ProductionDetailBLL();
            productionDetails = productionDetailBLL.GetAll(where);
            e.ChildList = productionDetails;

        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void btnAddToStock_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            int productionId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            frmStock frmstock = new frmStock();
            frmstock.ShowDialog(productionId);
            SearchProduction();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduction();
        }

        private void SearchProduction()
        {
            StringBuilder sB = new StringBuilder();


            if (!string.IsNullOrEmpty(txtProduction.Text))
            {

                sB.Append(" ProductionNo LIKE '%");
                sB.Append(txtProduction.Text);
                sB.Append("%'");
            }

            if (Convert.ToInt32(cmoParty.SelectedValue) > 0)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");
                }

                sB.Append(" PartyId =");
                sB.Append(cmoParty.SelectedValue);
            }

            if (dTPFromDate.EditValue != null)
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                sB.Append(" Format(Production.CreateTime, 'yyyy-MM-dd') >= '");
                sB.Append(dTPFromDate.DateTime.ToString("yyyy-MM-dd"));
                sB.Append("'");
            }

            if (dTPToDate.EditValue != null)
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append("AND");

                }

                sB.Append(" Format(Production.CreateTime, 'yyyy-MM-dd') <= '");
                sB.Append(dTPToDate.DateTime.ToString("yyyy-MM-dd"));
                sB.Append("'");

            }

            string ss = sB.ToString();

            ProductionBLL productionBLL = new ProductionBLL();
            List<Production> productions = productionBLL.GetAll(ss);
            gridControl1.DataSource = productions;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                ProductionBLL productionBLL = new ProductionBLL();
                productionBLL.Delete(Id);
                SearchProduction();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearSearch();
            SearchProduction();
        }

        private void ClearSearch()
        {
            txtProduction.Text = string.Empty;
            cmoParty.SelectedIndex = 0;
            gridControl1.Refresh();
        }
    }
}
