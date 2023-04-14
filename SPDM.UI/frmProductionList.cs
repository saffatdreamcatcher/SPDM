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
            LoadProduction();
        }

        private void LoadProduction()
        {
            ProductionBLL productionBLL = new ProductionBLL();
            List<Production> productions = productionBLL.GetAll();
            gridControl1.DataSource = productions;
            gridControl1.ForceInitialize();
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
    }
}
