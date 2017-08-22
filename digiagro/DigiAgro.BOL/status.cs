using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class status
    {
        private System.Int32 statusid;
        public System.Int32 Statusid
        {
            get
            {
                return statusid;
            }
            set
            {
                statusid = value;
            }
        }
        private System.String statusname;
        public System.String Statusname
        {
            get
            {
                return statusname;
            }
            set
            {
                statusname = value;
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
                return Convert.ToDateTime(createdon.ToString("dd/MM/yyyy"));
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
                return Convert.ToDateTime(modifiedon.ToString("dd/MM/yyyy"));
            }
            set
            {
                modifiedon = value;
            }
        }
    }
}
