using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class OwaisManager
    {
        #region properties and variables

        //DAL.DBConnect dbconnect = new DBConnect();
        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.OwaisBLL bll_objOwaisBLL;
        BLL.Utility bll_utility;
        #endregion

        #region methods

        public OwaisManager()
        {
            ConnectionString = Utility.GetConnectionString();
            bll_objOwaisBLL = new BLL.OwaisBLL();
            bll_utility = new BLL.Utility();
        }

        public Int32 Insert(BOL.OwaisBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objOwaisBLL.Insert(obj, conn, trans);
                    Int32 idNumber = bll_utility.GetMaxId("owais", "IdNumber", conn, trans);

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
        public Int32 Update(BOL.OwaisBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objOwaisBLL.Update(obj, conn, trans);

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

        public Int32 Delete(BOL.OwaisBOL obj)
        {
            if (obj != null)
            {
                try
                {
                    conn = new MySqlConnection(ConnectionString);
                    conn.Open();
                    trans = conn.BeginTransaction();

                    bll_objOwaisBLL.Delete(obj, conn, trans);

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
        public List<BOL.OwaisBOL> Select(BOL.OwaisBOL obj)
        {
            if (obj != null)
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                DataSet ds = bll_objOwaisBLL.Select(obj, conn, trans);

                trans.Commit();
                conn.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    List<BOL.OwaisBOL> owais = new List<BOL.OwaisBOL>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BOL.OwaisBOL c = new BOL.OwaisBOL();

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

                        owais.Add(c);

                    }
                    return owais;
                }

                return null;
            }
            return null;
        }
        #endregion
    }
}
