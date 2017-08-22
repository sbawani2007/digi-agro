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
    public class status
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.status obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `status`(`statusname`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon`) 
                                    VALUES ('" + obj.Statusname + "','F'," + obj.Createdby + ",STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')" + ",'','')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.status obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `status` SET `statusname` = '" + obj.Statusname + "',`isdeleted` = '" + obj.Isdeleted + 
                                 "',`createdby`= " + obj.Createdby + ",`createdon`= " + obj.Createdon + ",`modifiedby` =" + obj.Modifiedby +
                                ",`modifiedon`= " + obj.Modifiedon + "  WHERE `statusid`= " + obj.Statusid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.status obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `status` WHERE `statusid`= " + obj.Statusid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.status obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `statusid`, `statusname`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `status` WHERE ");
                if (obj.Statusid > 0)
                {
                    qry.Append("`customerid` = " + obj.Statusid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Statusname))
                {
                    qry.Append("`statusname` = '" + obj.Statusname + "' AND");
                }                
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }

        public DataSet SelectAll(BOL.status obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `statusid`, `statusname`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon` FROM `status` ");
                
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion

    }
}
