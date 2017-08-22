using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

//namespace DigiAgro.test_area
//{
//    public partial class tariq : System.Web.UI.Page
//    {

//        #region properties and variable

//        Manager.TariqManager mgrTariq;
//        BOL.TariqBOL bolTariq;
//        Utility utility;


//        #endregion

//        #region methods and functions

//        public void Initialize()
//        {
//            mgrTariq = new TariqManager();
//            bolTariq = new TariqBOL();
//            utility = new Utility();
//        }


//        public void ClearForm(Control c)
//        {
//            utility.ClearForm(c);
//        }

//        public Int32 Save()
//        {
//            Initialize();
//            bolTariq.TestEmail = txtTestEmail.Text;
//            bolTariq.TestName = txtTestName.Text;
//            bolTariq.TestLastName = txtTestLastName.Text;
//            bolTariq.TestID = mgrTariq.Insert(bolTariq);
//             return bolTariq.TestID;
//        }


//        #endregion

//        #region event handlers

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!Page.IsPostBack)
//            {
//                Initialize();
//                utility.ClearForm(tblmain);
//                //  LoadMethods();
//            }
//        }

//        protected void btnSave_Click(object sender, EventArgs e)
//        {
//            Save();
//        }

//        #endregion

//    }
//}