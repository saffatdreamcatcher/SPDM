using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Category : Entity
    {
        public Category()
        {

        }
        public Category(int id, DateTime createTime) : base (id, createTime)
        {

        }

        private string name;
        public string Name { get => name; set => name = value; }

        private string description;
        public string Description { get => description; set => description = value; }

        private byte[] photo;
        public byte[] Photo { get => photo; set => photo = value; }

        

    }
}
