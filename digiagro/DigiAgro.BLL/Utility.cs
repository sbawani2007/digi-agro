using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using DigiAgro.DAL;

namespace DigiAgro.BLL
{
    public class Utility
    {
        public Int32 GetCount(string tablename, MySqlConnection con, MySqlTransaction trans)
        {
            DBConnect dbConnect = new DBConnect();
            string query = "SELECT Count(*) FROM " + tablename;
            return dbConnect.Count(query, con, trans);
            
        }

        public Int32 GetMaxId(string tablename, string colname, MySqlConnection con, MySqlTransaction trans)
        {
            DBConnect dbConnect = new DBConnect();
            string query = "SELECT MAx(" + colname + ") FROM " + tablename;
            return dbConnect.Count(query, con, trans);

        }
    }
}
