using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class StockHistory : Entity
    {
        public StockHistory()
        {

        }

        public StockHistory(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


        private int userid;
        public int UserId { get => userid; set => userid = value; }

        private int categoryid;
        public int CategoryId { get => categoryid; set => categoryid = value; }

        private int itemid;
        public int ItemId { get => itemid; set => itemid = value; }

        private string fiscalyear;
        public string Fiscalyear { get => fiscalyear; set => fiscalyear = value; }

        private string drum;
        public string Drum { get => drum; set => drum = value; }

        private string coilno;
        public string CoilNo { get => coilno; set => coilno = value; }


        private int unit;
        public int Unit { get => unit; set => unit = value; }

        private int quantityinkm;
        public int QuantityInKM { get => quantityinkm; set => quantityinkm = value; }

        private int quantityinfkm;
        public int QuantityInFKM { get => quantityinfkm; set => quantityinfkm = value; }

        private int status;
        public int Status { get => status; set => status = value; }

        private string note;
        public string Note { get => note; set => note = value; }
    }
}
