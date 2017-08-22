using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class AhmedRazaManager
    {
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.AhmedRazaBLL bll_objAhmedRazaBLL;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public AhmedRazaManager()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_objAhmedRazaBLL = new BLL.AhmedRazaBLL();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.AhmedRazaBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objAhmedRazaBLL.Insert(obj, conn, trans);
                    Int32 idNumber = bll_utility.GetMaxId("AhmedRaza", "IdNumber", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return idNumber;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.AhmedRazaBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objAhmedRazaBLL.Update(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.IdNumber;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.AhmedRazaBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objAhmedRazaBLL.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.IdNumber;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.AhmedRazaBOL> Select(BOL.AhmedRazaBOL obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_objAhmedRazaBLL.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.AhmedRazaBOL> AhmedRaza = new List<BOL.AhmedRazaBOL>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.AhmedRazaBOL c = new BOL.AhmedRazaBOL();

                        if (dr["IdNumber"] != null && Convert.ToInt32(dr["IdNumber"]) > 0)
                        {
                            c.IdNumber = Convert.ToInt32(Convert.ToString(dr["IdNumber"]));
                        }
                        if (dr["FirstName"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["FirstName"])))
                        {
                            c.FirstName = Convert.ToString(dr["FirstName"]);
                        }
                        
                        if (dr["LastName"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["LastName"])))
                        {
                            c.LastName = Convert.ToString(dr["LastName"]);
                        }
                        if (dr["Email"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Email"])))
                        {
                            c.Email = Convert.ToString(dr["Email"]);
                        }
                        if (dr["Status"] != null && Convert.ToInt32(dr["Status"]) > 0)
                        {
                            c.Status = Convert.ToInt32(Convert.ToString(dr["Status"]));
                        }

                        AhmedRaza.Add(c);

                    }
                    return AhmedRaza;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
