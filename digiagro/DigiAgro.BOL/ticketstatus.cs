using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class ticketstatus
    {
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
        private System.String ticketstatusname;
        public System.String Ticketstatusname
        {
            get
            {
                return ticketstatusname;
            }
            set
            {
                ticketstatusname = value;
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
    }
}
