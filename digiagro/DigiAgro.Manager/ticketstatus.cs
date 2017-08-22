using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class ticketstatus
    {
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.ticketstatus bll_ticketstatus;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public ticketstatus()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_ticketstatus = new BLL.ticketstatus();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.ticketstatus obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketstatus.Insert(obj, conn, trans);
                    Int32 ticketstatus = bll_utility.GetMaxId("ticketstatus", "Ticketstatusid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return ticketstatus;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketstatus obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketstatus.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Ticketstatusid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketstatus obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketstatus.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Ticketstatusid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.ticketstatus> Select(BOL.ticketstatus obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_ticketstatus.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.ticketstatus> ticketstatuses = new List<BOL.ticketstatus>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.ticketstatus c = new BOL.ticketstatus();

                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Description"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Ticketstatusname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Ticketstatusname"])))
                        {
                            c.Ticketstatusname = Convert.ToString(dr["Ticketstatusname"]);
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
                            c.Modifiedby = Convert.ToInt32(Convert.ToString(dr["Modifyby"]));
                        }
                        if (dr["Modifyon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifyon"])))
                        {
                            c.Modifiedon = Convert.ToDateTime(Convert.ToString(dr["Modifyon"]));
                        }
                        
                        ticketstatuses.Add(c);

                    }
                    return ticketstatuses;
                }

                return null;
            }
            return null;
        }

        public List<BOL.ticketstatus> SelectAll(BOL.ticketstatus obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_ticketstatus.SelectAll(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.ticketstatus> ticketstatuses = new List<BOL.ticketstatus>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.ticketstatus c = new BOL.ticketstatus();

                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Description"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Ticketstatusname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Ticketstatusname"])))
                        {
                            c.Ticketstatusname = Convert.ToString(dr["Ticketstatusname"]);
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
                        if (dr["Modifiedby"] != null && Convert.ToInt32(dr["Modifiedby"]) > 0)
                        {
                            c.Modifiedby = Convert.ToInt32(Convert.ToString(dr["Modifiedby"]));
                        }
                        if (dr["Modifiedon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifiedon"])))
                        {
                            c.Modifiedon = Convert.ToDateTime(Convert.ToString(dr["Modifiedon"]));
                        }

                        ticketstatuses.Add(c);

                    }
                    return ticketstatuses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
