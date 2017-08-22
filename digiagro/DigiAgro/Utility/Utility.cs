using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DigiAgro
{
    public class Utility
    {
        public void ClearForm(Control c)
        {
            if (c.Controls.Count <= 0)
                return;
            foreach (Control child in c.Controls)
            {
                if (child.GetType().Equals(typeof(TextBox)))
                {
                    ((TextBox)child).Text = string.Empty;
                }
                else
                {
                    ClearForm(child);
                }
            }
        }
    }
}