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
    public class ticketattachment
    {

        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.ticketattachment obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `ticketattachment`(`ticketid`, `link`, `isdeleted`) 
                                    VALUES (" + obj.Ticketid + ",'" + obj.Link + "','F')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.ticketattachment obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `ticketattachment` SET `ticketid` = " + obj.Ticketid + ",`link`='" + obj.Link +
                      "',isdeleted`='" + obj.Isdeleted + "'  WHERE `ticketattachmentid` = " + obj.Ticketattachmentid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.ticketattachment obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `ticketattachment` WHERE `ticketattachmentid`= " + obj.Ticketattachmentid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.ticketattachment obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT tatt.ticketattachmentid, tatt.ticketid, tatt.link, tatt.isdeleted, c.mobile AS customermobile
                            FROM ticketattachment tatt
                            INNER JOIN tickets t ON t.ticketid = tatt.ticketid
                            INNER JOIN customers c ON c.customerid = t.customerid
                            WHERE  ");
                if (obj.Ticketattachmentid > 0)
                {
                    qry.Append("tatt.ticketattachmentid = " + obj.Ticketattachmentid + " AND");
                }
                if (obj.Ticketid > 0)
                {
                    qry.Append("tatt.ticketid = " + obj.Ticketid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Link))
                {
                    qry.Append("tatt.link = '" + obj.Link + "' AND");
                }                
                qry = qry.Remove(qry.Length - 3, 3);
                return dbconnect.GetDataset(conn, trans, qry.ToString());
            }
            return null;
        }
        #endregion
    }
}
