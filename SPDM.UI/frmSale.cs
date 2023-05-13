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
            Sale sale = new Sale();
            sale.UserId = Global.Userid;
            sale.WorkOrderId = 7;
            sale.Fiscalyear = "June-July 2025";
            sale.PartyId = 6;
            sale.ChallanNo = 5;
            sale.SaleDate = DateTime.Now;
            sale.TotalExvat = 0;
            sale.TotalIncvat = 5;
            sale.Discount = 3;
            sale.DiscountPercent = 5;
            sale.VatPercent = 7;
            sale.DeliveryDate = DateTime.Now;
            sale.DeliveryAddress = "Dhaka";
            sale.Status = 3;
            sale.Note = "";

            SaleBLL saleBLL = new SaleBLL();
            saleBLL.Save(sale);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                WorkOrder workOrder1 = new WorkOrder();
                WorkOrderBLL workOrderBLL = new WorkOrderBLL();
                Sale sale = new Sale();
                SaleBLL saleBLL = new SaleBLL();
                PartyBLL partyBLL = new PartyBLL();
                
                ItemBLL itemBLL = new ItemBLL();
                string where = "WorkOrderNo= '"  + txtWorkOrderNo.Text + "'";
                List<WorkOrder> workOrders = workOrderBLL.GetAll(where);
                WorkOrderDetailBLL workOrderDetailBLL = new WorkOrderDetailBLL();
                
               

                
                if (workOrders.Count > 0)
                {
                    WorkOrder workOrder = workOrders[0];
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
                   
                    cmoItem.DataSource = items;
                    Item item = new Item();
                    items.Insert(0, item);
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

        


        private void frmSale_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void nupDiscountPercent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
