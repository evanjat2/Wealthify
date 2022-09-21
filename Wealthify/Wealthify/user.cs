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
        private float money;

        public int UserID { get; }

        public string UserName { get => username }

        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }    
    
        public string Name { get => name; set => name = value; }

        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public float Money { get => money; set => money = value; }

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
