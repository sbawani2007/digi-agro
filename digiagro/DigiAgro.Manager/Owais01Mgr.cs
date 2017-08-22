using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
   public class Owais01Mgr
    {
        #region properties and variables

       // DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
       // Manager.Owais01Mgr mgr_objOwais01Mgr;
        BLL.Owais01BLL bll_objOwais01BLL;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public Owais01Mgr()
        {
            ConnectionString = Utility.GetConnectionString();
          //  mgr_objOwais01Mgr = new Manager.Owais01Mgr();
            bll_objOwais01BLL = new BLL.Owais01BLL();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.Owais01BOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objOwais01BLL.Insert(obj, conn, trans);
                    Int32 idNumber = bll_utility.GetMaxId("owais", "idNumber", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return idNumber;
                }
                catch (Exception )
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.Owais01BOL obj)
        {
            //if (obj != null)
            //{
            //    try
            //    {
            //        conn = new MySqlConnection(ConnectionString);
            //        conn.Open();
            //        trans = conn.BeginTransaction();

            //        bll_objOwais01BLL.Update(obj, conn, trans);

            //        trans.Commit();
            //        conn.Close();
            //        return obj.IdNumber;
            //    }
            //    catch
            //    {
            //        trans.Rollback();
            //        conn.Close();
            //    }
            //}
            return 0;
        }

        public Int32 Delete(BOL.Owais01BOL obj)
        {
            //if (obj != null)
            //{
            //    try
            //    {
            //        conn = new MySqlConnection(ConnectionString);
            //        conn.Open();
            //        trans = conn.BeginTransaction();

            //        bll_objOwais01BLL.Delete(obj, conn, trans);

            //        trans.Commit();
            //        conn.Close();
            //        return obj.IdNumber;
            //    }
            //    catch
            //    {
            //        trans.Rollback();
            //        conn.Close();
            //    }
            //}
            return 0;
        }
       public List<BOL.customers> Select(BOL.Owais01BOL obj)
        { 
            // {transaction();

        //    if (obj != null)
        //    {
        //        conn = new MySqlConnection(ConnectionString);
        //        conn.Open();
        //        trans = conn.BeginT
        //        DataSet ds = bll_objOwais01BLL.Select(obj, conn, trans);

        //        trans.Commit();
        //        conn.Close();

        //        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        //        {
        //            List<BOL.Owais01BOL> customers = new List<BOL.Owais01BOL>();
        //            foreach (DataRow dr in ds.Tables[0].Rows)
        //            {
        //                BOL.Owais01BOL c = new BOL.Owais01BOL();

        //                if (dr["idNumber"] != null && Convert.ToInt32(dr["idNumber"]) > 0)
        //                {
        //                    c.IdNumber = Convert.ToInt32(Convert.ToString(dr["idNumber"]));
        //                }
        //                if (dr["firstName"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["firstName"])))
        //                {
        //                    c.FirstName = Convert.ToString(dr["firstName"]);
        //                }
        //                if (dr["lastName"] != null && Convert.ToInt32(dr["lastName"]) > 0)
        //                {
        //                    c.LastName = Convert.ToInt32(Convert.ToString(dr["lastName"]));
        //                }
        //                if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
        //                {
        //                    c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
        //                }
        //                if (dr["Email"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Email"])))
        //                {
        //                    c.Email = Convert.ToString(dr["Email"]);
        //                }
        //                if (dr["Isdeleted"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Isdeleted"])))
        //                {
        //                    c.Isdeleted = Convert.ToString(dr["Isdeleted"]);
        //                }
        //                if (dr["Lastname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Lastname"])))
        //                {
        //                    c.Lastname = Convert.ToString(dr["Lastname"]);
        //                }
        //                if (dr["Mobile"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Mobile"])))
        //                {
        //                    c.Mobile = Convert.ToString(dr["Mobile"]);
        //                }
        //                if (dr["Modifyby"] != null && Convert.ToInt32(dr["Modifyby"]) > 0)
        //                {
        //                    c.Modifyby = Convert.ToInt32(Convert.ToString(dr["Modifyby"]));
        //                }
        //                if (dr["Modifyon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifyon"])))
        //                {
        //                    c.Modifyon = Convert.ToDateTime(Convert.ToString(dr["Modifyon"]));
        //                }
        //                if (dr["Status"] != null && Convert.ToInt32(dr["Status"]) > 0)
        //                {
        //                    c.Status = Convert.ToInt32(Convert.ToString(dr["Status"]));
        //                }

        //                customers.Add(c);

        //            }
        //            return customers;
        //        }

                return null;
            }
        
      //  return null;
        }
        #endregion
    
   }
