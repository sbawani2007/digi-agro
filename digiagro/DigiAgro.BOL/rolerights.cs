using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class rolerights
    {
        private System.Int32 rolerightsid;
        public System.Int32 Rolerightsid
        {
            get
            {
                return rolerightsid;
            }
            set
            {
                rolerightsid = value;
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
        private System.Int32 roleid;
        public System.Int32 Roleid
        {
            get
            {
                return roleid;
            }
            set
            {
                roleid = value;
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
    }
}
