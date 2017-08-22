using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class tickets
    {
         
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.tickets bll_tickets;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public tickets()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_tickets = new BLL.tickets();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.tickets obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickets.Insert(obj, conn, trans);
                    Int32 tickets = bll_utility.GetMaxId("tickets", "Ticketid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return tickets;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.tickets obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickets.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Ticketid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.tickets obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_tickets.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Ticketid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.tickets> Select(BOL.tickets obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_tickets.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.tickets> ticketses = new List<BOL.tickets>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.tickets c = new BOL.tickets();

                        if (dr["Ticketid"] != null && Convert.ToInt32(dr["Ticketid"]) > 0)
                        {
                            c.Ticketid = Convert.ToInt32(Convert.ToString(dr["Ticketid"]));
                        }
                        if (dr["Customerid"] != null && Convert.ToInt32(dr["Customerid"]) > 0)
                        {
                            c.Customerid = Convert.ToInt32(Convert.ToString(dr["Customerid"]));
                        }
                        if (dr["Description"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Title"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Title"])))
                        {
                            c.Title = Convert.ToString(dr["Title"]);
                        }
                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Userid"] != null && Convert.ToInt32(dr["Userid"]) > 0)
                        {
                            c.Userid = Convert.ToInt32(Convert.ToString(dr["Userid"]));
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
                        
                        ticketses.Add(c);

                    }
                    return ticketses;
                }

                return null;
            }
            return null;
        }

        public List<BOL.tickets> GetTicketsByStatus(string ticketStatuses, BOL.tickets obj)
        {
            if (!string.IsNullOrEmpty(ticketStatuses))
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_tickets.GetTicketsByStatus(ticketStatuses, obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.tickets> ticketses = new List<BOL.tickets>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.tickets c = new BOL.tickets();

                        if (dr["Ticketid"] != null && Convert.ToInt32(dr["Ticketid"]) > 0)
                        {
                            c.Ticketid = Convert.ToInt32(Convert.ToString(dr["Ticketid"]));
                        }
                        if (dr["Customerid"] != null && Convert.ToInt32(dr["Customerid"]) > 0)
                        {
                            c.Customerid = Convert.ToInt32(Convert.ToString(dr["Customerid"]));
                        }
                        if (dr["Description"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Title"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Title"])))
                        {
                            c.Title = Convert.ToString(dr["Title"]);
                        }
                        if (dr["Ticketstatusid"] != null && Convert.ToInt32(dr["Ticketstatusid"]) > 0)
                        {
                            c.Ticketstatusid = Convert.ToInt32(Convert.ToString(dr["Ticketstatusid"]));
                        }
                        if (dr["Userid"] != null && Convert.ToInt32(dr["Userid"]) > 0)
                        {
                            c.Userid = Convert.ToInt32(Convert.ToString(dr["Userid"]));
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
                        if (dr["modifiedby"] != null && Convert.ToInt32(dr["modifiedby"]) > 0)
                        {
                            c.Modifiedby = Convert.ToInt32(Convert.ToString(dr["modifiedby"]));
                        }
                        if (dr["Modifiedon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifiedon"])))
                        {
                            c.Modifiedon = Convert.ToDateTime(Convert.ToString(dr["Modifiedon"]));
                        }

                        ticketses.Add(c);

                    }
                    return ticketses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
