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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            SaveSale();
        }

        private void SaveSale()
        {
            Sale sale = new Sale();
            sale.UserId = Global.Userid;
            sale.WorkOrderId = 7;
            sale.Fiscalyear = "June-July 2025";
            sale.PartyId = 6;
            sale.ChallanNo = 5;
            sale.SaleDate = DateTime.Now;
            sale.TotalExvat = 0;
            sale.TotalIncvat = 5;
            sale.Discount = 3;
            sale.DiscountPercent = 5;
            sale.VatPercent = 7;
            sale.DeliveryDate = DateTime.Now;
            sale.DeliveryAddress = "Dhaka";
            sale.Status = 3;
            sale.Note = "";

            SaleBLL saleBLL = new SaleBLL();
            saleBLL.Save(sale);

        }
    }
}
