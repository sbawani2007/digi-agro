﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class Class1
    {
         
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.status bll_status;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public Class1()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_status = new BLL.status();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.status obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_status.Insert(obj, conn, trans);
                    Int32 status = bll_utility.GetMaxId("status", "Statusid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return status;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.status obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_status.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Statusid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.status obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_status.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Statusid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.status> Select(BOL.status obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_status.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.status> statuses = new List<BOL.status>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.status c = new BOL.status();

                        if (dr["Statusid"] != null && Convert.ToInt32(dr["Statusid"]) > 0)
                        {
                            c.Statusid = Convert.ToInt32(Convert.ToString(dr["Statusid"]));
                        }
                        if (dr["Statusname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Statusname"])))
                        {
                            c.Statusname = Convert.ToString(dr["Statusname"]);
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
                        
                        statuses.Add(c);

                    }
                    return statuses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
