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
    public class tickets
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.tickets obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `tickets`(`title`, `description`, `ticketstatusid`, `userid`, `customerid`, `isdeleted`
                                        , `createdby`, `createdon`, `modifiedby`, `modifiedon`) 
                                        VALUES ('" + obj.Title + "','" + obj.Description + "'," + obj.Ticketstatusid + "," + obj.Userid + "," + obj.Customerid +
                                               ",'F'," + obj.Createdby + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')," +
                                               obj.Modifiedby + ",STR_TO_DATE('" + obj.Modifiedon + "', '%c/%e/%Y %r'))";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.tickets obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `tickets` SET `title` = '" + obj.Title + "',`description`='" + obj.Description +
                      "',`ticketstatusid`=" + obj.Ticketstatusid + ",`userid`=" +
                      obj.Userid + ",`customerid`=" + obj.Customerid +
                      ",`isdeleted`='" + obj.Isdeleted + "',`createdby`=" + obj.Createdby +
                      ",`createdon`=STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r'),`modifiedby`=" + obj.Modifiedby +
                    ",`modifiedon` = STR_TO_DATE('" + obj.Modifiedon + "', '%c/%e/%Y %r')  WHERE `ticketid`=" + obj.Ticketid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.tickets obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `tickets` WHERE `ticketid`= " + obj.Ticketid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.tickets obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketid`, `title`, `description`, `ticketstatusid`, `userid`, `customerid`, `isdeleted`,
                                `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `tickets` WHERE ");
                if (obj.Ticketid > 0)
                {
                    qry.Append("`ticketid` = " + obj.Ticketid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Title))
                {
                    qry.Append("`title` = '" + obj.Title + "' AND");
                }
                if (!string.IsNullOrEmpty(obj.Description))
                {
                    qry.Append("`description` = '" + obj.Description + "' AND");
                }
                if (obj.Ticketstatusid > 0)
                {
                    qry.Append("`ticketstatusid` = " + obj.Ticketstatusid + " AND");
                } 
                if (obj.Userid > 0)
                {
                    qry.Append("`userid` = " + obj.Userid + " AND");
                }
                if (obj.Customerid > 0)
                {
                    qry.Append("`customerid` = " + obj.Customerid + " AND");
                }
                else
                {
                    qry.Append(" 1 AND");
                }
                qry = qry.Remove(qry.Length - 3, 3);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }

        public DataSet GetTicketsByStatus(string ticketStatuses, MySqlConnection conn, MySqlTransaction trans)
        {
            if (!string.IsNullOrEmpty(ticketStatuses))
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketid`, `title`, `description`, `ticketstatusid`, `userid`, `customerid`, `isdeleted`,
                                `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `tickets` WHERE `ticketstatusid` in (" + ticketStatuses + ")");
               
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        public DataSet GetTicketsByStatus(string ticketStatuses,BOL.tickets obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (!string.IsNullOrEmpty(ticketStatuses))
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketid`, `title`, `description`, `ticketstatusid`, `userid`, `customerid`, `isdeleted`,
                                `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `tickets` WHERE `ticketstatusid` in (" + ticketStatuses + ") AND");
                if (obj != null)
                {
                    if (obj.Ticketid > 0)
                    {
                        qry.Append("`ticketid` = " + obj.Ticketid + " AND");
                    }
                    if (!string.IsNullOrEmpty(obj.Title))
                    {
                        qry.Append("`title` = '" + obj.Title + "' AND");
                    }
                    if (!string.IsNullOrEmpty(obj.Description))
                    {
                        qry.Append("`description` = '" + obj.Description + "' AND");
                    }
                    if (obj.Ticketstatusid > 0)
                    {
                        qry.Append("`ticketstatusid` = " + obj.Ticketstatusid + " AND");
                    }
                    if (obj.Userid > 0)
                    {
                        qry.Append("`userid` = " + obj.Userid + " AND");
                    }
                    if (obj.Customerid > 0)
                    {
                        qry.Append("`customerid` = " + obj.Customerid + " AND");
                    }                    
                }
                qry = qry.Remove(qry.Length - 3, 3);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }

        #endregion
    }
}
