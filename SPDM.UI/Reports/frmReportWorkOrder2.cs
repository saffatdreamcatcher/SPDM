using DevExpress.XtraReports.UI;
using SPDM.BLL.BusinessLogic;
using SPDM.DLL.Entities;
using SPDM.DLL.Enums;
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
            LoadWorkOrderWDetail();
            LoadParty();
            LoadStatus();
        }

        private void LoadWorkOrderWDetail()
        {
            RptWorkOrder2 rptWorkOrder2 = new RptWorkOrder2();
            ReportBLL reportBLL = new ReportBLL();

            string where = "";

            DataSet ds = reportBLL.GetWOWithDetailTest(where);
            ds.Tables["Table"].TableName = "WorkOrder_1";
            ds.Tables["Table1"].TableName = "WorkOrderDetail_1";

            ds.Relations.Add("WorkOrder_1WorkOrderDetail_1", ds.Tables["WorkOrder_1"].Columns["Id"], ds.Tables["WorkOrderDetail_1"].Columns["WorkOrderId"]);
            rptWorkOrder2.DataSource = ds;
            rptWorkOrder2.DataMember = ds.Tables["WorkOrder_1"].TableName;

            DetailReportBand detailReport = rptWorkOrder2.FindControl("DetailReport", true) as DetailReportBand;
            detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder_1", "WorkOrder_1WorkOrderDetail_1");

            rptWorkOrder2.CreateDocument();
            documentViewer1.DocumentSource = rptWorkOrder2;
            // documentViewer1.InitiateDocumentCreation();
        }

        private void LoadParty()
        {

            Party party = new Party();
            party.Id = 0;
            party.Name = "Please Select-";
            PartyBLL partyBLL = new PartyBLL();
            List<Party> parties = partyBLL.GetAll();
            cmoParty.DataSource = parties;
            parties.Insert(0, party);
            cmoParty.ValueMember = "Id";
            cmoParty.DisplayMember = "Name";

        }

        public void LoadStatus()
        {

            string[] enumElements = Enum.GetNames(typeof(WorkOrderStatus));

            cmoStatus.Items.Add("All");

            foreach (string item in enumElements)
            {
                cmoStatus.Items.Add(item);
            }
            cmoStatus.SelectedIndex = 0;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RptWorkOrder2 rptWorkOrder2 = new RptWorkOrder2();
            ReportBLL reportBLL = new ReportBLL();

            WorkOrderStatus st = (WorkOrderStatus)Enum.Parse(typeof(WorkOrderStatus), cmoStatus.Text);
            int status = (int)st;

            DataSet ds = reportBLL.SearchWorkOrder(txtWorkOrderNo.Text, (int)cmoParty.SelectedValue, status);
            ds.Tables["Table"].TableName = "WorkOrder_1";
            ds.Tables["Table1"].TableName = "WorkOrderDetail_1";
            ds.Relations.Add("WorkOrder_1WorkOrderDetail_1", ds.Tables["WorkOrder_1"].Columns["Id"], ds.Tables["WorkOrderDetail_1"].Columns["WorkOrderId"]);
            rptWorkOrder2.DataSource = ds;
            rptWorkOrder2.DataMember = ds.Tables["WorkOrder_1"].TableName;

            rptWorkOrder2.Parameters["WorkOrderNo"].Value = txtWorkOrderNo.Text;
            rptWorkOrder2.Parameters["Party"].Value = cmoParty.SelectedValue;
            rptWorkOrder2.Parameters["Status"].Value = cmoStatus.Text;

            

            DetailReportBand detailReport = rptWorkOrder2.FindControl("DetailReport", true) as DetailReportBand;
            detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder_1", "WorkOrder_1WorkOrderDetail_1");

            rptWorkOrder2.CreateDocument();
            documentViewer1.DocumentSource = rptWorkOrder2;
        }
    }
}
