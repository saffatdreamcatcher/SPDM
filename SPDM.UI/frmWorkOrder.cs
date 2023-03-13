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
        private int editIndex = -1;

        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void gvWorkOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageEdit(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
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
                nupUnit.Value = item.Unit;
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
                ClearField();

            }
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
                int rowindex = e.RowIndex;
                workOrderDetails.RemoveAt(rowindex);
                gvWorkOrderDetail.DataSource = workOrderDetails;
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
            return iv;
        }

        private void ClearField()
        {
            cmoItemId.SelectedValue = -1;
            nupUnit.Value = 0;
            nupUnitPrice.Value = 0;
            nupLength.Value = 0;
            nupDiscountPercent1.Value = 0;
            nupVatPercent1.Value = 0;
            editIndex = -1;
        }

       
    }
}