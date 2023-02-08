using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class ProductionDetail : Entity
    {
        public ProductionDetail()
        {

        }

        public ProductionDetail(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime updatetime;
        public DateTime UpdateTime { get => updatetime; set => updatetime = value; }


        private int productionid;
        public int ProductionId { get => productionid; set => productionid = value; }

        private int workorderdetailid;
        public int WorkOrderDetailId { get => workorderdetailid; set => workorderdetailid = value; }

        private int itemid;
        public int ItemId { get => itemid; set => itemid = value; }

        private int unit;
        public int Unit { get => unit; set => unit = value; }

        private double unitprice;
        public double UnitPrice { get => unitprice; set => unitprice = value; }

        private double length;
        public double Length { get => length; set => length = value; }

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




    }
}
