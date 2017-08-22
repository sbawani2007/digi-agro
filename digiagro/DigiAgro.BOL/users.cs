using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class users
    {
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
        private System.String username;
        public System.String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        private System.String password;
        public System.String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
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
                return createdon;
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
                return modifyon;
            }
            set
            {
                modifyon = value;
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
    }
}
