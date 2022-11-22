using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    public class Pengguna
    {
        private static int userID = 0;
        private static string username = " ";
        private static string email = " ";
        private static string password = " ";
        private static string name = " ";
        private static int phoneNumber = 0;
        private static float money = 0;
        private static bool isAdmin = false;

        public static int UserID { get => userID; set => userID = value; }

        public static string UserName { get => username; set => username = value; }

        public static string Email { get => email; set => email = value; }

        public static string Password { get => password; set => password = value; }    
    
        public static string Name { get => name; set => name = value; }

        public static int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public static float Money { get => money; set => money = value; }

        public static bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        public Boolean Login ( string username, string password )
        {
            return false;
        }

        public Boolean SignUp(string username, string password, string name)
        {
            return false;
        }
    }
}
