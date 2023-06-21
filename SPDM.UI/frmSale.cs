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

    public partial class frmSale : Form
    {
        private List<WorkOrderDetail> workOrderDetails;
        private BindingList<SaleDetail> saleDetails = new BindingList<SaleDetail>();
        private int saleId;

        WorkOrder workOrder;


        public frmSale()
        {
            InitializeComponent();
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            SaveSale();
        }

        private void SaveSale()
        {
            //----------testing------------------
            //Sale sale = new Sale();
            //sale.UserId = Global.Userid;
            //sale.WorkOrderId = 7;
            //sale.Fiscalyear = "June-July 2025";
            //sale.PartyId = 6;
            //sale.ChallanNo = 5;
            //sale.SaleDate = DateTime.Now;
            //sale.TotalExvat = 0;
            //sale.TotalIncvat = 5;
            //sale.Discount = 3;
            //sale.DiscountPercent = 5;
            //sale.VatPercent = 7;
            //sale.DeliveryDate = DateTime.Now;
            //sale.DeliveryAddress = "Dhaka";
            //sale.Status = 3;
            //sale.Note = "";

            //SaleBLL saleBLL = new SaleBLL();
            //saleBLL.Save(sale);
            //-------------------------------------------
            bool isValid = IsSaleValid();
            if (isValid)
            {
                Sale sale = new Sale();
                sale.Id = saleId;
                sale.UserId = Global.Userid;
                sale.Fiscalyear = txtFiscalYear.Text;
                sale.PartyId = workOrder.PartyId;
                sale.WorkOrderId = workOrder.Id;
                sale.ChallanNo = Convert.ToInt32(txtChallanNo.Text);
                sale.SaleDate = dtpSaleDate.Value;
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
                sale.DeliveryDate = dtpDeliveryDate.Value;
                sale.DeliveryAddress = txtDeliveryAddress.Text;
                sale.Note = txtNote.Text;

                List<SaleDetail> saleDetails1 = saleDetails.ToList();
                SaleBLL saleBLL = new SaleBLL();
                //saleBLL.Save(sale, saleDetails1);


            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            
            ClearSale();
            ClearSaleDetail();

            //if (txtWorkOrderNo.Text == string.Empty)
            //{
            //    MessageBox.Show("Please enter Work Order No");
            //}


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
            //cmoItem.DataSource = null;
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
            if (!string.IsNullOrEmpty(txtParty.Text))
            {
                txtWorkOrderNo.Focus();
                eP.SetError(txtParty, "Can't empty");
                iv = false;

            }


            if (!string.IsNullOrEmpty(txtChallanNo.Text))
            {

                eP.SetError(txtChallanNo, "Can't empty");
                iv = false;

            }

            if (!string.IsNullOrEmpty(txtDeliveryAddress.Text))
            {
                eP.SetError(txtChallanNo, "Can't empty");
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


            if (!string.IsNullOrEmpty(txtLength.Text))
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


            }
        }

        private void frmSale_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}