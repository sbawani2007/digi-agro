using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiAgro.DAL;
using DigiAgro.BOL;
using MySql.Data.MySqlClient;
using System.Data;


namespace DigiAgro.BLL
{
    public class roles
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.roles obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `roles`(`rolename`, `description`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon`) 
                                    VALUES ('" + obj.Rolename + "','" + obj.Description + "','F'," + obj.Createdby + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')" + "," + obj.Modifiedby + @",
                    STR_TO_DATE('" + obj.Modifiedon + "', '%c/%e/%Y %r'))";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.roles obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `roles` SET `rolename`='" + obj.Rolename + "',`description`='" + obj.Description +
                      "',`isdeleted`=' " + obj.Isdeleted + "',`createdby`= " + obj.Createdby + ",`createdon`= " + obj.Createdon + ",`modifiedby`=" + obj.Modifiedby +
                      ",`modifiedon`= " + obj.Modifiedon + "  WHERE `roleid`= " + obj.Roleid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.roles obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `roles` WHERE `roleid`= " + obj.Roleid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.roles obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `roleid`, `rolename`, `description`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `roles` WHERE ");
                if (obj.Roleid > 0)
                {
                    qry.Append("`roleid` = " + obj.Roleid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Rolename))
                {
                    qry.Append("`rolename` = '" + obj.Rolename + "' AND");
                }
                if (!string.IsNullOrEmpty(obj.Description))
                {
                    qry.Append("`description` = '" + obj.Description + "' AND");
                }
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        public DataSet SelectAll(BOL.roles obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `roleid`, `rolename`, `description`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `roles` ");

                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
