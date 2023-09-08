using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPDM.DLL.Enums;
using DevExpress.Utils.Extensions;
using DevExpress.DataProcessing.InMemoryDataProcessor;

namespace SPDM.UI
{
    public partial class frmWorkOrder : Form
    {

        private BindingList<WorkOrderDetail> workOrderDetails = new BindingList<WorkOrderDetail>();
        private int workorderdId;
        private int editIndex = -1;

        public frmWorkOrder()
        {
            InitializeComponent();
        }

        public void ShowDialog(int workOrderId)
        {
            workorderdId = workOrderId;
            this.ShowDialog();
            
        }

        public void GenerateWorkOrderNo()
        {
            string dt = DateTime.Now.ToString("MM/dd/yyyyHH:mm:ss");
            string dt2 = dt.Replace("/", "");
            string dt3 = dt2.Replace(":", "");
            string s = "W-" + Global.Userid + "-" + dt3;

            txtWorkOrderNo.Text = s;
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
           
            GenerateWorkOrderNo();
            
            LoadItem();
            LoadParty();
            txtStatus.Text = WorkOrderStatus.Placed.ToString();
            txtFiscalYear.Text = Global.FiscalYear;
            if (workorderdId > 0)
            {
                LoadOldWorkOrderWithDetails();
            }

            if (txtStatus.Text != WorkOrderStatus.Placed.ToString()) ;
            {
                lblSave.Visible = true;
                lblSave.Show();
            }

        }

        private void LoadOldWorkOrderWithDetails()
        {
            WorkOrderBLL workOrderBLL = new WorkOrderBLL();
            WorkOrder workOrder = workOrderBLL.GetById(workorderdId);
            txtWorkOrderNo.Text = workOrder.WorkOrderNo;
            txtFiscalYear.Text = workOrder.Fiscalyear;
            cmoPartyId.SelectedValue = workOrder.PartyId;
            dtpWorkOrderDate.Value = workOrder.WorkOrderDate;
            dtpDeliveryDate.Value = workOrder.DeliveryDate;
            nupDiscountPercent.Value = workOrder.DiscountPercent.HasValue ? Convert.ToDecimal(workOrder.DiscountPercent.Value) : 0;
            nupVatPercent.Value = workOrder.VatPercent.HasValue ? Convert.ToDecimal(workOrder.VatPercent.Value) : 0;
            nupTotalexVat.Value = Convert.ToDecimal(workOrder.TotalExvat);
            nupTotalIncVat.Value = Convert.ToDecimal(workOrder.TotalIncvat);
            txtStatus.Text = workOrder.Status.ToString();
            txtNote.Text = workOrder.Note;

            string where = "workorderId= " + workorderdId;
            WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
            List<WorkOrderDetail> workOrderDetails1 = workOrderDetailBLL.GetAll(where);

            workOrderDetails = new BindingList<WorkOrderDetail>(workOrderDetails1);
            gvWorkOrderDetail.DataSource = workOrderDetails;

            if (workOrder.Status != WorkOrderStatus.Placed)
            {
                btnSave.Enabled = false;
            }
        }

        private void gvWorkOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearWorkOrderDetailFields();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            AddNew();
        }

        private void cmoItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmoItemId.SelectedIndex > 0)
            {
                int itemId = Convert.ToInt32(cmoItemId.SelectedValue);
                ItemBLL itemBLL = new ItemBLL();
                Item item = itemBLL.GetById(itemId);
                nupUnit.Value = Convert.ToDecimal(item.Unit);
                nupUnitPrice.Value = Convert.ToDecimal(item.Price);
                nupVatPercent1.Value = Convert.ToDecimal(item.VatRate);
            }
        }

        private void AddNew()
        {
            bool isValid = IsWorkOrderDetailValid();
            if (isValid)
            {
                WorkOrderDetail workorderd = editIndex == -1 ? new WorkOrderDetail(0, DateTime.Now) : workOrderDetails[editIndex];


                workorderd.UpdateTime = DateTime.Now;
                workorderd.WorkOrderId = 0;
                workorderd.ItemId = Convert.ToInt32(cmoItemId.SelectedValue);
                workorderd.ItemName = cmoItemId.Text;
                workorderd.Unit = Convert.ToInt32(nupUnit.Text);
                workorderd.UnitPrice = Convert.ToDouble(nupUnitPrice.Value);
                workorderd.Length = Convert.ToDouble(nupLength.Value);
                workorderd.DiscountPercent = Convert.ToDouble(nupDiscountPercent1.Value);
                workorderd.VatPercent = Convert.ToDouble(nupVatPercent1.Value);

                double total = workorderd.Unit * workorderd.UnitPrice * workorderd.Length;

                if (workorderd.DiscountPercent > 0)
                {
                    double totaldiscount = total * (workorderd.DiscountPercent.Value / 100);
                    total = total - totaldiscount;
                }
                workorderd.TotalExvat = total;

                if (workorderd.VatPercent > 0)
                {
                    double totalvat = total * (workorderd.VatPercent.Value / 100);
                    total = total + totalvat;
                }
                workorderd.TotalIncvat = total;

                if (editIndex == -1)
                workOrderDetails.Add(workorderd);

                gvWorkOrderDetail.DataSource = workOrderDetails;
                gvWorkOrderDetail.Refresh();
                CalculateTotalPrice();
                ClearWorkOrderDetailFields();

            }
        }

        private void LoadItem()
        {
            Item item1 = new Item();
            item1.Id = -1;
            item1.Name = "Please Select-";

            ItemBLL itemBLL = new ItemBLL();
            List<Item> items = itemBLL.GetAll();
            items.Insert(0, item1);
            cmoItemId.DataSource = items;
            cmoItemId.ValueMember = "Id";
            cmoItemId.DisplayMember = "Name";

        }

        private void LoadParty()
        {
            Party party = new Party();
            party.Id = -1;
            party.Name = "Please Select-";

            PartyBLL partyBLL = new PartyBLL();
            List<Party> parties = partyBLL.GetAll();
            parties.Insert(0, party);
            cmoPartyId.DataSource = parties;
            cmoPartyId.ValueMember = "Id";
            cmoPartyId.DisplayMember = "Name";
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                //workorderdId = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[3].Value);
                cmoItemId.SelectedValue = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[4].Value);
                nupUnit.Value = Convert.ToDecimal(gvWorkOrderDetail.Rows[e.RowIndex].Cells[6].Value);
                nupUnitPrice.Value = Convert.ToDecimal(gvWorkOrderDetail.Rows[e.RowIndex].Cells[7].Value);
                nupLength.Value = Convert.ToDecimal(gvWorkOrderDetail.Rows[e.RowIndex].Cells[8].Value);
                nupDiscountPercent1.Value = Convert.ToDecimal(gvWorkOrderDetail.Rows[e.RowIndex].Cells[9].Value);
                nupVatPercent1.Value = Convert.ToDecimal(gvWorkOrderDetail.Rows[e.RowIndex].Cells[10].Value);
                editIndex = e.RowIndex;

            }
            else if (e.ColumnIndex == 15)
            {
                if (MessageBox.Show("Are you sure you want to delete the WorkOrder?", "Delete WorkOrder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    int rowindex = e.RowIndex;
                    workOrderDetails.RemoveAt(rowindex);
                    gvWorkOrderDetail.DataSource = workOrderDetails;
                    CalculateTotalPrice();
                }
            }


        }

        private bool IsWorkOrderDetailValid()
        {
            eP.Clear();
            Boolean iv = true;

            if (Convert.ToInt32(cmoItemId.SelectedValue) == -1)
            {
                cmoItemId.Focus();
                eP.SetError(cmoItemId, "Can't empty");
                iv = false;
            }

            if (nupLength.Value == 0)
            {
                nupLength.Focus();
                eP.SetError(nupLength, "Length must be greater than zero");
                iv = false;
            }

            //foreach(WorkOrderDetail workOrderDetail in workOrderDetails)
            //{
            //    if (workOrderDetail.ItemId == (int)cmoItemId.SelectedValue)
            //    {
            //        cmoItemId.Focus();
            //        eP.SetError(cmoItemId, "Already added!");
            //        iv = false;
            //        break;
            //    }
                
            //}

            for (int i = 0; i < workOrderDetails.Count; i++)
            {
                if (i == editIndex)
                    continue;
                if (workOrderDetails[i].ItemId == (int)cmoItemId.SelectedValue)
                {
                    cmoItemId.Focus();
                    eP.SetError(cmoItemId, "Already added!");
                    iv = false;
                    break;
                }
            }
            return iv;
        }

        private bool IsWorkOrderValid()
        {
            eP.Clear();
            Boolean iv = true;
            if (string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                txtWorkOrderNo.Focus();
                eP.SetError(txtWorkOrderNo, "Can't empty");
                iv = false;

            }

            if (!string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                string whereClause = "WorkOrderNo= '" + txtWorkOrderNo.Text + "'";
                if (workorderdId > 0)
                {
                    whereClause += " and Id !=" + workorderdId;
                }
                bool workOrderExist = workOrderBLL.IsExist(whereClause);
                if (workOrderExist)
                {
                    txtWorkOrderNo.Focus();
                    eP.SetError(txtWorkOrderNo, "Already exists");
                    iv = false;
                }
            }


            if (string.IsNullOrEmpty(txtFiscalYear.Text))
            {
                //txtFiscalYear.Focus();
                eP.SetError(txtFiscalYear, "Can't empty");
                iv = false;

            }

            if (Convert.ToInt32(cmoPartyId.SelectedValue) == -1)
            {
               // cmoPartyId.Focus();
                eP.SetError(cmoPartyId, "Can't empty");
                iv = false;
            }

            if (workOrderDetails.Count == 0)
            {
               
                eP.SetError(gvWorkOrderDetail, "Work Order Detail can't be empty");
                iv = false;
            }
            return iv;

        }
        
        private void ClearWorkOrderDetailFields()
        {
            cmoItemId.SelectedValue = -1;
            nupUnit.Value = 0;
            nupUnitPrice.Value = 0;
            nupLength.Value = 0;
            nupDiscountPercent1.Value = 0;
            nupVatPercent1.Value = 0;
            editIndex = -1;
        }

        private void ClearWorkOrderFields()
        {
            workorderdId = 0;
            txtWorkOrderNo.Text = String.Empty;
            //txtFiscalYear.Text = String.Empty;
            cmoPartyId.SelectedValue = -1;
            dtpWorkOrderDate.Value = DateTime.Today;
            dtpDeliveryDate.Value = DateTime.Today;
            nupDiscountPercent.Value = 0;
            nupVatPercent.Value = 0;
            nupTotalexVat.Value = 0;
            nupTotalIncVat.Value = 0;
            txtStatus.Text = WorkOrderStatus.Placed.ToString();
            txtNote.Text = String.Empty;
            workOrderDetails.Clear();
            gvWorkOrderDetail.DataSource = workOrderDetails;
            gvWorkOrderDetail.Refresh();
        }

        private void CalculateTotalPrice()
        {
            double totalIncVat = 0;
            double totalExVat = 0;

            foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
            {
                totalIncVat = totalIncVat + workOrderDetail.TotalIncvat;
            }
            totalExVat = totalIncVat;

            if (nupDiscountPercent.Value > 0)
            {
                double totalDiscount = Convert.ToDouble(nupDiscountPercent.Value / 100) * totalIncVat;
                totalIncVat = totalIncVat - totalDiscount;
                totalExVat = totalIncVat;
            }

            if (nupVatPercent.Value >0)
            {
                double totalVat = Convert.ToDouble(nupVatPercent.Value / 100) * totalIncVat;
                totalIncVat = totalIncVat + totalVat;
            }
           

            nupTotalexVat.Value = Convert.ToDecimal(totalExVat);
            nupTotalIncVat.Value = Convert.ToDecimal(totalIncVat);

        }

        private void nupDiscountPercent_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void nupVatPercent_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(); 
        }

        private void Save()
        {
            bool isValid = IsWorkOrderValid();
            if (isValid)
            {
                WorkOrder workOrder = new WorkOrder();
                workOrder.Id = workorderdId;
                workOrder.UserId = Global.Userid;
                workOrder.WorkOrderNo = txtWorkOrderNo.Text;
                workOrder.Fiscalyear = txtFiscalYear.Text;
                workOrder.PartyId = Convert.ToInt32(cmoPartyId.SelectedValue);
                workOrder.WorkOrderDate = dtpWorkOrderDate.Value;
                workOrder.DeliveryDate = dtpDeliveryDate.Value;
                workOrder.Discount = Convert.ToDouble(nupDiscountPercent.Value);
                workOrder.TotalExvat = Convert.ToDouble(nupTotalexVat.Value);
                workOrder.TotalIncvat = Convert.ToDouble(nupTotalIncVat.Value);
                if (nupDiscountPercent.Value > 0)
                {
                    workOrder.DiscountPercent = Convert.ToDouble(nupDiscountPercent.Value);

                }
                if (nupVatPercent.Value > 0)
                {
                    workOrder.VatPercent = Convert.ToDouble(nupVatPercent.Value);
                }

                workOrder.Status = (WorkOrderStatus)Enum.Parse(typeof(WorkOrderStatus), txtStatus.Text);
                workOrder.Note = txtNote.Text;


                List<WorkOrderDetail> workOrderDetails1 = workOrderDetails.ToList();
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                workOrderBLL.Save(workOrder, workOrderDetails1);
                MessageBox.Show("WorkOrder saved successfully!");
                gvWorkOrderDetail.Refresh();
                ClearWorkOrderFields();
                GenerateWorkOrderNo();

            }
  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}