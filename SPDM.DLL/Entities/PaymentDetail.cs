using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class PaymentDetail : Entity
    {
        public PaymentDetail()
        {

        }

        public PaymentDetail(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


        private int paymentid;
        public int PaymentId { get => paymentid; set => paymentid = value; }

        private double totalexvat;
        public double TotalExvat { get => totalexvat; set => totalexvat = value; }

        private double totalincvat;
        public double TotalIncvat { get => totalincvat; set => totalincvat = value; }

        private double? discount;
        public double? Discount { get => discount; set => discount = value; }

        private double? discountpercent;
        public double? DiscountPercent { get => discountpercent; set => discountpercent = value; }

        private double? vatpercent;
        public double? VatPercent { get => vatpercent; set => vatpercent = value; }

        private int transactiontype;
        public int TransactionType { get => transactiontype; set => transactiontype = value; }

        private string bankname;
        public string BankName { get => bankname; set => bankname = value; }

        private string checkno;
        public string CheckNo { get => checkno; set => checkno = value; }

        private string bkashtransactionno;
        public string BkashTransactionNo { get => bkashtransactionno; set => bkashtransactionno = value; }



    }
}
