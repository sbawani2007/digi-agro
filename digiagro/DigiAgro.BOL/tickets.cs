using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class tickets
    {
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
        private System.String title;
        public System.String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private System.String description;
        public System.String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
                return createdon;
            }
            set
            {
                createdon = value;
            }
        }
        private System.Int32 modifiedby;
        public System.Int32 Modifiedby
        {
            get
            {
                return modifiedby;
            }
            set
            {
                modifiedby = value;
            }
        }
        private System.DateTime modifiedon;
        public System.DateTime Modifiedon
        {
            get
            {
                return modifiedon;
            }
            set
            {
                modifiedon = value;
            }
        }

        List<ticketattachment> _ticketattachment;
        public List<ticketattachment> Ticketattachments
        {
            get { return _ticketattachment; }
            set { _ticketattachment = value; }
        }
        List<ticketfeedback> _ticketfeedback;
        public List<ticketfeedback> Ticketfeedbacks
        {
            get { return _ticketfeedback; }
            set { _ticketfeedback = value; }
        }
        List<tickethistory> _tickethistory;
        public List<tickethistory> Tickethistory
        {
            get { return _tickethistory; }
            set { _tickethistory = value; }
        }

    }
}
