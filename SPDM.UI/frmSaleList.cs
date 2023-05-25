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

        private void LoadStatus()
        {
            cmoStatus.Items.AddRange(Enum.GetNames(typeof(WorkOrderStatus)));
            cmoStatus.SelectedIndex = 0;
        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {

            LoadSale();
            LoadStatus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            StringBuilder sB = new StringBuilder();
            var number = (int)(WorkOrderStatus)Enum.Parse(typeof(WorkOrderStatus), cmoStatus.Text.ToString());

            if (txtChallanNo.Text != string.Empty)
            {

                sB.Append(" ChallanNo LIKE '%");
                sB.Append(txtChallanNo.Text);
                sB.Append("%'");
            }

            if (txtDeliveryAddress.Text != string.Empty)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");

                }
                sB.Append(" DeliveryAddress LIKE '%");
                sB.Append(txtDeliveryAddress.Text);
                sB.Append("%'");
            }

            if (Convert.ToInt32(cmoStatus.SelectedValue) >= 0)
            {
                if (sB.ToString() != string.Empty)
                {
                    sB.Append(" AND");
                }

                sB.Append(" Status =");
                sB.Append(cmoStatus.SelectedValue);

            }

            string saleSearch = sB.ToString();

            SaleBLL saleBLL = new SaleBLL();
            List<Sale> sales = saleBLL.GetAll(saleSearch);
            gridControl1.DataSource = sales;

        }
    }
}
