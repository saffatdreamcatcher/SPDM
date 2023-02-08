using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Payment : Entity
    {
        public Payment()
        {

        }

        public Payment(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime updatetime;
        public DateTime UpdateTime { get => updatetime; set => updatetime = value; }


        private int userid;
        public int UserId { get => userid; set => userid = value; }

        private string fiscalyear;
        public string Fiscalyear { get => fiscalyear; set => fiscalyear = value; }


        private int saleid;
        public int SaleId { get => saleid; set => saleid = value; }

        private int partyid;
        public int PartyId { get => partyid; set => partyid = value; }

        private int paymenttype;
        public int PaymentType { get => paymenttype; set => paymenttype = value; }

        private DateTime transactiondate;
        public DateTime TransactionDate { get => transactiondate; set => transactiondate = value; }

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

        private string note;
        public string Note { get => note; set => note = value; } 

        

    }
}
