using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class users
    {
        
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.users bll_users;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public users()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_users = new BLL.users();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.users obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_users.Insert(obj, conn, trans);
                    Int32 users = bll_utility.GetMaxId("users", "Userid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return users;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.users obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_users.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Userid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.users obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_users.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Userid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.users> Select(BOL.users obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_users.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.users> userses = new List<BOL.users>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.users c = new BOL.users();

                        if (dr["Userid"] != null && Convert.ToInt32(dr["Userid"]) > 0)
                        {
                            c.Userid = Convert.ToInt32(Convert.ToString(dr["Userid"]));
                        }
                        if (dr["Email"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Email"])))
                        {
                            c.Email = Convert.ToString(dr["Email"]);
                        }
                        if (dr["Firstname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Firstname"])))
                        {
                            c.Firstname = Convert.ToString(dr["Firstname"]);
                        }
                        if (dr["Lastname"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Lastname"])))
                        {
                            c.Lastname = Convert.ToString(dr["Lastname"]);
                        }
                        if (dr["Password"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Password"])))
                        {
                            c.Password = Convert.ToString(dr["Password"]);
                        }
                        if (dr["Username"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Username"])))
                        {
                            c.Username = Convert.ToString(dr["Username"]);
                        }
                        if (dr["Roleid"] != null && Convert.ToInt32(dr["Roleid"]) > 0)
                        {
                            c.Roleid = Convert.ToInt32(Convert.ToString(dr["Roleid"]));
                        }
                        if (dr["Status"] != null && Convert.ToInt32(dr["Status"]) > 0)
                        {
                            c.Status = Convert.ToInt32(Convert.ToString(dr["Status"]));
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

                        userses.Add(c);

                    }
                    return userses;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
