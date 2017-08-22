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
    public class tickethistory
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.tickethistory obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `tickethistory`(`ticketid`, `userid`, `ticketstatusid`, `Createdon`) VALUES
                                    (" + obj.Ticketid + "," + obj.Userid + "," + obj.Ticketstatusid + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r'))";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.tickethistory obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `tickethistory` SET `ticketid` = " + obj.Ticketid + ",`userid` = " + obj.Userid +
                      ",ticketstatusid` = " + obj.Ticketstatusid + "  WHERE `tickethistoryid` = " + obj.Tickethistoryid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.tickethistory obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `tickethistory` WHERE `tickethistoryid`= " + obj.Tickethistoryid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.tickethistory obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `tickethistoryid`, `ticketid`, `userid`, `ticketstatusid`,`createdon` FROM `tickethistory` WHERE ");
                if (obj.Tickethistoryid > 0)
                {
                    qry.Append("`tickethistoryid` = " + obj.Tickethistoryid + " AND");
                }
                if (obj.Ticketid> 0)
                {
                    qry.Append("`ticketid` = " + obj.Ticketid + " AND");
                }
                if (obj.Userid > 0)
                {
                    qry.Append("`userid` = " + obj.Userid + " AND");
                }
                if (obj.Ticketstatusid > 0)
                {
                    qry.Append("`ticketstatusid` = " + obj.Ticketstatusid + " AND");
                }
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
