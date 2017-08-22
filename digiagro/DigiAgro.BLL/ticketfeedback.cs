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
    public class ticketfeedback
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.ticketfeedback obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `ticketfeedback`(`ticketid`, `userid`, `feedback`, `isdeleted`, `Createdon`) 
                                    VALUES (" + obj.Ticketid + "," + obj.Userid + ",'" + obj.Feedback + "','F',STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r'))";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketfeedback obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `ticketfeedback` SET `ticketid`= " + obj.Ticketid + ",`userid`=" + obj.Userid +
                      ",feedback`=" + obj.Feedback + ",`isdeleted` = '" + obj.Isdeleted + "'  WHERE `ticketfeedbackid`= " + obj.Ticketfeedbackid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketfeedback obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `ticketfeedback` WHERE `ticketfeedbackid`= " + obj.Ticketfeedbackid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.ticketfeedback obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `ticketfeedbackid`, `ticketid`, `userid`, `feedback`, `isdeleted`,`createdon` FROM `ticketfeedback` WHERE ");
                if (obj.Ticketfeedbackid > 0)
                {
                    qry.Append("`ticketfeedbackid` = " + obj.Ticketfeedbackid + " AND");
                }
                if (obj.Ticketid > 0)
                {
                    qry.Append("`ticketid` = " + obj.Ticketid + " AND");
                }
                if (obj.Userid> 0)
                {
                    qry.Append("`userid` = " + obj.Userid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Feedback))
                {
                    qry.Append("`feedback` = '" + obj.Feedback + "' AND");
                }
                qry = qry.Remove(qry.Length - 3, 3);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }

        public DataSet GetAllFeedbacksByTicket(BOL.ticketfeedback obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@" SELECT fb.ticketfeedbackid, fb.ticketid, fb.userid, fb.createdon, fb.feedback, fb.isdeleted,
                                u.username, c.mobile AS customermobile
                                FROM ticketfeedback fb
                                INNER JOIN users u ON u.userid = fb.userid
                                INNER JOIN tickets t ON t.ticketid = fb.ticketid
                                INNER JOIN customers c ON c.customerid = t.customerid
                                WHERE ");
                if (obj.Ticketfeedbackid > 0)
                {
                    qry.Append("fb.ticketfeedbackid = " + obj.Ticketfeedbackid + " AND");
                }
                if (obj.Ticketid > 0)
                {
                    qry.Append("fb.ticketid = " + obj.Ticketid + " AND");
                }
                if (obj.Userid > 0)
                {
                    qry.Append("fb.userid = " + obj.Userid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Feedback))
                {
                    qry.Append("fb.feedback = '" + obj.Feedback + "' AND");
                }
                qry = qry.Remove(qry.Length - 3, 3);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }


         #endregion
    }
}
