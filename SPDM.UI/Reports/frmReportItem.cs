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
    public partial class frmReportItem : Form
    {
        public frmReportItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemBLL itemBLL = new ItemBLL();
            RptItem rptItem = new RptItem();
            rptItem.DataSource = itemBLL.GetAll();
            rptItem.CreateDocument();
            documentViewer1.DocumentSource= rptItem;
           


        }
    }
}
