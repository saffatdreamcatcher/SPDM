using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class User : Entity
    {
        public User()
        {

        }

        public User(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string username;
        public string UserName { get => username; set => username = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        public DateTime? lockoutenddate;
        public DateTime? LockoutEndDate { get => lockoutenddate; set => lockoutenddate = value; }

        public bool lockoutenabled;
        public bool LockoutEnabled { get => lockoutenabled; set => lockoutenabled = value; }

        public int accessfailedcount;
        public int AccessFailedCount { get => accessfailedcount; set => accessfailedcount = value; }

        public bool isactive;
        public bool IsActive { get => isactive; set => isactive = value; }




    }
}
