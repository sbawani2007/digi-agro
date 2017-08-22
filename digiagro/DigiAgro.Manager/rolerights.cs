using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace DigiAgro.Manager
{
    public class rolerights
    {
        
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.rolerights bll_rolerights;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public rolerights()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_rolerights = new BLL.rolerights();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.rolerights obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_rolerights.Insert(obj, conn, trans);
                    Int32 rolerightsid = bll_utility.GetMaxId("rolerights", "Rolerightsid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return rolerightsid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.rolerights obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_rolerights.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Rolerightsid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.rolerights obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_rolerights.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Rolerightsid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.rolerights> Select(BOL.rolerights obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_rolerights.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.rolerights> rolerightses = new List<BOL.rolerights>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.rolerights c = new BOL.rolerights();

                        if (dr["Roleid"] != null && Convert.ToInt32(dr["Roleid"]) > 0)
                        {
                            c.Roleid = Convert.ToInt32(Convert.ToString(dr["Roleid"]));
                        }
                        if (dr["Rolerightsid"] != null && Convert.ToInt32(dr["Rolerightsid"]) > 0)
                        {
                            c.Rolerightsid = Convert.ToInt32(Convert.ToString(dr["Rolerightsid"]));
                        }
                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Createdby"] != null && Convert.ToInt32(dr["Createdby"]) > 0)
                        {
                            c.Createdby = Convert.ToInt32(Convert.ToString(dr["Createdby"]));
                        }
                        if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        {
                            c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        }
                        if (dr["Isdeleted"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Isdeleted"])))
                        {
                            c.Isdeleted = Convert.ToString(dr["Isdeleted"]);
                        }
                        if (dr["Modifyby"] != null && Convert.ToInt32(dr["Modifyby"]) > 0)
                        {
                            c.Modifyby = Convert.ToInt32(Convert.ToString(dr["Modifyby"]));
                        }
                        if (dr["Modifyon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifyon"])))
                        {
                            c.Modifyon = Convert.ToDateTime(Convert.ToString(dr["Modifyon"]));
                        }
                        
                        rolerightses.Add(c);

                    }
                    return rolerightses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
