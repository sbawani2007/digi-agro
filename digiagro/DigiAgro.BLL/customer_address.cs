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
    public class customer_address
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.customer_address obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `customer_address`(`customerid`, `house`, `street`, `area`, `city`, `country`) 
                                        VALUES (" + obj.Customerid + ",'" + obj.House + "','" + obj.Street + "','" + obj.Area + "'," + obj.City +
                                               "," + obj.Country + ")";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.customer_address obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `customer_address` SET `customerid` = " + obj.Customerid + ",`house` = '" + obj.House +
                      "','street' = '" + obj.Street + "',`area`='" + obj.Area + "',city`=" + obj.City + ",`country` = " + obj.Country +
                            " WHERE `custaddressid`=" + obj.Custaddressid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.customer_address obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `customer_address` WHERE `custaddressid`= " + obj.Custaddressid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.customer_address obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `custaddressid`, `customerid`, `house`, `street`, `area`, `city`, `country` FROM `customer_address` WHERE ");
                if (obj.Custaddressid > 0)
                {
                    qry.Append("`custaddressid` = " + obj.Custaddressid + " AND");
                }
                if (obj.Customerid > 0)
                {
                    qry.Append("`customerid` = " + obj.Customerid + " AND");
                }                
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
