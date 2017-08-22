using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{

    public class OwaisBOL
    {
        private System.Int32 idNumber;
        public System.Int32 IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        private System.String firstName;
        public System.String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        private System.String lastName;
        public System.String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        private System.String email;
        public System.String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        private System.Int32 status;
        public System.Int32 Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
      
 

        private customer_address _customer_address;
        public customer_address Customer_address
        {
            get { return _customer_address; }
            set { _customer_address = value; }
        }

        private List<tickets> ticketses;
        public List<tickets> Ticketses
        {
            get { return ticketses; }
            set { ticketses = value; }
        }

        public string Lastname
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string LastName1
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
    }
}
