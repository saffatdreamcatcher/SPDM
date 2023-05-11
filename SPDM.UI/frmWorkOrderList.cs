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
    public partial class frmWorkOrderList : Form
    {

        public frmWorkOrderList()
        {
            InitializeComponent();
            
        }

        public void LoadComboBox()
        {
            //cmoStatus.Items.AddRange(Enum.GetNames(typeof(WorkOrderStatus)));
            //cmoStatus.SelectedIndex = 0;

            string[] enumElements = Enum.GetNames(typeof(WorkOrderStatus));
            foreach (var item in enumElements)
            {
                cmoStatus.Items.Add(item);
            }
            cmoStatus.SelectedIndex = 0;
           


        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmWorkOrder myform = new frmWorkOrder();
            myform.ShowDialog();
            LoadWorkOrder();
        }

        private void frmWorkOrderList_Load(object sender, EventArgs e)
        {
            LoadWorkOrder();
            LoadParty();
            LoadComboBox();
        }

        private void LoadWorkOrder()
        {
            WorkOrderBLL workOrderBLL = new WorkOrderBLL();
            List<WorkOrder> workOrders = workOrderBLL.GetAll();
            gridControl1.DataSource = workOrders;
            gridControl1.ForceInitialize();

        }

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
        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            List<WorkOrderDetail> workOrderDetails = new List<WorkOrderDetail>();

            WorkOrder data = (WorkOrder)gridView1.GetRow(e.RowHandle);
            string where = "WorkOrderId = " + data.Id;
            WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
            workOrderDetails = workOrderDetailBLL.GetAll(where);
            e.ChildList = workOrderDetails;
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView gridViewWelds = sender as GridView;
            GridView gridViewTests = gridViewWelds.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridViewTests.BeginUpdate();
            gridViewTests.Columns["Id"].Visible = false;
            gridViewTests.Columns["IsNew"].Visible = false;
            gridViewTests.Columns["UpdateTime"].Visible = false;
            gridViewTests.Columns["TotalExvat"].Visible = false;
            gridViewTests.EndUpdate();
        }

        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void repositoryItemHyperLinkEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int workOrderId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            frmWorkOrder frmWorkOrder = new frmWorkOrder();
            frmWorkOrder.ShowDialog(workOrderId);
        }

        private void repositoryItemHyperLinkEdit2_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int workOrderId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                string where = "workorderId= " + workOrderId;
                WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
                List<WorkOrderDetail> workOrderDetails = workOrderDetailBLL.GetAll(where);

                foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
                {
                    workOrderDetailBLL.Delete(workOrderDetail.Id);
                }

                //for (int i = 0; i < workOrderDetails.Count; i++)
                //{
                //    workOrderDetailBLL.Delete(workOrderDetails[i].Id);
                //}
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                workOrderBLL.Delete(workOrderId);
                LoadWorkOrder();
            }
            
        }

        private void btnSendToProduction_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int workOrderId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            WorkOrderStatus workOrderStatus = (WorkOrderStatus)Enum.Parse(typeof(WorkOrderStatus), gridView1.GetFocusedRowCellValue("Status").ToString());
            if (workOrderStatus == WorkOrderStatus.Placed)
            {
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                workOrderBLL.SendToProduction(workOrderId, Global.Userid);
            }
            else
            {
                MessageBox.Show("WorkOrder with Placed is only allowed to transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            StringBuilder sB = new StringBuilder();
            var number = (int)(WorkOrderStatus)Enum.Parse(typeof(WorkOrderStatus), cmoStatus.Text.ToString());

            //string m = Enum.GetName(typeof(WorkOrderStatus), number);

            if (txtWorkOrderNo.Text != string.Empty)
            {

                sB.Append(" WorkOrderNo LIKE '%");
                sB.Append(txtWorkOrderNo.Text);
                sB.Append("%'");
            }

            if (Convert.ToInt32(cmoParty.SelectedValue) > 0)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                sB.Append(" PartyId =");
                sB.Append(cmoParty.SelectedIndex);
            }

            if (dTPWorkOrderDate.Value.ToString() != "")
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                sB.Append(" Format(WorkOrder.WorkOrderDate, 'yyyy-MM-dd') >= '");
                sB.Append(dTPWorkOrderDate.Value.ToString("yyyy-MM-dd"));
                sB.Append("'");
            }

            if (dTPDeliveryDate.Value.ToString() != "")
            {

                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                sB.Append(" Format(WorkOrder.DeliveryDate, 'yyyy-MM-dd') <= '");
                sB.Append(dTPDeliveryDate.Value.ToString("yyyy-MM-dd"));
                sB.Append("'");
            }



            if (Convert.ToInt32(cmoStatus.SelectedValue) >= 0)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }

                sB.Append(" Status =");
                sB.Append(cmoStatus.SelectedValue);
               
            }

            string ss = sB.ToString();

            WorkOrderBLL workOrderBLL = new WorkOrderBLL();
            List<WorkOrder> workOrders = workOrderBLL.GetAll(ss);
            gridControl1.DataSource = workOrders;

        }
    }
}
