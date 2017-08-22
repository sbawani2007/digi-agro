using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class customer_address
    {
         #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.customer_address bll_customer_address;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public customer_address()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_customer_address = new BLL.customer_address();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.customer_address obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_customer_address.Insert(obj, conn, trans);
                    Int32 customerid = bll_utility.GetMaxId("customer_address", "Custaddressid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return customerid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.customer_address obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_customer_address.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Customerid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.customer_address obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_customer_address.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Customerid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.customer_address> Select(BOL.customer_address obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_customer_address.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.customer_address> customer_addresses = new List<BOL.customer_address>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.customer_address c = new BOL.customer_address();

                        if (dr["Customerid"] != null && Convert.ToInt32(dr["Customerid"]) > 0)
                        {
                            c.Customerid = Convert.ToInt32(Convert.ToString(dr["Customerid"]));
                        }
                        if (dr["Custaddressid"] != null && Convert.ToInt32(dr["Custaddressid"]) > 0)
                        {
                            c.Custaddressid = Convert.ToInt32(Convert.ToString(dr["Custaddressid"]));
                        }
                        if (dr["Area"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Area"])))
                        {
                            c.Area = Convert.ToString(dr["Area"]);
                        }
                        if (dr["City"] != null && Convert.ToInt32(dr["City"]) > 0)
                        {
                            c.City = Convert.ToInt32(Convert.ToString(dr["City"]));
                        }
                        if (dr["House"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["House"])))
                        {
                            c.House = Convert.ToString(dr["House"]);
                        }
                        if (dr["Street"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Street"])))
                        {
                            c.Street = Convert.ToString(dr["Street"]);
                        }
                        
                        if (dr["Country"] != null && Convert.ToInt32(dr["Country"]) > 0)
                        {
                            c.Country = Convert.ToInt32(Convert.ToString(dr["Country"]));
                        }

                        customer_addresses.Add(c);

                    }
                    return customer_addresses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
