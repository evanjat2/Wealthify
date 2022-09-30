using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Admin
    {
        private string username;
        private string email;
        private string password;
        private int phoneNumber;

        public int UserID { get; }

        public string UserName { get => username; }

        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }

        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Boolean Login(string username, string password)
        {
            return false;
        }

        public Boolean SignUp(string username, string password, string Email)
        {
            return false; 
        }

        public void AddAdmin(string username, string password, string email, int phoneNumber)
        {
            return;
        }

        public void EditAdmin(string username)
        {
            return;
        }

        public void AddPengguna(string username,string email, string password, string name, string phoneNumber, string money )
        {
            return;
        }

        public void EditPengguna(string username)
        {
            return;
        }

    }
}
