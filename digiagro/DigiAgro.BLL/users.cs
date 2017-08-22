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
    public class users
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.users obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"INSERT INTO `users`(`firstname`, `lastname`, `roleid`, `status`, `username`, `password`, `email`, 
                                        `mobile`, `createdby`, `createdon`, `modifyby`, `modifyon`, `isdeleted`) 
                                   VALUES ('" + obj.Firstname + "','" + obj.Lastname + "'," + obj.Roleid + "," + obj.Status + ",'" + obj.Username +
                                              "','" + obj.Password + "','" + obj.Email + "','" + obj.Mobile + "'," + obj.Createdby + "," + "STR_TO_DATE('" + obj.Createdon + "', '%c/%e/%Y %r')" +
                                              "," + obj.Modifyby + ",STR_TO_DATE('" + obj.Modifyon + "', '%c/%e/%Y %r'),'F')";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {
                    throw new Exception();
                }
            }
            return 0;
        }
        public Int32 Update(BOL.users obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"UPDATE `users` SET `firstname` = '" + obj.Firstname + "',`lastname` = '" + obj.Lastname + "',roleid` = " + obj.Roleid +
                      ",'status' = " + obj.Status + ",'username' = " + obj.Username + ",'password'= " + obj.Password + ",`email`='" + obj.Email + "',mbile` = '" + obj.Mobile + "'`createdby` = " + obj.Createdby +
                      ",`createdon` = " + obj.Createdon + ",`isdeleted` = '" + obj.Isdeleted + "',`modifyby` = " + obj.Modifyby + ",`modifyon` =" +
                        obj.Modifyon + "  WHERE `userid`=" + obj.Userid;
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.users obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                try
                {
                    string qry = @"DELETE FROM `users` WHERE `userid`= " + obj.Userid;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.users obj, MySqlConnection conn, MySqlTransaction trans)
        {
            if (obj != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `userid`, `firstname`, `lastname`, `roleid`, `status`, `username`, `password`, `email`, `mobile`, 
                                                    `createdby`, `createdon`, `modifyby`, `modifyon`, `isdeleted` FROM `users` WHERE ");
                if (obj.Userid > 0)
                {
                    qry.Append("`userid` = " + obj.Userid + " AND");
                }
                if (!string.IsNullOrEmpty(obj.Firstname))
                {
                    qry.Append("`firstname` = '" + obj.Firstname + "' AND");
                }
                if (!string.IsNullOrEmpty(obj.Lastname))
                {
                    qry.Append("`Lastname` = '" + obj.Lastname + "' AND");
                }
                if (!string.IsNullOrEmpty(obj.Mobile))
                {
                    qry.Append("`Mobile` = '" + obj.Mobile + "' AND");
                }
                qry = qry.Remove(qry.Length - 3, qry.Length);
                return dbconnect.GetDataset(conn, trans, qry.ToString());

            }
            return null;
        }
        #endregion
    }
}
