using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{

    public class ticketfeedback
    {
        private System.Int32 ticketfeedbackid;
        public System.Int32 Ticketfeedbackid
        {
            get
            {
                return ticketfeedbackid;
            }
            set
            {
                ticketfeedbackid = value;
            }
        }
        private System.Int32 ticketid;
        public System.Int32 Ticketid
        {
            get
            {
                return ticketid;
            }
            set
            {
                ticketid = value;
            }
        }
        private System.Int32 userid;
        public System.Int32 Userid
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        private string username;
        public string Username
        {
            get {

                if (users != null && !string.IsNullOrEmpty(users.Username))
                {
                    return username;
                }
                else
                {
                    return ""; ;
                }
            
            }
            set { username = value; }
        }


        private System.String feedback;
        public System.String Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
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

        private DateTime createdon;
        public DateTime Createdon
        {
            get { return createdon; }
            set { createdon = value; }
        }

        private BOL.users users;
        public BOL.users Users
        {
            get { return users; }
            set { users = value; }
        }

        private BOL.customers customers;
        public BOL.customers Customers
        {
            get { return customers; }
            set { customers = value; }
        }
    }
}
