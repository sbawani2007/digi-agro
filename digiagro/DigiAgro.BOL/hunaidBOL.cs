using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    //this class name should be HunaidBOL
    public class HunaidBOL
    {
        private System.Int32 customerid;
        public System.Int32 Customerid
        {
            get
            {
                return customerid;
            }
            set
            {
                customerid = value;
            }
        }
        private System.String firstname;
        public System.String Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        private System.String lastname;
        public System.String Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
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
        private System.String mobile;
        public System.String Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        private System.Int32 createdby;
        public System.Int32 Createdby
        {
            get
            {
                return createdby;
            }
            set
            {
                createdby = value;
            }
        }
        private System.DateTime createdon;
        public System.DateTime Createdon
        {
            get
            {
                return Convert.ToDateTime(createdon.ToString("dd/MM/yyyy"));
            }
            set
            {
                createdon = value;
            }
        }
        private System.String isdeleted;
        public System.String Isdeleted
        {
            get
            {
                return isdeleted;
            }
            set
            {
                isdeleted = value;
            }
        }
        private System.Int32 modifyby;
        public System.Int32 Modifyby
        {
            get
            {
                return modifyby;
            }
            set
            {
                modifyby = value;
            }
        }
        private System.DateTime modifyon;
        public System.DateTime Modifyon
        {
            get
            {
                return Convert.ToDateTime(modifyon.ToString("dd/MM/yyyy"));
            }
            set
            {
                modifyon = value;
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


    }
}
