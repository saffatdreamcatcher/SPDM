using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class UserRole : Entity
    {
        public UserRole()
        {

        }

        public UserRole(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private int userid;
        public int UserId { get => userid; set => userid = value; }

        private int roleid;
        public int RoleId { get => roleid; set => roleid = value; }
    }
}
