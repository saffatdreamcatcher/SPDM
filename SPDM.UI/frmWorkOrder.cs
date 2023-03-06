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
       
        private List<WorkOrderDetail> workOrderDetails = new List<WorkOrderDetail>();
        public frmWorkOrder()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
           
            
            WorkOrderDetail workorderd = new WorkOrderDetail();
            
            workorderd.ItemId = Convert.ToInt32(cmoItemId.SelectedValue);
            workorderd.Unit = Convert.ToInt32(txtUnit.Text);
            workorderd.UnitPrice = Convert.ToDouble(nupUnitPrice.Value);
            workorderd.Length = Convert.ToDouble(nupLength.Value);
            workorderd.TotalExvat = Convert.ToDouble(nupTotalExVat1.Value);
            workorderd.TotalIncvat = Convert.ToDouble(nupTotalIncVat1.Value);
            workorderd.Discount = Convert.ToDouble(nupDiscount1.Value);
            workorderd.DiscountPercent = Convert.ToDouble(nupDiscountPercent1.Value);
            workorderd.VatPercent = Convert.ToDouble(nupVatPercent1.Value);
            workOrderDetails.Add(workorderd);
            gvWorkOrderDetail.DataSource = workOrderDetails;
        }

        private void frmWorkOrder_Load(object sender, EventArgs e)
        {
            gvWorkOrderDetail.DataSource = workOrderDetails;
        }
    }
}
