using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDM.UI
{
    public partial class frmWorkOrderList : Form
    {
        public frmWorkOrderList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmWorkOrder myform = new frmWorkOrder();
            myform.ShowDialog();
        }
    }
}
