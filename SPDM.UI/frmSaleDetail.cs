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
    public partial class frmSaleDetail : Form
    {
        public frmSaleDetail()
        {
            InitializeComponent();
        }

        private void btnSaledetail_Click(object sender, EventArgs e)
        {
            SaveSaleDetail();
        }

        private void SaveSaleDetail()
        {
            SaleDetail saledetail = new SaleDetail();
            saledetail.SaleId = 2;
            saledetail.ItemId = 7;
            saledetail.Unit = 25;
            saledetail.UnitPrice = 6;
            saledetail.Length = 5;
            saledetail.TotalExvat = 0;
            saledetail.TotalIncvat = 5;
            saledetail.Discount = 3;
            saledetail.DiscountPercent = 5;
            saledetail.VatPercent = 7;
           

            SaleDetailBLL saledetailBLL = new SaleDetailBLL();
            saledetailBLL.Save(saledetail);
        }
    }
}
