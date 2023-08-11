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
    public partial class frmReportSale : Form
    {
        public frmReportSale()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RptSale rptSale = new RptSale();
            ReportBLL reportBLL = new ReportBLL();


            DataSet ds = reportBLL.SearchSale(txtChallanNo.Text);
            ds.Tables["Table"].TableName = "Sale_1";
            ds.Tables["Table1"].TableName = "SaleDetail_1";
            ds.Relations.Add("Sale_1SaleDetail_1", ds.Tables["Sale_1"].Columns["Id"], ds.Tables["SaleDetail_1"].Columns["SaleId"]);
            rptSale.DataSource = ds;
            rptSale.DataMember = ds.Tables["Sale_1"].TableName;

            rptSale.Parameters["ChallanNo"].Value = txtChallanNo.Text;
            


            DetailReportBand detailReport = rptSale.FindControl("DetailReport", true) as DetailReportBand;
            detailReport.DataMember = String.Format("{0}.{1}", "Sale_1", "Sale_1SaleDetail_1");

            rptSale.CreateDocument();
            documentViewer1.DocumentSource = rptSale;
        }
    }
}
