using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class roles
    {
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
        private System.String rolename;
        public System.String Rolename
        {
            get
            {
                return rolename;
            }
            set
            {
                rolename = value;
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

        List<rolerights> _rolerights;

        public List<rolerights> Rolerights
        {
            get { return _rolerights; }
            set { _rolerights = value; }
        }
    }
}
