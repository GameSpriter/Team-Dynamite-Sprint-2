using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomsAndPopsPizzaria
{
    public class User
    {
        public string FirstName, LastName, EmailAddress, PhoneNumber;
        public DateTime birthdate;
        public Address address;

        private string Password;

        public User()
        {

        }

        public bool VerifyPassword()
        {
            return false; //Default to avoid errors, remove later
        }
    }
}