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
    public partial class frmReportStock : Form
    {
        public frmReportStock()
        {
            InitializeComponent();
        }

        private void frmReportStock_Load(object sender, EventArgs e)
        {
            RptStock rptStock = new RptStock();
            ReportBLL reportBLL = new ReportBLL();


            string where = "";

            DataTable dt = reportBLL.GetStock(where);
            dt.TableName = "Stock_1";
            rptStock.DataSource = dt;
            rptStock.DataMember = "Stock_1";

            rptStock.CreateDocument();
            documentViewer1.DocumentSource = rptStock;

            //rptStock.ShowPreview();
            
        }
    }
}
