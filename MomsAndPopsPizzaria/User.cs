using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class User
    {
        public string firstName, lastName, emailAddress, phoneNumber;
        public DateTime birthdate;
        public Address address;

        private string password;

        public User()
        {
            emailAddress = "";
            password = "";
        }

        public bool VerifyPassword()
        {
            return false; //Default to avoid errors, remove later
        }
    }
}