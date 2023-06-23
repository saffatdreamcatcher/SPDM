﻿using SPDM.BLL.BusinessLogic;
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
using DevExpress.XtraWizard;

namespace SPDM.UI
{
    public partial class Form1 : Form
    {
        private List<WorkOrderDetail> workOrderDetails;
        private BindingList<SaleDetail> saleDetails = new BindingList<SaleDetail>();
        //private int saleId;
        private bool isSaved = false;
        private bool isSaleValid = false;
        private bool isPaymentValid = false;

        WorkOrder workOrder;
        public Form1()
        {
            InitializeComponent();
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
            txtLength.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            nupTotalIncVat1.Value = 0;
            nupDiscountPercent1.Value = 0;
            nupVatPercent1.Value = 0;
            txtDrum.Text = "";
            txtCoilNo.Text = "";
            txtAvilableQinKM.Text = "";
            txtAvilableQinFKM.Text = "";

        }

        //private void SaveSale()
        //{
        //    bool isValid = IsSaleValid();
        //    if (isValid)
        //    {
        //        Sale sale = new Sale();
        //        sale.UserId = Global.Userid;
        //        sale.Fiscalyear = txtFiscalYear.Text;
        //        sale.PartyId = workOrder.PartyId;
        //        sale.WorkOrderId = workOrder.Id;
        //        sale.ChallanNo = Convert.ToInt32(txtChallanNo.Text);
        //        sale.SaleDate = dESaleDate.DateTime;
        //        sale.TotalIncvat = Convert.ToDouble(nupTotalIncVat.Value);
        //        if (nupDiscountPercent.Value > 0)
        //        {
        //            sale.DiscountPercent = Convert.ToDouble(nupDiscountPercent.Value);

        //        }
        //        sale.Discount = workOrder.Discount;
        //        sale.DiscountPercent = workOrder.DiscountPercent;
        //        if (nupVatPercent.Value > 0)
        //        {
        //            sale.VatPercent = Convert.ToDouble(nupVatPercent.Value);
        //        }
        //        sale.DeliveryDate = dEDeliveryDate.DateTime;
        //        sale.DeliveryAddress = txtDeliveryAddress.Text;
        //        sale.Note = txtNote.Text;

        //        List<SaleDetail> saleDetails1 = saleDetails.ToList();
        //        SaleBLL saleBLL = new SaleBLL();
        //        saleBLL.Save(sale, saleDetails1, null);
        //        SavePayment(sale.Id);
        //        //saleId = sale.Id;

        //    }
        //}

        //private void SavePayment(int saleId)
        //{
        //    bool isValid = IsPaymentValid();
        //    if (isValid)
        //    {
        //        Payment payment = new Payment();
        //        payment.UserId = Global.Userid;
        //        payment.Fiscalyear = txtFiscalYear.Text;
        //        payment.SaleId = saleId;
        //        payment.PartyId = workOrder.PartyId;
        //        payment.PaymentType = Convert.ToInt32((PaymentStatus)Enum.Parse(typeof(PaymentStatus), cmoPayment.Text));
        //        payment.TransactionDate = dETransactionDate.DateTime;
        //        payment.Discount = workOrder.Discount;
        //        payment.DiscountPercent = workOrder.DiscountPercent;
        //        if (nupVatPercent2.Value > 0)
        //        {
        //            payment.VatPercent = Convert.ToDouble(nupVatPercent2.Value);
        //        }
        //        payment.TotalIncvat = Convert.ToDouble(nupTotalIncVat2.Value);
        //        payment.TransactionType = Convert.ToInt32((TransactionStatus)Enum.Parse(typeof(TransactionStatus), cmoTransaction.Text));
        //        payment.BankName = txtBankName.Text;
        //        payment.CheckNo = txtBankName.Text;
        //        payment.BkashTransactionNo = txtBkashNo.Text;
        //        payment.Note = txtNote.Text;

        //        PaymentBLL paymentBLL = new PaymentBLL();
        //        paymentBLL.Save(payment);
        //    }

        //}

        private void Save()
        {
            // isSaleValid = IsSaleValid();
            //if (!isSaleValid)
            //{
            //    //wizardControl1.SetPreviousPage();
            //    return false;
            //}

            //isPaymentValid = IsPaymentValid();
            //if (!isPaymentValid)
            //{
            //    return false;
            //}

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

            Payment payment = new Payment();
            payment.UserId = Global.Userid;
            payment.Fiscalyear = txtFiscalYear.Text;
            payment.PartyId = workOrder.PartyId;
            payment.PaymentType = Convert.ToInt32((PaymentStatus)Enum.Parse(typeof(PaymentStatus), cmoPayment.Text));
            payment.TransactionDate = dETransactionDate.DateTime;
            payment.Total = Convert.ToDouble(nupTotal.Value);
            payment.TransactionType = Convert.ToInt32((TransactionStatus)Enum.Parse(typeof(TransactionStatus), cmoTransaction.Text));
            payment.BankName = txtBankName.Text;
            payment.CheckNo = txtBankName.Text;
            payment.BkashTransactionNo = txtBkashNo.Text;
            payment.Note = txtNote.Text;

            List<SaleDetail> saleDetails1 = saleDetails.ToList();
            SaleBLL saleBLL = new SaleBLL();
            saleBLL.Save(sale, saleDetails1, payment);

        }
        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            //SaveSale();
            //SavePayment();

            //bool isSaved = Save();
            //  if (isSaved)
            //  {
            //      this.Close();
            //  }
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            ClearSale();
            ClearSaleDetail();

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

                    txtLength.Text = workOrderDetail.Length.ToString();
                    txtUnit.Text = workOrderDetail.Unit.ToString();
                    txtUnitPrice.Text = workOrderDetail.UnitPrice.ToString();
                    nupDiscountPercent.Value = Convert.ToDecimal(workOrderDetail.DiscountPercent);
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

            if (Convert.ToInt32(cmoItem.SelectedValue) == -1)
            {
                cmoItem.Focus();
                eP.SetError(cmoItem, "Can't empty");
                iv = false;
            }


            if (string.IsNullOrEmpty(txtLength.Text))
            {
                eP.SetError(txtLength, "Can't empty");
                iv = false;
            }

            if (Convert.ToDecimal(txtAvilableQinKM.Text) < Convert.ToDecimal(txtLength.Text))
            {
                eP.SetError(txtAvilableQinKM, "Avilable quantity is less than length");
                iv = false;
            }
            return iv;

        }

        private bool IsPaymentValid()
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
                //if (txtCheckNo.Text == string.Empty)
                //{
                //    eP.SetError(txtCheckNo, "Please Enter Check Number");
                //        iv = false;
                //}
            }

            if (cmoTransaction.SelectedIndex == 2 && txtCheckNo.Text == string.Empty)
            {
                eP.SetError(txtCheckNo, "Please Enter Check Number");
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
                txtAvilableQinKM.Text = stock.CurrentQuantityInKM.ToString();
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
                saleDetail.Length = Convert.ToDouble(txtLength.Text);
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

                double sum = 0;
                foreach (SaleDetail saleDetail1 in saleDetails)
                {
                    sum += saleDetail1.TotalIncvat;
                }
                nupTotal.Value = Convert.ToDecimal(sum);
            }
        }


        public void LoadPaymentType()
        {

            string[] enumElements = Enum.GetNames(typeof(PaymentStatus));

            cmoPayment.Items.Add("Please Select-");

            foreach (var item in enumElements)
            {
                if (cmoPayment.SelectedIndex != 1)
                {
                    cmoPayment.Items.Add(item);
                }
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

        private void wizardPage2_Click(object sender, EventArgs e)
        {

        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPaymentType();
            LoadTransactionType();
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
                //if (isPaymentValid)
                //    Save();
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
    }
}
