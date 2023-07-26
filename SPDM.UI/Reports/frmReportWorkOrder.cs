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

namespace SPDM.UI.Reports
{
    public partial class frmReportWorkOrder : Form
    {
        public frmReportWorkOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptWorkOrder rptWorkOrder = new RptWorkOrder();
            ReportBLL reportBLL = new ReportBLL();
            
            string where = "";

            if (!string.IsNullOrEmpty(txtWorkOrderNo.Text))
            {
                 where = "WorkOrderNo =  '" + txtWorkOrderNo.Text + "' ";
               
            }
            DataSet ds = reportBLL.GetWorkOrders(where);
            rptWorkOrder.DataSource = ds;
            rptWorkOrder.Parameters["WorkOrderNo"].Value = txtWorkOrderNo.Text;

            rptWorkOrder.CreateDocument();
            documentViewer1.DocumentSource = rptWorkOrder;
        }
    }
}
