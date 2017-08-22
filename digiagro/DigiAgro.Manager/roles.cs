using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class roles
    {
        
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.roles bll_roles;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public roles()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_roles = new BLL.roles();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.roles obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_roles.Insert(obj, conn, trans);
                    Int32 roles = bll_utility.GetMaxId("roles", "Roleid", conn, trans);

                    trans.Commit();
                    conn.Close();
                    return roles;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.roles obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_roles.Update(obj, conn, trans);
                    
                    trans.Commit();
                    conn.Close();
                    return obj.Roleid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }

        public Int32 Delete(BOL.roles obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_roles.Delete(obj, conn, trans);

                    trans.Commit();
                    conn.Close();
                    return obj.Roleid;
                }
                catch
                {
                    trans.Rollback();
                    conn.Close();
                }
            }
            return 0;
        }
        public List<BOL.roles> Select(BOL.roles obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_roles.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.roles> roleses = new List<BOL.roles>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.roles c = new BOL.roles();

                        if (dr["Roleid"] != null && Convert.ToInt32(dr["Roleid"]) > 0)
                        {
                            c.Roleid = Convert.ToInt32(Convert.ToString(dr["Roleid"]));
                        }
                        if (dr["Description"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Rolename"] != null && !string.IsNullOrEmpty(Convert.ToString(dr["Rolename"])))
                        {
                            c.Rolename = Convert.ToString(dr["Rolename"]);
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
                        
                        roleses.Add(c);

                    }
                    return roleses;
                }

                return null;
            }
            return null;
        }

        public List<BOL.roles> Select(BOL.roles obj, SearchCriterias criteria)
        {
            if (obj != null)
            {
                DataSet ds = new DataSet();
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                if (criteria.GetHashCode() == SearchCriterias.multiple.GetHashCode())
                {
                    ds = bll_roles.Select(obj, conn, trans);
                }
                if (criteria.GetHashCode() == SearchCriterias.all.GetHashCode())
                {
                    ds = bll_roles.SelectAll(obj, conn, trans);
                }

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.roles> roles = new List<BOL.roles>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.roles c = new BOL.roles();

                        if (dr["Roleid"] != DBNull.Value && Convert.ToInt32(dr["Roleid"]) > 0)
                        {
                            c.Roleid = Convert.ToInt32(Convert.ToString(dr["Roleid"]));
                        }
                        if (dr["Rolename"] != DBNull.Value && !string.IsNullOrEmpty(Convert.ToString(dr["Rolename"])))
                        {
                            c.Rolename = Convert.ToString(dr["Rolename"]);
                        }
                        if (dr["Description"] != DBNull.Value && !string.IsNullOrEmpty(Convert.ToString(dr["Description"])))
                        {
                            c.Description = Convert.ToString(dr["Description"]);
                        }
                        if (dr["Createdby"] != DBNull.Value && Convert.ToInt32(dr["Createdby"]) > 0)
                        {
                            c.Createdby = Convert.ToInt32(Convert.ToString(dr["Createdby"]));
                        }
                        if (dr["Createdon"] != DBNull.Value && !string.IsNullOrEmpty(Convert.ToString(dr["Createdon"])))
                        {
                            c.Createdon = Convert.ToDateTime(Convert.ToString(dr["Createdon"]));
                        }
                        if (dr["Isdeleted"] != DBNull.Value && !string.IsNullOrEmpty(Convert.ToString(dr["Isdeleted"])))
                        {
                            c.Isdeleted = Convert.ToString(dr["Isdeleted"]);
                        }
                        if (dr["Modifiedby"] != DBNull.Value && Convert.ToInt32(dr["Modifiedby"]) > 0)
                        {
                            c.Modifiedby = Convert.ToInt32(Convert.ToString(dr["Modifiedby"]));
                        }
                        if (dr["Modifiedon"] != DBNull.Value && !string.IsNullOrEmpty(Convert.ToString(dr["Modifiedon"])))
                        {
                            c.Modifiedon = Convert.ToDateTime(Convert.ToString(dr["Modifiedon"]));
                        }

                        roles.Add(c);

                    }
                    return roles;
                }

                return null;
            }
            return null;
        }

        #endregion
    }
}
