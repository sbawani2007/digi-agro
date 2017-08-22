using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class ticketfeedback
    {
         #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.ticketfeedback bll_ticketfeedback;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public ticketfeedback()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_ticketfeedback = new BLL.ticketfeedback();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.ticketfeedback obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketfeedback.Insert(obj, conn, trans);
                    Int32 ticketfeedback = bll_utility.GetMaxId("ticketfeedback", "Ticketfeedbackid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return ticketfeedback;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketfeedback obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketfeedback.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Ticketfeedbackid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketfeedback obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_ticketfeedback.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Ticketfeedbackid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.ticketfeedback> Select(BOL.ticketfeedback obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_ticketfeedback.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.ticketfeedback> ticketfeedbackes = new List<BOL.ticketfeedback>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.ticketfeedback c = new BOL.ticketfeedback();

                        if (dr["Ticketfeedbackid"] != null && Convert.ToInt32(dr["Ticketfeedbackid"]) > 0)
                        {
                            c.Ticketfeedbackid = Convert.ToInt32(Convert.ToString(dr["Ticketfeedbackid"]));
                        }
                        if (dr["Feedback"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Feedback"])))
                        {
                            c.Feedback = Convert.ToString(dr["Feedback"]);
                        }
                        //if (dr["Createdby"] != null && Convert.ToInt32(dr["Createdby"]) > 0)
                        //{
                        //    c.Createdby = Convert.ToInt32(Convert.ToString(dr["Createdby"]));
                        //}
                        if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        {
                            c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        }
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
                        
                        ticketfeedbackes.Add(c);

                    }
                    return ticketfeedbackes;
                }

                return null;
            }
            return null;
        }

        public List<BOL.ticketfeedback> GetAllFeedbacksByTicket(BOL.ticketfeedback obj)
        {
            if (obj != null && obj.Ticketid > 0)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_ticketfeedback.GetAllFeedbacksByTicket(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.ticketfeedback> ticketfeedbackes = new List<BOL.ticketfeedback>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.ticketfeedback c = new BOL.ticketfeedback();

                        if (dr["Ticketfeedbackid"] != null && Convert.ToInt32(dr["Ticketfeedbackid"]) > 0)
                        {
                            c.Ticketfeedbackid = Convert.ToInt32(Convert.ToString(dr["Ticketfeedbackid"]));
                        }
                        if (dr["Feedback"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Feedback"])))
                        {
                            c.Feedback = Convert.ToString(dr["Feedback"]);
                        }
                        if (dr["Userid"] != null && Convert.ToInt32(dr["Userid"]) > 0)
                        {
                            c.Userid = Convert.ToInt32(Convert.ToString(dr["Userid"]));
                            if (ds.Tables[0].Columns.Contains("username") && dr["username"] != null &&
                                !string.IsNullOrEmpty(Convert.ToString(dr["username"])))
                            {
                                c.Users = new BOL.users();
                                c.Users.Userid = Convert.ToInt32(dr["Userid"]);
                                c.Users.Username = Convert.ToString(dr["username"]);
                            }
                        }
                        if (ds.Tables[0].Columns.Contains("customermobile") && dr["customermobile"] != null &&
                               !string.IsNullOrEmpty(Convert.ToString(dr["customermobile"])))
                        {
                            c.Customers = new BOL.customers();
                            c.Customers.Mobile = Convert.ToString(dr["customermobile"]);
                        }
                        //
                        if (dr["Createdon"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        {
                            c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        }
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

                        ticketfeedbackes.Add(c);

                    }
                    return ticketfeedbackes;
                }

                return null;
            }
            return null;
        }

        //
        #endregion
    }
}
