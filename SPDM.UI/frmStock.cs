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
        private BindingList<ProductionDetail> productionDetails = new BindingList<ProductionDetail>();
        private int productionId;
        private int editIndex = -1;

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
           
            bool isValid = IsProductionProductionDetailValid();
            if (isValid)
            {
                try
                {

                    List<Stock> stocks1 = stocks.ToList();
                    StockBLL stockBLL = new StockBLL();
                    stockBLL.Save(productionId, stocks1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                ClearProduction();
                ClearProductionDetail();

            }
        }
        
        private bool IsProductionProductionDetailValid()
        {
            eP.Clear();
            Boolean iv = true;
            int countStock = stocks.Count;
            int countItem = cmoItemId.Items.Count;
            if (countItem != countStock)
            {
                gVStock.Focus();
                eP.SetError(gVStock, "All Items need to add in Stock");
                iv = false;

            }

            if (txtProductionNo.Text == String.Empty)
            {
                txtProductionNo.Focus();
                eP.SetError(txtProductionNo, "Please enter Production No!");
                iv = false;
            }
            return iv;
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
            txtStatus.Text = workOrder.Status.ToString();
            txtNote.Text = production.Note;


            string where = "productionId= " + productionId;
            ProductionDetailBLL productionDetailBLL = new ProductionDetailBLL();
            List<ProductionDetail> productionDetails1 = productionDetailBLL.GetAll(where);
            foreach (ProductionDetail productionDetail in productionDetails1)
            {
                productionDetails.Add(productionDetail);
            }


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
            cmoItemId.ValueMember = "Id";
            cmoItemId.DisplayMember = "Name";
            cmoItemId.DataSource = items;
           
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            LoadProduction();
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
                stock.Din = Convert.ToInt32(nUpDin.Value);
                foreach(ProductionDetail productionDetail in productionDetails)
                {
                    if(productionDetail.ItemId == stock.ItemId)
                    {
                        stock.Unit = productionDetail.Unit;
                        break;
                    }
                }
                stock.OpeningQuantityInKM = Convert.ToInt32(nUpOQinKM.Value);
                stock.OpeningQuantityInFKM = Convert.ToInt32(nUpOQinFKM.Value);
                stock.CurrentQuantityInKM = Convert.ToInt32(nUpOQinKM.Value);
                stock.CurrentQuantityInFKM = Convert.ToInt32(nUpOQinFKM.Value);
                stock.Note = txtNote.Text;
                stock.ItemName = cmoItemId.Text;
                stock.Length = Convert.ToDouble(nupLength.Text);

                

                ItemBLL itemBLL = new ItemBLL();
                Item item = itemBLL.GetById(stock.ItemId);

                CategoryBLL categoryBLL = new CategoryBLL();
                Category category = categoryBLL.GetById(item.CategoryId);

                stock.CategoryName = category.Name;
                stock.CategoryId = Convert.ToInt32(item.CategoryId);

                stocks.Add(stock);
                gVStock.DataSource = stocks;
                gVStock.Refresh();
                ClearProductionDetail();
            }
        }

        private bool IsStockValid()
        {
            eP.Clear();
            Boolean iv = true;

            for (int i = 0; i < stocks.Count; i++)
            {
                // if (i == editIndex)
                // continue;
                if (stocks[i].ItemId == (int)cmoItemId.SelectedValue)
                {
                    cmoItemId.Focus();
                    eP.SetError(cmoItemId, "Already added!");
                    iv = false;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(txtDrum.Text))
            {
                StockBLL stockBLL = new StockBLL();
                string whereClause = "Drum= '" + txtDrum.Text + "'";
                
                bool stockExist = stockBLL.IsExist(whereClause);
                if (stockExist)
                {
                    txtDrum.Focus();
                    eP.SetError(txtDrum, "Already exists");
                    iv = false;
                }
            }


            foreach (Stock stock in stocks)
            {
                if (stock.Drum == txtDrum.Text)
                {
                    eP.SetError(txtDrum, "Drum already exists!");
                    iv = false;
                    break;
                }
                
            }

            return iv;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gVStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 20)
            {
                int rowindex = e.RowIndex;
                stocks.RemoveAt(rowindex);
                gVStock.DataSource = stocks;
                ClearProductionDetail();
               
            }
        }

        private void ClearProduction()
        {
            txtProductionNo.Text = String.Empty;
            txtFiscalYear.Text = String.Empty;
            txtPartyId.Text = String.Empty; 
            txtWorkOrderId.Text = String.Empty;
            nupTotalexVat.Value = 0;
            nupTotalIncVat.Value = 0;
            nupDiscountPercent.Value = 0;
            nupVatPercent.Value = 0;
            txtStatus.Text = String.Empty;
            txtNote.Text = String.Empty;
        }

        private void ClearProductionDetail()
        {
            cmoItemId.SelectedIndex = 0;
            txtDrum.Text = "";
            txtCoilNo.Text = "";
            nupLength.Value = 0;
            nUpDin.Value = 0;
            nUpOQinKM.Value = 0;
            nUpOQinFKM.Value = 0;
            editIndex = -1;
        }

        private void cmoItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(cmoItemId.SelectedValue);
            foreach(ProductionDetail productionDetail in  productionDetails)
            {
                if(productionDetail.ItemId == itemId)
                {
                    nupLength.Value = Convert.ToDecimal(productionDetail.Length);
                    //nUpOQinKM.Value = Convert.ToDecimal(productionDetail.Length);
                    break;
                }
            }
        }
    }
}
