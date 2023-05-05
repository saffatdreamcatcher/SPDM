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
        private BindingList<Stock> stocks = new BindingList<Stock>();
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
            //Stock stock = new Stock();
            //stock.Id = productionId;
            //stock.UserId = Global.Userid;
            //stock.CategoryId = 2;
            //stock.ItemId = Convert.ToInt32(cmoItemId.SelectedValue);
            //stock.Fiscalyear = Global.FiscalYear;
            //stock.Drum = txtDrum.Text;
            //stock.CoilNo = txtCoilNo.Text;
            //stock.Din = Convert.ToDouble(txtDin.Text);
            //stock.Unit = Convert.ToInt32(nupUnit.Value);
            //stock.OpeningQuantityInKM = Convert.ToInt32(nUpOQinKM.Value);
            //stock.OpeningQuantityInFKM = Convert.ToInt32(nUpOQinFKM.Value);
            //stock.CurrentQuantityInKM = Convert.ToInt32(nUpCQinKM.Value);
            //stock.CurrentQuantityInFKM = Convert.ToInt32(nUpCQinFKM.Value);
            //stock.Note = txtNote.Text;

            //StockBLL stockBLL = new StockBLL();
            //stockBLL.Save(stock);

            
            List<Stock> stocks1 = stocks.ToList();
            StockBLL stockBLL = new StockBLL();
            stockBLL.Save(productionId, stocks1);

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
            txtFiscalYear.Text = production.Fiscalyear;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }
        private void AddNew()
        {

            bool isValid = IsStockValid();
            if (isValid)
            {
                Stock stock = new Stock();
                stock.UpdateTime = DateTime.Now;
                stock.ItemId = Convert.ToInt32(cmoItemId.SelectedValue);
                stock.UserId = Global.Userid;
                stock.Fiscalyear = txtFiscalYear.Text;
                stock.Drum = txtDrum.Text;
                stock.CoilNo = txtCoilNo.Text;
                stock.Din = Convert.ToDouble(txtDin.Text);
                stock.Unit = Convert.ToInt32(nupUnit.Text);
                stock.OpeningQuantityInKM = Convert.ToInt32(nUpOQinKM.Value);
                stock.OpeningQuantityInFKM = Convert.ToInt32(nUpOQinFKM.Value);
                stock.CurrentQuantityInKM = Convert.ToInt32(nUpCQinKM.Value);
                stock.CurrentQuantityInFKM = Convert.ToInt32(nUpCQinFKM.Value);
                stock.Note = txtNote.Text;
                stock.ItemName = cmoItemId.Text;
                
                
                
                ItemBLL itemBLL = new ItemBLL();
                Item item = itemBLL.GetById(stock.ItemId);

                CategoryBLL categoryBLL = new CategoryBLL();
                Category category = categoryBLL.GetById(item.CategoryId);

                stock.CategoryName = category.Name;
                stock.CategoryId = Convert.ToInt32(item.CategoryId);

                stocks.Add(stock);
                gVStock.DataSource = stocks;
                gVStock.Refresh();
            }
        }

        private bool IsStockValid()
        {
            eP.Clear();
            Boolean iv = true;

            if (Convert.ToInt32(cmoItemId.SelectedValue) == -1)
            {
                cmoItemId.Focus();
                eP.SetError(cmoItemId, "Can't empty");
                iv = false;
            }
            return iv;
        }
    }
}
