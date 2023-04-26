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
            //PaymentDetail paymentDetail = new PaymentDetail();
            //paymentDetail.Id = 0;
            //paymentDetail.PaymentId = 2;
            //paymentDetail.TotalExvat = 0;
            //paymentDetail.TotalIncvat = 9;
            //paymentDetail.Discount = 0;
            //paymentDetail.DiscountPercent = 8;
            //paymentDetail.VatPercent = 7;
            //paymentDetail.TransactionType = 4;
            //paymentDetail.BankName = "Bank Asia";
            //paymentDetail.CheckNo = "A88";
            //paymentDetail.BkashTransactionNo = "C888";

            //PaymentDetailBLL paymentDetailBLL = new PaymentDetailBLL();
            //paymentDetailBLL.Save(paymentDetail);

            //PaymentDetailBLL paymentDetailBLL = new PaymentDetailBLL();
            //List<PaymentDetail> paymentDetails = paymentDetailBLL.GetAll();

            //PaymentDetailBLL paymentDetailBLL = new PaymentDetailBLL();
            //PaymentDetail paymentDetail = paymentDetailBLL.GetById(2);

            PaymentDetailBLL paymentDetailBLL = new PaymentDetailBLL();
            int paymentDetail = paymentDetailBLL.GetCount();

        }
    }
}
