using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.UI
{
    public static class Global
    {
        private static int userid;
        public static int Userid { get => userid; set => userid = value; }

        private static string username;
        public static string Username { get => username; set => username = value; }

        private static string email;
        public static string Email { get => email; set => email = value; }

        private static bool isuserlogin;
        public static bool Isuserlogin { get => isuserlogin; set => isuserlogin = value; }
    }
}
