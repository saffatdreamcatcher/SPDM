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

namespace SPDM.UI
{
    public partial class frmSaleList : Form
    {
        public frmSaleList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmSale myform = new frmSale();
            myform.ShowDialog();
            LoadSale();
        }

        private void LoadSale()
        {
            SaleBLL saleBLL = new SaleBLL();
            List<Sale> sales = saleBLL.GetAll();
            gridControl1.DataSource = sales;
            gridControl1.ForceInitialize();

        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {

            LoadSale();
        }

    }
}
