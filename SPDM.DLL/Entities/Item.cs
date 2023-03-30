using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Item : Entity
    {
        public Item()
        {

        }
        public Item(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


        private int categoryid;
        public int CategoryId { get => categoryid; set => categoryid = value; }


        private int number;
        public int Number { get => number; set => number = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string description;
        public string Description { get => description; set => description = value; }

        private double unit;
        public double Unit { get => unit; set => unit = value; }

        private double price;
        public double Price { get => price; set => price = value; }

        private double? vatrate;
        public double? VatRate { get => vatrate; set => vatrate = value; }

        private byte[] photo;
        public byte[] Photo { get => photo; set => photo = value; }

        private bool isblocked;
        public bool IsBlocked { get => isblocked; set => isblocked = value; }

        private int itemname;
        public int ItemName { get => itemname; set => itemname = value; }

        private string categoryName;

        public string CategoryName { get => categoryName; set => categoryName = value; }


    }
}
