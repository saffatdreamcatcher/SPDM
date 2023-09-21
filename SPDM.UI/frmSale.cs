using DevExpress.XtraWizard;
using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using SPDM.DLL.Enums;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmSale : Form
    {
        private List<WorkOrderDetail> workOrderDetails;
        private BindingList<SaleDetail> saleDetails = new BindingList<SaleDetail>();
        private BindingList<Payment> payments = new BindingList<Payment>();
        private bool isSaleValid = false;
        private bool isPaymentValid = false;
        private int saleId = -1;

        WorkOrder workOrder;
        public frmSale()
        {
            InitializeComponent();
        }

        public void ShowDialog(int saleId)
        {
            this.saleId = saleId;
            this.ShowDialog();
        }

        private void ClearSale()
        {
            lblWorkOrder.Text = "";
            txtParty.Text = "";
            txtFiscalYear.Text = "";
            nupTotalIncVat.Value = 0;
            nupDiscountPercent.Value = 0;
            nupVatPercent.Value = 0;
            txtStatus.Text = "";
        }

        private void ClearSaleDetail()
        {
            //cmoItem.SelectedIndex = 0;
            nupLength.Value = 0;
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            nupDiscountPercent1.Value = 0;
            nupVatPercent1.Value = 0;
            nupTotalIncVat1.Value = 0;
            txtDrum.Text = "";
            txtCoilNo.Text = "";
            nupAvilableQinKM.Value = 0;
            txtAvilableQinFKM.Text = "";

        }

        private void Save()
        {
            Sale sale = new Sale();
            sale.UserId = Global.Userid;
            sale.Fiscalyear = txtFiscalYear.Text;
            sale.PartyId = workOrder.PartyId;
            sale.WorkOrderId = workOrder.Id;
            sale.ChallanNo = Convert.ToInt32(txtChallanNo.Text);
            sale.SaleDate = dESaleDate.DateTime;
            sale.TotalIncvat = Convert.ToDouble(nupTotalIncVat.Value);
            if (nupDiscountPercent.Value > 0)
            {
                sale.DiscountPercent = Convert.ToDouble(nupDiscountPercent.Value);

            }
            sale.Discount = workOrder.Discount;
            sale.DiscountPercent = workOrder.DiscountPercent;
            if (nupVatPercent.Value > 0)
            {
                sale.VatPercent = Convert.ToDouble(nupVatPercent.Value);
            }
            sale.DeliveryDate = dEDeliveryDate.DateTime;
            sale.DeliveryAddress = txtDeliveryAddress.Text;
            sale.Note = txtNote.Text;

            List<SaleDetail> saleDetails1 = saleDetails.ToList();
            List<Payment> payments1 = payments.ToList();
            SaleBLL saleBLL = new SaleBLL();
            saleBLL.Save(sale, saleDetails1, payments1);

        }
        
        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            ClearSale();
            ClearSaleDetail();
            Search();
        }

        private void Search()
        {
            if (!string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                WorkOrder workOrder1 = new WorkOrder();
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                PartyBLL partyBLL = new PartyBLL();

                ItemBLL itemBLL = new ItemBLL();
                string where = "WorkOrderNo= '" + txtWorkOrderNo.Text + "'";
                where = where + " and Status = " + (int)WorkOrderStatus.InStock;
                List<WorkOrder> workOrders = workOrderBLL.GetAll(where);
                WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();


                if (workOrders.Count == 0)
                {
                    lblWorkOrder.Text = "Work Order not found";
                }

                if (workOrders.Count > 0)
                {
                    workOrder = workOrders[0];
                    Party party = partyBLL.GetById(workOrder.PartyId);
                    string ww = "WorkOrderId= " + workOrder.Id;
                    workOrderDetails = workOrderDetailBLL.GetAll(ww);
                    string search = "Item.Id in(";
                    foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
                    {
                        search += workOrderDetail.ItemId;
                        search += ",";

                    }
                    search = search.Remove(search.Length - 1);
                    search += ")";
                    List<Item> items = itemBLL.GetAll(search);


                    Item item = new Item();
                    item.Id = 0;
                    item.Name = "Please Select-";
                    items.Insert(0, item);
                    cmoItem.DataSource = items;
                    cmoItem.ValueMember = "Id";
                    cmoItem.DisplayMember = "Name";

                    txtFiscalYear.Text = workOrder.Fiscalyear;
                    txtParty.Text = party.Name;
                    nupTotalIncVat.Value = Convert.ToDecimal(workOrder.TotalIncvat);
                    nupDiscountPercent.Value = Convert.ToDecimal(workOrder.DiscountPercent);
                    nupVatPercent.Value = Convert.ToDecimal(workOrder.VatPercent);
                    txtStatus.Text = workOrder.Status.ToString();
                }
            }
        }

        private void ShowWorkOrderdetail()
        {

            int ii = Convert.ToInt32(cmoItem.SelectedValue);

            foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
            {

                if (workOrderDetail.ItemId == ii)
                {

                    nupLength.Value = Convert.ToDecimal(workOrderDetail.Length);
                    txtUnit.Text = workOrderDetail.Unit.ToString();
                    txtUnitPrice.Text = workOrderDetail.UnitPrice.ToString();
                    nupDiscountPercent1.Value = Convert.ToDecimal(workOrderDetail.DiscountPercent);
                    nupVatPercent.Value = Convert.ToDecimal(workOrderDetail.VatPercent);
                    nupTotalIncVat1.Value = Convert.ToDecimal(workOrderDetail.TotalIncvat);
                    nupVatPercent1.Value = Convert.ToDecimal(workOrderDetail.VatPercent);
                    txtDrum.Text = workOrderDetail.Drum.ToString();
                    return;

                }

            }
        }

        private bool IsSaleValid()
        {
            eP.Clear();
            Boolean iv = true;

            if (string.IsNullOrEmpty(txtParty.Text))
            {
                txtParty.Focus();
                eP.SetError(txtParty, "Can't empty");
                iv = false;

            }


            if (string.IsNullOrEmpty(txtChallanNo.Text))
            {

                eP.SetError(txtChallanNo, "Can't empty");
                iv = false;

            }

            if (string.IsNullOrEmpty(txtDeliveryAddress.Text))
            {
                eP.SetError(txtDeliveryAddress, "Can't empty");
                iv = false;
            }
            if (saleDetails.Count == 0)
            {

                eP.SetError(gvSaleDetail, "Sale Detail can't be empty");
                iv = false;
            }
            return iv;
        }

        private bool IsSaleDetailValid()
        {
            eP.Clear();
            Boolean iv = true;

            if(String.IsNullOrEmpty(txtChallanNo.Text))
            {
                txtChallanNo.Focus();
                eP.SetError(txtChallanNo, "Challan No cant be empty!");
                iv = false;
            }

            if(String.IsNullOrEmpty(txtDeliveryAddress.Text))
            {
                txtDeliveryAddress.Focus();
                eP.SetError(txtDeliveryAddress, "Delivery Address cant be empty!");
                iv = false;
            }

            if(dESaleDate.EditValue == null)
            {
                dESaleDate.Focus();
                eP.SetError(dESaleDate, "Sale Date cant be empty!");
                iv = false;
            }

            if (dEDeliveryDate.EditValue == null)
            {
                dEDeliveryDate.Focus();
                eP.SetError(dEDeliveryDate, "Delivery Date cant be empty!");
                iv = false;
            }


            if (Convert.ToInt32(cmoItem.SelectedValue) == -1)
            {
                cmoItem.Focus();
                eP.SetError(cmoItem, "Can't empty");
                iv = false;
            }

            foreach (SaleDetail saleDetail in saleDetails)
            {
                if (saleDetail.ItemId == Convert.ToInt32(cmoItem.SelectedValue))
                {
                    eP.SetError(cmoItem, "Item already added");
                    iv = false;
                    break;
                }
            }

            //if (string.IsNullOrEmpty(txtLength.Text))
            //{
            //    eP.SetError(txtLength, "Can't empty");
            //    iv = false;
            //}

            if (Convert.ToDecimal(nupAvilableQinKM.Value) < Convert.ToDecimal(nupLength.Value))
            {
                eP.SetError(nupAvilableQinKM, "Avilable quantity is less than length");
                iv = false;
            }
            return iv;

        }

        private bool IsPaymentGridValid()
        {
            eP.Clear();
            Boolean iv = true;

            if (cmoPayment.SelectedIndex == 0)
            {
                cmoPayment.Focus();
                eP.SetError(cmoPayment, "Can't empty");
                iv = false;

            }

            if (cmoTransaction.SelectedIndex == 0)
            {

                eP.SetError(cmoTransaction, "Can't empty");
                iv = false;

            }

            if (nupTotal.Value == 0)
            {
                eP.SetError(nupTotal, "Can't be zero");
                iv = false;
            }

            if (dETransactionDate.EditValue == null)
            {
                eP.SetError(dETransactionDate, "Provide Transaction Date");
                iv = false;
            }

            if (cmoTransaction.SelectedIndex == 3 && txtBkashNo.Text == string.Empty)
            {
                eP.SetError(txtBkashNo, "Please Enter Bkash Number");
                iv = false;
            }

            if (cmoTransaction.SelectedIndex == 2 && txtBankName.Text == string.Empty)
            {
                eP.SetError(txtBankName, "Please Enter Bank Name");
                iv = false;
            }

            if (cmoTransaction.SelectedIndex == 2 && txtCheckNo.Text == string.Empty)
            {
                eP.SetError(txtCheckNo, "Please Enter Check Number");
                iv = false;
            }

            double sum = 0;
            foreach (Payment payment1 in payments)
            {
                sum += payment1.Total;
            }
            if (Convert.ToDecimal(sum) + nupTotal.Value > nupTotalIncVat.Value)
            {
                eP.SetError(gvPayment, "Paymnet value is greater than Sale value");
                iv = false;
            }
            return iv;
        }

        private void cmoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSaleDetail();
            if (cmoItem.SelectedIndex > 0)
            {
                ShowWorkOrderdetail();
            }
        }

        private void ShowStock()

        {
            StockBLL stockBLL = new StockBLL();
            string where = "Drum= '" + txtDrum.Text + "'";
            List<Stock> stocks = stockBLL.GetAll(where);
            if (stocks.Count > 0)
            {
                Stock stock = stocks[0];
                txtCoilNo.Text = stock.CoilNo;
                nupAvilableQinKM.Text = stock.CurrentQuantityInKM.ToString();
                txtAvilableQinFKM.Text = stock.CurrentQuantityInFKM.ToString();
            }
        }

        private void txtDrum_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDrum.Text))
            {
                ShowStock();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = IsSaleDetailValid();
            if (isValid)
            {
                SaleDetail saleDetail = new SaleDetail();
                saleDetail.ItemId = Convert.ToInt32(cmoItem.SelectedValue);
                saleDetail.ItemName = cmoItem.Text;
                saleDetail.Length = Convert.ToDouble(nupLength.Value);
                saleDetail.Unit = Convert.ToInt32(txtUnit.Text);
                saleDetail.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                saleDetail.DiscountPercent = Convert.ToDouble(nupDiscountPercent1.Value);
                saleDetail.VatPercent = Convert.ToDouble(nupVatPercent1.Value);
                saleDetail.TotalIncvat = Convert.ToDouble(nupTotalIncVat1.Value);

                foreach (WorkOrderDetail workOrderDetail in workOrderDetails)
                {
                    if (workOrderDetail.ItemId == saleDetail.ItemId)
                    {
                        saleDetail.Discount = workOrderDetail.Discount;
                        break;
                    }
                }

                saleDetails.Add(saleDetail);
                gvSaleDetail.DataSource = saleDetails;
                gvSaleDetail.Refresh();

                //double sum = 0;
                //foreach (SaleDetail saleDetail1 in saleDetails)
                //{
                //    sum += saleDetail1.TotalIncvat;
                //}
                //nupTotal.Value = Convert.ToDecimal(sum);
                ClearSaleDetail();
            }
        }

        private bool IsPaymentValid()
        {

            double sum = 0;
            foreach (Payment payment1 in payments)
            {
                sum += payment1.Total;
            }
            Boolean iv = true;
            if (nupTotalIncVat.Value != Convert.ToDecimal(sum))
            {
                eP.SetError(nupTotal, "Payment Value must be equal to the SaleValue");
                iv = false;
            }
            return iv;
        }

        public void LoadPaymentType()
        {

            string[] enumElements = Enum.GetNames(typeof(PaymentStatus));

            cmoPayment.Items.Add("Please Select-");

            foreach (string item in enumElements)
            {
                if (item == "Advance")
                {
                    continue;
                }
                cmoPayment.Items.Add(item);
            }
            cmoPayment.SelectedIndex = 0;

        }

        public void LoadTransactionType()
        {

            string[] enumElements = Enum.GetNames(typeof(TransactionStatus));

            cmoTransaction.Items.Add("Please Select-");

            foreach (var item in enumElements)
            {
                cmoTransaction.Items.Add(item);
            }
            cmoTransaction.SelectedIndex = 0;

        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPaymentType();
            LoadTransactionType();
            if(saleId > -1)
            {

            }
              
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (wizardControl1.SelectedPage.Name == "wizardPage1")
            {
                isSaleValid = IsSaleValid();
            }
            else if (wizardControl1.SelectedPage.Name == "wizardPage2")
            {
                isPaymentValid = IsPaymentValid();

                if (isPaymentValid)
                    Save();

            }
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Direction == Direction.Forward)
            {
                if (e.PrevPage == wizardPage1 && !isSaleValid)
                {
                    e.Cancel = true;
                }
                else if (e.PrevPage == wizardPage2 && !isPaymentValid)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            bool isGridValid = IsPaymentGridValid();
            if (isGridValid)
            {
                Payment payment = new Payment();
                payment.UserId = Global.Userid;
                payment.Fiscalyear = txtFiscalYear.Text;
                payment.PartyId = workOrder.PartyId;
                payment.PaymentType = Convert.ToInt32((PaymentStatus)Enum.Parse(typeof(PaymentStatus), cmoPayment.Text));
                payment.TransactionDate = dETransactionDate.DateTime;
                payment.Total = Convert.ToDouble(nupTotal.Value);
                payment.TransactionDate = (DateTime)dETransactionDate.EditValue;
                payment.TransactionType = Convert.ToInt32((TransactionStatus)Enum.Parse(typeof(TransactionStatus), cmoTransaction.Text));
                payment.BankName = txtBankName.Text;
                payment.CheckNo = txtCheckNo.Text;
                payment.BkashTransactionNo = txtBkashNo.Text;
                payment.Note = txtNote.Text;
                payment.PaymentTypeName = cmoPayment.Text;
                payment.TransactionTypeName = cmoTransaction.Text;

                payments.Add(payment);
                gvPayment.DataSource = payments;
                gvPayment.Refresh();

                ClearPayment();

                TotalRemainingCalculation();
                
            }

        }

        private void TotalRemainingCalculation()
        {
            double sum = 0;
            foreach (Payment payment1 in payments)
            {
                sum += payment1.Total;
            }
            nupTotal.Value = nupTotalIncVat.Value - Convert.ToDecimal(sum);
           
        }

        private void ClearPayment()
        {
            cmoPayment.SelectedIndex = 0;
            cmoTransaction.SelectedIndex = 0;
            dETransactionDate.EditValue = null;
            nupTotal.Value = 0;
            txtBankName.Text = "";
            txtCheckNo.Text = "";
            txtBkashNo.Text = "";
            txtNote.Text = "";

        }

        private void gvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 18)
            {
                int rowindex = e.RowIndex;
                payments.RemoveAt(rowindex);
                gvPayment.DataSource = payments;
                TotalRemainingCalculation();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }
    }

}