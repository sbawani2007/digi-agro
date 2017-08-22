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
    public class hunaid1BLL
    {
        #region properties and variables

        DAL.DBConnect dbconnect = new DBConnect();

        #endregion

        #region methods

        public Int32 Insert(BOL.Hunaid1BOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"INSERT INTO `hunaid`(`fisrtName`, `lastName`, `cellNum`, `email`) 
                                    VALUES (" + c.FirstName + "," + c.LastName + "," + c.CellNum + "," + c.Email + ")";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public Int32 Update(BOL.Hunaid1BOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"UPDATE `hunaid` SET `fisrtName`=" + c.FirstName + ",`lastName`=" + c.LastName + ",`cellNum`=" + c.CellNum + ",`email`=" + c.Email + " WHERE 1";
                    dbconnect.GetScalar(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }

        public Int32 Delete(BOL.Hunaid1BOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                try
                {
                    string qry = @"DELETE FROM `hunaid` WHERE `firstName`= " + c.FirstName;
                    dbconnect.ExecuteNonQuery(conn, trans, qry, null);
                    return 1;
                }
                catch
                {

                }
            }
            return 0;
        }
        public DataSet Select(BOL.Hunaid1BOL c, MySqlConnection conn, MySqlTransaction trans)
        {
            if (c != null)
            {
                StringBuilder qry = new System.Text.StringBuilder();
                qry.Append(@"SELECT `id`, `fisrtName`, `lastName`, `cellNum`, `email` FROM `hunaid` ");
                if (c.Id > 0)
                {
                    qry.Append("`id` = " + c.Id+ " AND");
                }
                if (!string.IsNullOrEmpty(c.FirstName))
                {
                    qry.Append("`firstName` = '" + c.FirstName + "' AND");
                }
                if (!string.IsNullOrEmpty(c.LastName))
                {
                    qry.Append("`lastName` = '" + c.LastName + "' AND");
                }
                if (Convert.ToInt32(c.CellNum) > 0)
                {
                    qry.Append("`cellNum` = '" + c.CellNum + "' AND");
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

