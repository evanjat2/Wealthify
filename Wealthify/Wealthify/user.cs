using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class User
    {
        private string username;
        private string email;
        private string password;
        private string name;
        private int phoneNumber;
        private int money;

        public int UserID { get; }

        public string UserName { get => username; }

        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }    
    
        public string Name { get => name; set => name = value; }

        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public int Money { get => money; set => money = value; }

        public void Login ( string username, string password )
        {
            // Masih belum tau hehe
        }

        public void SignUp(string username, string password, string name)
        {
            // Masih belum tau hehe
        }
    }
}
