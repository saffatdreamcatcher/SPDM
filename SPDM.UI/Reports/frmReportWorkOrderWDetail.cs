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

            

            DataSet ds = reportBLL.GetWOWithDetailTest(where);
            rptWOrderWDetail.DataSource = ds;


            rptWOrderWDetail.CreateDocument();
            documentViewer1.DocumentSource = rptWOrderWDetail;
        }
    }
}
