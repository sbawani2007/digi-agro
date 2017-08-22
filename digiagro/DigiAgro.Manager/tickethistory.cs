using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class tickethistory
    {

        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.tickethistory bll_tickethistory;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public tickethistory()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_tickethistory = new BLL.tickethistory();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.tickethistory obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickethistory.Insert(obj, conn, trans);
                    Int32 tickethistory = bll_utility.GetMaxId("tickethistory", "Tickethistoryid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return tickethistory;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.tickethistory obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickethistory.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Tickethistoryid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.tickethistory obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickethistory.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Tickethistoryid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.tickethistory> Select(BOL.tickethistory obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_tickethistory.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.tickethistory> tickethistoryes = new List<BOL.tickethistory>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.tickethistory c = new BOL.tickethistory();

                        if (dr["Tickethistoryid"] != null && Convert.ToInt32(dr["Tickethistoryid"]) > 0)
                        {
                            c.Tickethistoryid = Convert.ToInt32(Convert.ToString(dr["Tickethistoryid"]));
                        }
                        if (dr["Ticketid"] != null && Convert.ToInt32(dr["Ticketid"]) > 0)
                        {
                            c.Ticketid = Convert.ToInt32(Convert.ToString(dr["Ticketid"]));
                        }
                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Userid"] != null && Convert.ToInt32(dr["Userid"]) > 0)
                        {
                            c.Userid = Convert.ToInt32(Convert.ToString(dr["Userid"]));
                        }
                        if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        {
                            c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        }
                        tickethistoryes.Add(c);

                    }
                    return tickethistoryes;
                }

                return null;
            }
            return null;
        }
        #endregion

    }
}
