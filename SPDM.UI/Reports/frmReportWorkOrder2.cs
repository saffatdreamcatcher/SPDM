﻿using DevExpress.XtraReports.UI;
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
            //XtraReport1 xtraReport1 = new XtraReport1();
            //ReportBLL reportBLL = new ReportBLL();

            //string where = "";

            //DataSet ds = reportBLL.GetWOWithDetailTest(where);
            //ds.Tables["Table"].TableName = "WorkOrder_1";
            //ds.Tables["Table1"].TableName = "WorkOrderDetail_1";

            //ds.Relations.Add("WorkOrder_1WorkOrderDetail_1", ds.Tables["WorkOrder_1"].Columns["Id"], ds.Tables["WorkOrderDetail_1"].Columns["WorkOrderId"]);
            //xtraReport1.DataSource = ds;
            //xtraReport1.DataMember = ds.Tables["WorkOrder_1"].TableName;

            //DetailReportBand detailReport = xtraReport1.FindControl("DetailReport", true) as DetailReportBand;
            //detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder_1", "WorkOrder_1WorkOrderDetail_1");

            //xtraReport1.CreateDocument();
            //documentViewer1.DocumentSource = xtraReport1;
        }
    }
}
