using DevExpress.XtraReports.UI;
using SPDM.BLL.BusinessLogic;
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
    public partial class frmReportWorkOrder2 : Form
    {
        public frmReportWorkOrder2()
        {
            InitializeComponent();
        }

        private void frmReportWorkOrder2_Load(object sender, EventArgs e)
        {
            RptWorkOrder4 rptWorkOrder4 = new RptWorkOrder4();
            ReportBLL reportBLL = new ReportBLL();

            string where = "";

            DataSet ds = reportBLL.GetWOWithDetailTest(where);
            ds.Tables["Table"].TableName = "WorkOrder_1";
            ds.Tables["Table1"].TableName = "WorkOrderDetail_1";

            ds.Relations.Add("WorkOrder_1WorkOrderDetail_1", ds.Tables["WorkOrder_1"].Columns["Id"], ds.Tables["WorkOrderDetail_1"].Columns["WorkOrderId"]);
            rptWorkOrder4.DataSource = ds;
            rptWorkOrder4.DataMember = ds.Tables["WorkOrder_1"].TableName;

            DetailReportBand detailReport = rptWorkOrder4.FindControl("DetailReport", true) as DetailReportBand;
            detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder_1", "WorkOrder_1WorkOrderDetail_1");

            rptWorkOrder4.CreateDocument();
            documentViewer1.DocumentSource = rptWorkOrder4;
           // documentViewer1.InitiateDocumentCreation();
        }
    }
}
