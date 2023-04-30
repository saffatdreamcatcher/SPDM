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
    public partial class frmStock : Form
    {
        //private BindingList<ProductionDetail> productionDetails = new BindingList<ProductionDetail>();
        private int productionId;
       

        public frmStock()
        {
            InitializeComponent();
        }

        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            SaveStock();
        }

        private void SaveStock()
        {
            Stock stock = new Stock();
            stock.Id = 4;
            stock.UserId = Global.Userid;
            stock.CategoryId = 2;
            stock.ItemId = 5;
            stock.Fiscalyear = "June-July 2025";
            stock.Drum = "A 11";
            stock.CoilNo = "12B";
            //stock.Din = "9";
            stock.Unit = 15;
            stock.OpeningQuantityInKM = 110;
            stock.OpeningQuantityInFKM = 11;
            stock.CurrentQuantityInKM = 150;
            stock.CurrentQuantityInFKM = 16;
            stock.Note = "";

            StockBLL stockBLL = new StockBLL();
            stockBLL.Save(stock);

            //StockBLL stockBLL = new StockBLL();
            //List<Stock> stocks = stockBLL.GetAll();

            //StockBLL stockBLL = new StockBLL();
            //Stock stock = stockBLL.GetById(2);

            //StockBLL stockBLL = new StockBLL();
            //int stock = stockBLL.GetCount();
        }

        public void ShowDialog(int productionId)
        {
            this.productionId = productionId;
            this.ShowDialog();
            

        }

        private void LoadProduction()
        {
            ProductionBLL productionBLL = new ProductionBLL();
            Production production = productionBLL.GetById(productionId);
            PartyBLL partyBLL = new PartyBLL();
            Party party = partyBLL.GetById(production.PartyId);
            WorkOrderBLL workOrderBLL = new WorkOrderBLL();
            WorkOrder workOrder = workOrderBLL.GetById(production.WorkOrderId);

            txtProductionNo.Text = production.ProductionNo;
            txtFiscalyear.Text = production.Fiscalyear;
            txtPartyId.Text = party.Name;
            txtWorkOrderId.Text = workOrder.WorkOrderNo;
            dtpWorkOrderDate.Value = DateTime.Now;
            nupTotalexVat.Value = Convert.ToDecimal(production.TotalExvat);
            nupTotalIncVat.Value = Convert.ToDecimal(production.TotalIncvat);
            nupDiscountPercent.Value = production.DiscountPercent.HasValue ? Convert.ToDecimal(production.DiscountPercent.Value) : 0;
            nupVatPercent.Value = production.VatPercent.HasValue ? Convert.ToDecimal(production.VatPercent.Value) : 0;
            txtStatus.Text = production.Status.ToString();
            txtNote.Text = production.Note;


            string where = "productionId= " + productionId;
            ProductionDetailBLL productionDetailBLL = new ProductionDetailBLL();
            List<ProductionDetail> productionDetails =productionDetailBLL.GetAll(where);

            string search = "Item.Id in(";

            foreach (ProductionDetail productionDetail in productionDetails)
            {
                search += productionDetail.ItemId;
                search += ",";
               
            }
            search = search.Remove(search.Length - 1);
            search += ")";
            ItemBLL itemBLL = new ItemBLL();
            List<Item> items = itemBLL.GetAll(search);
            cmoItemId.DataSource = items;
            cmoItemId.ValueMember = "Id";
            cmoItemId.DisplayMember = "Name";
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            LoadProduction();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
