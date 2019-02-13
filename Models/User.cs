using System;
using System.Collections.Generic;
using System.Text;

namespace try2.Models
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User() { }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if(!this.Email.Equals("") && !this.Password.Equals(""))
            {
                return true;
            }
            return false;
        }

    }
}
