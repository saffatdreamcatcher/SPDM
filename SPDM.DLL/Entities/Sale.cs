using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Sale : Entity
    {
        public Sale()
        {

        }

        public Sale(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


        private int userid;
        public int UserId { get => userid; set => userid = value; }

        private int workorderid;
        public int WorkOrderId { get => workorderid; set => workorderid = value; }

        private string fiscalyear;
        public string Fiscalyear { get => fiscalyear; set => fiscalyear = value; }

        private int partyid;
        public int PartyId { get => partyid; set => partyid = value; }

        private int challanno;
        public int ChallanNo { get => challanno; set => challanno = value; }

        private DateTime saledate;
        public DateTime SaleDate { get => saledate; set => saledate = value; }

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

        public string deliveryaddress;
        public string DeliveryAddress { get => deliveryaddress; set => deliveryaddress = value; }

        public DateTime deliverydate;
        public DateTime DeliveryDate { get => deliverydate; set => deliverydate = value; }

        private string note;
        public string Note { get => note; set => note = value; }

    }
}
