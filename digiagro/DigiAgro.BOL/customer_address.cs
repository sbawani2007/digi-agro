using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.BOL
{
    public class customer_address
    {
        private System.Int32 custaddressid;
        public System.Int32 Custaddressid
        {
            get
            {
                return custaddressid;
            }
            set
            {
                custaddressid = value;
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
        private System.String house;
        public System.String House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private System.String street;
        public System.String Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private System.String area;
        public System.String Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        private System.Int32 city;
        public System.Int32 City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private System.Int32 country;
        public System.Int32 Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
    }
}
