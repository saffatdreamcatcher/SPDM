using DevExpress.DataAccess.Sql;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
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
    public partial class frmReportWorkOrderWDetail : Form
    {
        public frmReportWorkOrderWDetail()
        {
            InitializeComponent();
        }

        private void frmReportWorkOrderWDetail_Load(object sender, EventArgs e)
        {
            RptWOrderWDetail rptWOrderWDetail = new RptWOrderWDetail();
            ReportBLL reportBLL = new ReportBLL();

            string where = "";

            //Procedure -1:Using Dataset
            DataSet ds = reportBLL.GetWOWithDetailTest(where);
           
            ds.Tables["Table"].TableName= "WorkOrder";
            ds.Tables["Table1"].TableName = "WorkOrderDetail";

            //RelationShip should be the same name what we added in design time which is WorkOrderWorkOrderDetail
            ds.Relations.Add("WorkOrderWorkOrderDetail", ds.Tables["WorkOrder"].Columns["Id"], ds.Tables["WorkOrderDetail"].Columns["WorkOrderId"]);

            rptWOrderWDetail.DataSource = ds;
            rptWOrderWDetail.DataMember = ds.Tables["WorkOrder"].TableName;

            DetailReportBand detailReport = rptWOrderWDetail.FindControl("DetailReport", true) as DetailReportBand;
            // Detail Band DataMember should be MaindataMember.RelationName
            detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder", "WorkOrderWorkOrderDetail");

            //Procedure -2:Using SqlDataSource
            /*
            SqlDataSource DataSource = new SqlDataSource("localhost_CableStorage_Connection");

            SelectQuery workOrders = SelectQueryFluentBuilder
           .AddTable("WorkOrder")
           .SelectColumn("") //Need to put all the column seperating by comma
           .Build("WorkOrder");

            SelectQuery workOrderDetails = SelectQueryFluentBuilder
            .AddTable("WorkOrderDetail")
            .SelectColumn("") //Need to put all the column seperating by comma
            .Build("WorkOrderDetail");

            DataSource.Queries.AddRange(new SqlQuery[] { workOrders, workOrderDetails });

            DataSource.Relations.Add(new MasterDetailInfo("WorkOrder", "WorkOrderDetail", "Id", "WorkOrderId"));

            rptWOrderWDetail.DataSource = DataSource;
            rptWOrderWDetail.DataMember = "WorkOrder";

            DetailReportBand detailReport = rptWOrderWDetail.FindControl("DetailReport", true) as DetailReportBand;
            detailReport.DataMember = String.Format("{0}.{1}", "WorkOrder", "WorkOrderWorkOrderDetail");

            */

            rptWOrderWDetail.CreateDocument();
            documentViewer1.DocumentSource = rptWOrderWDetail;
        }
    }
}
