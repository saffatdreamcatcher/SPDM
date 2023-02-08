using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Stock : Entity
    {
        public Stock()
        {

        }

        public Stock(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime updatetime;
        public DateTime UpdateTime { get => updatetime; set => updatetime = value; }


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

        private string din;
        public string Din { get => din; set => din = value; }

        private int unit;
        public int Unit { get => unit; set => unit = value; }

        private int openingquantityinkm;
        public int OpeningQuantityInKM { get => openingquantityinkm; set => openingquantityinkm = value; }

        private int openingquantityinfkm;
        public int OpeningQuantityInFKM { get => openingquantityinfkm; set => openingquantityinfkm = value; }

        private int currentquantityinkm;
        public int CurrentQuantityInKM { get => currentquantityinkm; set => currentquantityinkm = value; }

        private int currentquantityinfkm;
        public int CurrentQuantityInFKM { get => currentquantityinfkm; set => currentquantityinfkm = value; }

        private string note;
        public string Note { get => note; set => note = value; }

    }
}
