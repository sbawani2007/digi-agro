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
    public class hunaidBLL
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.customers c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"INSERT INTO `customers`( `firstname`, `lastname`, `status`, `email`, `mobile`, 
                                `createdby`, `createdon`, `isdeleted`, `modifyby`, `modifyon`) 
                                VALUES ('" + c.Firstname + "','" + c.Lastname + "'," + c.Status + ",'" + c.Email + "','" + c.Mobile +
                                               "'," + c.Createdby + ",STR_TO_DATE('" + c.Createdon + "', '%c/%e/%Y %r')" +
                                               ",'F','',STR_TO_DATE('" + c.Modifyon + "', '%c/%e/%Y %r'))";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                { 
                    
                }
            }
            return 0;
        }
        public Int32 Update(BOL.customers c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"UPDATE `customers` SET `firstname` ='" + c.Firstname + "',`lastname`='" + c.Lastname +
                      "',status`=" + c.Status + ",`email`='" + c.Email + "',`mobile`='" + c.Mobile + "',`createdby`=" + c.Createdby +
                      ",`createdon`= STR_TO_DATE('" + c.Createdon + "', '%c/%e/%Y %r'),`isdeleted`='" + c.Isdeleted + "',`modifyby`=" + c.Modifyby +
                      ",`modifyon`=STR_TO_DATE('" + c.Modifyon + "', '%c/%e/%Y %r') WHERE `customerid` =" + c.Customerid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.customers c,MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"DELETE FROM `customers` WHERE `customerid`= " +  c.Customerid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.customers c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `customerid`, `firstname`, `lastname`, `status`, `email`, 
                `mobile`, `createdby`, `createdon`, `isdeleted`, `modifyby`, `modifyon` FROM `customers` WHERE ");
                if (c.Customerid > 0)
                {
                    qry.Append("`customerid` = " + c.Customerid + " AND");
                }
                if (!string.IsNullOrEmpty(c.Firstname))
                {
                    qry.Append("`firstname` = '" + c.Firstname + "' AND");
                }
                if (!string.IsNullOrEmpty(c.Lastname))
                {
                    qry.Append("`Lastname` = '" + c.Lastname + "' AND");
                }
                if (!string.IsNullOrEmpty(c.Mobile))
                {
                    qry.Append("`Mobile` = '" + c.Mobile + "' AND");
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
        #endregion
    }
}
