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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            SavePayment();
        }
        private void SavePayment()
        {
            //Payment payment = new Payment();
            //payment.Id = 0;
            //payment.UserId = Global.Userid;
            //payment.Fiscalyear = "June-July 2024";
            //payment.SaleId = 1;
            //payment.PartyId = 6;
            //payment.PaymentType = 2;
            //payment.TransactionDate = DateTime.Now;
            //payment.TotalExvat = 0;
            //payment.TotalIncvat = 5;
            //payment.Discount = 110;
            //payment.DiscountPercent = 200;
            //payment.VatPercent = 7;
            //payment.Note = "";

            //PaymentBLL paymentBLL = new PaymentBLL();
            //paymentBLL.Save(payment);

            //PaymentBLL paymentBLL = new PaymentBLL();
            //List<Payment> payments = paymentBLL.GetAll();

            PaymentBLL paymentBLL = new PaymentBLL();
            Payment payment = paymentBLL.GetById(2);
        }

        private void btnSavePaymentDeatil_Click(object sender, EventArgs e)
        {
            SavePaymentDeatil();
        }

        private void SavePaymentDeatil()
        {

        }
    }
}
