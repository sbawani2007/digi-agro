using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class ticketattachment
    {
        private System.Int32 ticketattachmentid;
        public System.Int32 Ticketattachmentid
        {
            get
            {
                return ticketattachmentid;
            }
            set
            {
                ticketattachmentid = value;
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
        private System.String link;
        public System.String Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
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
        private BOL.customers customers;
        public BOL.customers Customers
        {
            get { return customers; }
            set { customers = value; }
        }
    }
}
