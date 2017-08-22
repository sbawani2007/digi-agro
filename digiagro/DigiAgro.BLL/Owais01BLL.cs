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
   public class Owais01BLL
    {

        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.Owais01BOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"INSERT INTO `owais`(`idNumber`, `firstName`, `lastName`, `email`, `contactNum`) 
                                    VALUES ('"+c.IdNumber+"', '"+c.FirstName+"', '"+c.LastName+"', '"+c.Email+"', '"+c.ContactNum+"')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        //public Int32 Update(BOL.Owais01BOL c, MySqlConnection conn, MySqlTransaction trans)
        //{
        //    if (c != null)
        //    {
        //        try
        //        {
        //            string qry = @"";
        //            dbconnect.GetScalar(conn, trans, qry, null);
        //            return 1;
        //        }
        //        catch
        //        {
      
        //        }
        //    }
        //    return 0;
        //}
      
        //public Int32 Delete(BOL.Owais01BOL c, MySqlConnection conn, MySqlTransaction trans)
        //{
        //    if (c != null)
        //    {
        //        try
        //        {
        //            string qry = @"";
        //            dbconnect.ExecuteNonQuery(conn, trans, qry, null);
        //            return 1;
        //        }
        //        catch
        //        {
      
        //        }
        //    }
        //    return 0;
        //}
        //public DataSet Select(BOL.Owais01BOL c, MySqlConnection conn, MySqlTransaction trans)
        //{
        //    if (c != null)
        //    {
        //        StringBuilder qry = new System.Text.StringBuilder();
        //        qry.Append(@"SELECT `idNumber`, `firstName`, `lastName`, `email`, `contactNum`, FROM `owais`  ");
        //        if (c.IdNumber > 0)
        //        {
        //            qry.Append("`idNumber` = " + c.IdNumber + " AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.FirstName))
        //        {
        //            qry.Append("`firstName` = '" + c.FirstName + "' AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.LastName))
        //        {
        //            qry.Append("`lastName` = '" + c.LastName + "' AND");
        //        }
        //        if (!string.IsNullOrEmpty(c.Email))
        //        {
        //            qry.Append("`email` = '" + c.Email + "' AND");
        //        }
        //        if  (Convert.ToInt32(c.ContactNum) > 0)
        //        {
        //            qry.Append("`contactNum` = '" + c.ContactNum + "' AND");
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
