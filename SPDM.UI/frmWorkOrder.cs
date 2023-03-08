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
    public partial class frmWorkOrder : Form
    {

        private BindingList<WorkOrderDetail> workOrderDetails = new BindingList<WorkOrderDetail>();
        private int workorderdId;

        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            WorkOrderDetail workorderd = new WorkOrderDetail(0, DateTime.Now);
            workorderd.UpdateTime = DateTime.Now;
            workorderd.WorkOrderId = 0;
            workorderd.ItemId = Convert.ToInt32(cmoItemId.SelectedValue);
            workorderd.Unit = Convert.ToInt32(nupUnit.Text);
            workorderd.UnitPrice = Convert.ToDouble(nupUnitPrice.Value);
            workorderd.Length = Convert.ToDouble(nupLength.Value);
            workorderd.TotalExvat = Convert.ToDouble(nupTotalExVat1.Value);
            workorderd.TotalIncvat = Convert.ToDouble(nupTotalIncVat1.Value);
            //workorderd.Discount = Convert.ToDouble(nupDiscount1.Value);
            workorderd.DiscountPercent = Convert.ToDouble(nupDiscountPercent1.Value);
            workorderd.VatPercent = Convert.ToDouble(nupVatPercent1.Value);
            workOrderDetails.Add(workorderd);
            gvWorkOrderDetail.DataSource = workOrderDetails;

        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {

            //gvWorkOrderDetail.DataSource = workOrderDetails;
            LoadItem();
        }

        private void LoadItem()
        {
            Item item = new Item();
            item.Id = -1;
            item.Name = "Please Select-";

            ItemBLL itemBLL = new ItemBLL();
            List<Item> items = itemBLL.GetAll();
            items.Insert(0, item);
            cmoItemId.DataSource = items;
            cmoItemId.ValueMember = "Id";
            cmoItemId.DisplayMember = "Name";

        }

        private void nupLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmoItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmoItemId.SelectedIndex > 0)
            {
                int itemId = Convert.ToInt32(cmoItemId.SelectedValue);
                ItemBLL itemBLL = new ItemBLL();
                Item item = itemBLL.GetById(itemId);
                nupUnit.Value = item.Unit;
                nupUnitPrice.Value = Convert.ToDecimal(item.Price);
                nupVatPercent1.Value = Convert.ToDecimal(item.VatRate);
            }
        }

        private void ManageEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                workorderdId = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[3].Value);
                cmoItemId.SelectedValue = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[4].Value);
                nupUnit.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[5].Value);
                nupUnitPrice.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[6].Value);
                nupLength.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[7].Value);
                nupDiscountPercent1.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[8].Value);
                nupVatPercent1.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[9].Value);
                nupTotalExVat1.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[10].Value);
                nupTotalIncVat1.Value = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[11].Value);
            }
            else if (e.ColumnIndex == 15)
            {
                var id = Convert.ToInt32(gvWorkOrderDetail.Rows[e.RowIndex].Cells[0].Value);
                DeleteWorkOrderDeatil(id);
            }
        }

        private void DeleteWorkOrderDeatil(int id)
        {
            if (MessageBox.Show("Are you sure you want to delete the WorkOrderDetail?", "Delete WorkOrderDetail", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                WorkOrderDetailBLL workorderdetailBLL = new WorkOrderDetailBLL();
                workorderdetailBLL.Delete(id);
                LoadWorkOrderDetail();
            }

        }

        private void LoadWorkOrderDetail()
        {
            WorkOrderDetailBLL workorderdetailBLL = new WorkOrderDetailBLL();
            List<WorkOrderDetail> workorderdetails = workorderdetailBLL.GetAll();

            gvWorkOrderDetail.DataSource = workorderdetails;
        }

        private void gvWorkOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }
    }
}