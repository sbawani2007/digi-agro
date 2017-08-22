using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.test_area
{
    public partial class Ahmed : System.Web.UI.Page
    {

        #region properties and variable

        Manager.AhmedManager mgrAhmed;
        BOL.AhmedBOL bolAhmed;
        Utility utility;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            mgrAhmed = new AhmedManager();
            bolAhmed = new AhmedBOL();
            utility = new Utility();
        }


        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }

        public Int32 Save()
        {
            Initialize();
            bolAhmed.TestEmail = txtTestEmail.Text;
            bolAhmed.TestName = txtTestName.Text;
            bolAhmed.TestLastName = txtTestLastName.Text;
            bolAhmed.TestID = mgrAhmed.Insert(bolAhmed);
            return bolAhmed.TestID;
        }


        #endregion

        #region event handlers

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Initialize();
                utility.ClearForm(tblmain);
                //  LoadMethods();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion

    }
}