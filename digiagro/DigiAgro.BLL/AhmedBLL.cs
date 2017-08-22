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
    public class AhmedBLL
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.AhmedBOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"INSERT INTO `form`( `testName`, `testEmail`, `testLastName`) VALUES ('" + c.TestName + "','" + c.TestEmail + "','" + c.TestLastName + "')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.AhmedBOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"UPDATE `form` SET `testName`='" + c.TestName + "',`testEmail`='" + c.TestEmail + "',`testLastName`='" + c.TestLastName + "' WHERE 1";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.AhmedBOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"DELETE FROM `form` WHERE 1";
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        //public DataSet Select(BOL.AhmedBOL c, MySqlConnection conn, MySqlTransaction trans)
        //{
        //    if (c != null)
        //    {
        //        StringBuilder qry = new System.Text.StringBuilder();
        //        qry.Append(@"SELECT `customerid`, `firstname`, `lastname`, `status`, `email`, 
        //        `mobile`, `createdby`, `createdon`, `isdeleted`, `modifyby`, `modifyon` FROM `customers` WHERE ");
        //        if (c.Customerid > 0)
        //        {
        //            qry.Append("`customerid` = " + c.Customerid + " AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.Firstname))
        //        {
        //            qry.Append("`firstname` = '" + c.Firstname + "' AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.Lastname))
        //        {
        //            qry.Append("`Lastname` = '" + c.Lastname + "' AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.Mobile))
        //        {
        //            qry.Append("`Mobile` = '" + c.Mobile + "' AND");
        //        }
        //        else
        //        {
        //            qry.Append(" 1 AND");
        //        }
        //        qry = qry.Remove(qry.Length - 3, 3);
        //        return dbconnect.GetDataset(conn, trans, qry.ToString());

        //    }
        //    return null;
        //}
        #endregion
    }
}
