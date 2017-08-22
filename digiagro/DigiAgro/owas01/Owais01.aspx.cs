using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.owas01
{
    public partial class Owais01 : System.Web.UI.Page
    {
        #region properties and variable

        Manager.Owais01Mgr mgrOwais01;
        BOL.Owais01BOL bolOwais01;
        Utility utility;
       
        #endregion

        #region methods and functions

        public void Initialize()
        {
            mgrOwais01 = new Owais01Mgr();
            bolOwais01 = new Owais01BOL();
            utility = new Utility();
           }
      
        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }     
        public Int32 Save()
        {
            bolOwais01 = new BOL.Owais01BOL();
            mgrOwais01 = new Manager.Owais01Mgr();
            bolOwais01.IdNumber = mgrOwais01.Insert(bolOwais01);
            bolOwais01.FirstName = txtfirstName.Text;
            bolOwais01.LastName = txtlastName.Text;
            bolOwais01.Email = txtEmail.Text;
            bolOwais01.ContactNum = mgrOwais01.Insert(bolOwais01);
            return bolOwais01.IdNumber;
        }


        #endregion

        #region event handlers

        protected void Page_Load(object sender, EventArgs e)
        {
         //   DataTable dt = FillGrid();
         //   dgvRoles.DataSource = dt;
         //   dgvRoles.DataBind();
            if (Session["userid"] != null && Convert.ToInt32(Session["userid"]) > 0)
            {
                if (!Page.IsPostBack)
                {
                    Initialize();
                    utility.ClearForm(tblmain);
                 //   LoadMethods();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


    }
}