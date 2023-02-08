using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public class Party : Entity
    {
        public Party()
        {

        }

        public Party(int id, DateTime createTime) : base(id, createTime)
        {

        }

        private DateTime? updatetime;
        public DateTime? UpdateTime { get => updatetime; set => updatetime = value; }


        private string account;
        public string Account { get => account; set => account = value; }


        private string name;
        public string Name { get => name; set => name = value; }

        private string address;
        public string Address { get => address; set => address = value; }

        private string city;
        public string City { get => city; set => city = value; }

        private string postalcode;
        public string PostalCode { get => postalcode; set => postalcode = value; }

        private string country;
        public string Country { get => country; set => country = value; }

        private string phone;
        public string Phone { get => phone; set => phone = value; }

        private string mobileno;
        public string MobileNo { get => mobileno; set => mobileno = value; }

        private string fax;
        public string Fax { get => fax; set => fax = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string note;
        public string Note { get => note; set => note = value; }
    }
}
