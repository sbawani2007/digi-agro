using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class tickethistory
    {
        private System.Int32 tickethistoryid;
        public System.Int32 Tickethistoryid
        {
            get
            {
                return tickethistoryid;
            }
            set
            {
                tickethistoryid = value;
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
        private System.Int32 ticketstatusid;
        public System.Int32 Ticketstatusid
        {
            get
            {
                return ticketstatusid;
            }
            set
            {
                ticketstatusid = value;
            }
        }
        private DateTime createdon;
        public DateTime Createdon
        {
            get { return createdon; }
            set { createdon = value; }
        }
    }
}
