using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class TariqManager
    {
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.TariqBLL bllTariqObj;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public TariqManager()
        {
            ConnectionString = Utility.GetConnectionString();
            bllTariqObj = new BLL.TariqBLL();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.TariqBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bllTariqObj.Insert(obj, conn, trans);
                    Int32 testID = bll_utility.GetMaxId("form", "testID", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return testID;
                }
                catch(Exception ex)
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.TariqBOL obj)
        {
            //if (obj != null)
            //{
            //    try
            //    {
            //        conn = new MySqlConnection(ConnectionString);
            //        conn.Open();
            //        trans = conn.BeginTransaction();

            //        bllTariqObj.Update(obj, conn, trans);

            //        trans.Commit();
            //        conn.Close();
            //        return obj.TestID;
            //    }
            //    catch
            //    {
            //        trans.Rollback();
            //        conn.Close();
            //    }
            //}
            return 0;
        }

        public Int32 Delete(BOL.TariqBOL obj)
        {
            //if (obj != null)
            //{
            //    try
            //    {
            //        conn = new MySqlConnection(ConnectionString);
            //        conn.Open();
            //        trans = conn.BeginTransaction();

            //        bllTariqObj.Delete(obj, conn, trans);

            //        trans.Commit();
            //        conn.Close();
            //        return obj.TestID;
            //    }
            //    catch
            //    {
            //        trans.Rollback();
            //        conn.Close();
            //    }
            //}
            return 0;
        }
        public List<BOL.customers> Select(BOL.TariqBOL obj)
        {
            //if (obj != null)
            //{
            //    conn = new MySqlConnection(ConnectionString);
            //    conn.Open();
            //    trans = conn.BeginTransaction();

            //    DataSet ds = bll_objCustomer.Select(obj, conn, trans);

            //    trans.Commit();
            //    conn.Close();

            //    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            //    {
            //        List<BOL.customers> customers = new List<BOL.customers>();
            //        foreach (DataRow dr in ds.Tables[0].Rows)
            //        {
            //            BOL.customers c = new BOL.customers();

            //            if (dr["Customerid"] != null && Convert.ToInt32(dr["Customerid"]) > 0)
            //            {
            //                c.Customerid = Convert.ToInt32(Convert.ToString(dr["Customerid"]));
            //            }
            //            if (dr["Firstname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Firstname"])))
            //            {
            //                c.Firstname = Convert.ToString(dr["Firstname"]);
            //            }
            //            if (dr["Createdby"] != null && Convert.ToInt32(dr["Createdby"]) > 0)
            //            {
            //                c.Createdby = Convert.ToInt32(Convert.ToString(dr["Createdby"]));
            //            }
            //            if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
            //            {
            //                c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
            //            }
            //            if (dr["Email"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Email"])))
            //            {
            //                c.Email = Convert.ToString(dr["Email"]);
            //            }
            //            if (dr["Isdeleted"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Isdeleted"])))
            //            {
            //                c.Isdeleted = Convert.ToString(dr["Isdeleted"]);
            //            }
            //            if (dr["Lastname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Lastname"])))
            //            {
            //                c.Lastname = Convert.ToString(dr["Lastname"]);
            //            }
            //            if (dr["Mobile"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Mobile"])))
            //            {
            //                c.Mobile = Convert.ToString(dr["Mobile"]);
            //            }
            //            if (dr["Modifyby"] != null && Convert.ToInt32(dr["Modifyby"]) > 0)
            //            {
            //                c.Modifyby = Convert.ToInt32(Convert.ToString(dr["Modifyby"]));
            //            }
            //            if (dr["Modifyon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifyon"])))
            //            {
            //                c.Modifyon = Convert.ToDateTime(Convert.ToString(dr["Modifyon"]));
            //            }
            //            if (dr["Status"] != null && Convert.ToInt32(dr["Status"]) > 0)
            //            {
            //                c.Status = Convert.ToInt32(Convert.ToString(dr["Status"]));
            //            }

            //            customers.Add(c);

            //        }
            //        return customers;
            //    }

               return null;
            }
         //   return null;
        }
        #endregion
    }

