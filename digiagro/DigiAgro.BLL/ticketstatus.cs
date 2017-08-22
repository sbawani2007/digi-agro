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
    public class ticketstatus
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.ticketstatus obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `ticketstatus`(`ticketstatusname`, `description`, `isdeleted`, 
                                        `createdby`, `createdon`, `modifiedby`, `modifiedon`) 
                                        VALUES ('" + obj.Ticketstatusname + "','" + obj.Description + "','F'," + obj.Createdby + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')" +
                                               ",'','')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketstatus obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `ticketstatus` SET `ticketstatusname` = '" + obj.Ticketstatusname + "',`description`=" + obj.Description +
                      "',`isdeleted`='" + obj.Isdeleted + "',`createdby`=" + obj.Createdby + ",`createdon`=" + obj.Createdon + ",`modifiedby`=" + obj.Modifiedby +
                    ",`modifiedon` = " + obj.Modifiedon + "  WHERE `ticketstatusid`=" + obj.Ticketstatusid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketstatus obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `ticketstatus` WHERE `ticketstatusid`= " + obj.Ticketstatusid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.ticketstatus obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketstatusid`, `ticketstatusname`, `description`, `isdeleted`, `createdby`, `createdon`, 
                                `modifiedby`, `modifiedon` FROM `ticketstatus` WHERE ");
                if (obj.Ticketstatusid > 0)
                {
                    qry.Append("`ticketstatusid` = " + obj.Ticketstatusid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Ticketstatusname))
                {
                    qry.Append("`ticketstatusname` = '" + obj.Ticketstatusname + "' AND");
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
        public DataSet SelectAll(BOL.ticketstatus obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketstatusid`, `ticketstatusname`, `description`, `isdeleted`, `createdby`, `createdon`, 
                                `modifiedby`, `modifiedon` FROM `ticketstatus`");
               
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
