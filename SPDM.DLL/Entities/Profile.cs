using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Profile : Entity
    {
        public Profile()
        {

        }

        public Profile(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private string userid;
        public string UserId { get => userid; set => userid = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string address;
        public string Address { get => address; set => address = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private int designation;
        public int Designation { get => designation; set => designation = value; }

        private string phone;
        public string Phone { get => phone; set => phone = value; }

        private string mobileno;
        public string MobileNo { get => mobileno; set => mobileno = value; }

        private byte[] photo;
        public byte[] Photo { get => photo; set => photo = value; }





    }
}
