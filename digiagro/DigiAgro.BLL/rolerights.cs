using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiAgro.DAL;
using DigiAgro.BOL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace DigiAgro.BLL
{
    public class rolerights
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.rolerights obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `rolerights`(`ticketstatusid`, `roleid`, `isdeleted`,`createdby`, `createdon`, `modifyby`, `modifyon`) 
                                 VALUES (" + obj.Ticketstatusid + "," + obj.Roleid + ",'F'," + obj.Createdby + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')" + ",'F','','')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.rolerights obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `rolerights` SET `ticketstatusid` = " + obj.Ticketstatusid + ",`roleid`=" + obj.Roleid +
                      ",`isdeleted`='" + obj.Isdeleted + "',`createdby`=" + obj.Createdby + ",`createdon`=" + obj.Createdon + ",`modifyby`=" + obj.Modifyby +
                      ",`modifyon` = " + obj.Modifyon + " WHERE `rolerightsid`=" + obj.Rolerightsid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.rolerights obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `rolerights` WHERE `rolerightsid` = " + obj.Rolerightsid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.rolerights obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `rolerightsid`, `ticketstatusid`, `roleid`, `isdeleted`, `createdby`, `createdon`, `modifyby`, 
                            `modifyon` FROM `rolerights` WHERE ");
                if (obj.Rolerightsid > 0)
                {
                    qry.Append("`rolerightsid` = " + obj.Rolerightsid + " AND");
                }
                if (obj.Ticketstatusid >0)
                {
                    qry.Append("`ticketstatusid` = " + obj.Ticketstatusid + " AND");
                }
                if (obj.Roleid > 0)
                {
                    qry.Append("`roleid` = " + obj.Roleid + " AND");
                }
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
