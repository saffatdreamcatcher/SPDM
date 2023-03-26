using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class FiscalYear : Entity
    {
        public FiscalYear()
        {

        }

        public FiscalYear(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private int userid;
        public int UserId { get => userid; set => userid = value; }

        private string year;
        public string Year { get => year; set => year = value; }
    }
}
