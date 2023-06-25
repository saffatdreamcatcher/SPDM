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

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


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


        private double total;
        public double Total { get => total; set => total = value; }

        private int transactiontype;
        public int TransactionType { get => transactiontype; set => transactiontype = value; }

        private string bankname;
        public string BankName { get => bankname; set => bankname = value; }

        private string checkno;
        public string CheckNo { get => checkno; set => checkno = value; }

        private string bkashtransactionno;
        public string BkashTransactionNo { get => bkashtransactionno; set => bkashtransactionno = value; }

        private string note;
        public string Note { get => note; set => note = value; }

        private string paymenttypename;
        public string PaymentTypeName { get => paymenttypename; set => paymenttypename = value; }

        private string transactiontypename;
        public string TransactionTypeName { get => transactiontypename; set => transactiontypename = value; }

    }
}
