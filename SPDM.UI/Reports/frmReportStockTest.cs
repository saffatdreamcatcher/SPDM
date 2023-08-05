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
    public partial class frmReportStockTest : Form
    {
        public frmReportStockTest()
        {
            InitializeComponent();
        }

        private void frmReportStockTest_Load(object sender, EventArgs e)
        {
            RptStockTest rptStockTest = new RptStockTest();
            ReportBLL reportBLL = new ReportBLL();
            string where = "";

            DataTable dt = reportBLL.GetStock(where);

            DataSet ds = new DataSet();
            dt.TableName = "Stock_1";
            ds.Tables.Add(dt);
            ds.WriteXmlSchema(@"E:\TestStock\testStock1.xsd");
            rptStockTest.DataAdapter = ds;

            rptStockTest.CreateDocument();
            documentViewer1.DocumentSource = rptStockTest;
        }
    }
}
