using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Role : Entity
    {
        public Role()
        {

        }

        public Role(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string name;
        public string Name { get => name; set => name = value; }
    }
}
