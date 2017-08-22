using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DigiAgro.BLL;

namespace DigiAgro.Manager
{
    public static class Utility
    {
        public static string GetConnectionString()
        {
            string ConnectionString;

            if (System.Configuration.ConfigurationManager.ConnectionStrings["sample"] != null)
            {
                ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sample"].ConnectionString;
            }
            else
            {
                throw new Exception("connection string not defined");
            }

            return ConnectionString;
        }
    }
}
