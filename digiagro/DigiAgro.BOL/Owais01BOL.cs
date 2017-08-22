using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
   public class Owais01BOL
    {
        int idNumber;
        public int IdNumber
        {
             get { return idNumber;}
             set { idNumber = value;}
        }
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        int contactNum;
        public int ContactNum
        {
            get { return contactNum; }
            set { contactNum = value; }
        }
    }
}
