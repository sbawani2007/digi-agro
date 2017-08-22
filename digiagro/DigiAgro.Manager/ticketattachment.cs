using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace DigiAgro.Manager
{
    public class ticketattachment
    {
        
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.ticketattachment bll_ticketattachment;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public ticketattachment()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_ticketattachment = new BLL.ticketattachment();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.ticketattachment obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketattachment.Insert(obj, conn, trans);
                    Int32 ticketattachment = bll_utility.GetMaxId("ticketattachment", "Ticketattachmentid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return ticketattachment;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketattachment obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketattachment.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Ticketattachmentid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketattachment obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketattachment.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Ticketattachmentid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.ticketattachment> Select(BOL.ticketattachment obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_ticketattachment.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.ticketattachment> ticketattachmentes = new List<BOL.ticketattachment>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.ticketattachment c = new BOL.ticketattachment();

                        if (dr["Ticketattachmentid"] != null && Convert.ToInt32(dr["Ticketattachmentid"]) > 0)
                        {
                            c.Ticketattachmentid = Convert.ToInt32(Convert.ToString(dr["Ticketattachmentid"]));
                        }
                        if (dr["Link"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Link"])))
                        {
                            c.Link = Convert.ToString(dr["Link"]);
                        }
                        if (dr["Ticketid"] != null && Convert.ToInt32(dr["Ticketid"]) > 0)
                        {
                            c.Ticketid = Convert.ToInt32(Convert.ToString(dr["Ticketid"]));
                        }
                        if (ds.Tables[0].Columns.Contains("customermobile") && dr["customermobile"] != null &&
                               !string.IsNullOrEmpty(Convert.ToString(dr["customermobile"])))
                        {
                            c.Customers = new BOL.customers();
                            c.Customers.Mobile = Convert.ToString(dr["customermobile"]) + "/";
                        }
                        //if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        //{
                        //    c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        //}
                        if (dr["Isdeleted"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Isdeleted"])))
                        {
                            c.Isdeleted = Convert.ToString(dr["Isdeleted"]);
                        }
                        //if (dr["Modifyby"] != null && Convert.ToInt32(dr["Modifyby"]) > 0)
                        //{
                        //    c.Modifiedby = Convert.ToInt32(Convert.ToString(dr["Modifyby"]));
                        //}
                        //if (dr["Modifyon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Modifyon"])))
                        //{
                        //    c.Modifiedon = Convert.ToDateTime(Convert.ToString(dr["Modifyon"]));
                        //}
                        
                        ticketattachmentes.Add(c);

                    }
                    return ticketattachmentes;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
