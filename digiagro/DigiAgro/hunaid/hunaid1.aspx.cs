using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.hunaid
{
    public partial class hunaid1 : System.Web.UI.Page
    {

        #region properties and variable

        Manager.hunaidManager1 mgrhunaid;
        BOL.Hunaid1BOL bolhunaid;
        Utility utility;

        

        #endregion 

        #region methods and functions

        public void Initialize()
        {
            mgrhunaid = new hunaidManager1();
            bolhunaid = new Hunaid1BOL();
            utility = new Utility();
            
        }
      
        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }
        public Int32 Save()
        {
            bolhunaid.FirstName = txtFname.Text;
            bolhunaid.LastName = txtLname.Text;
            bolhunaid.CellNum = mgrhunaid.Insert(bolhunaid);
            bolhunaid.Email = txtEmail.Text;
            return bolhunaid.CellNum ;
        }


        #endregion

        #region event handlers

        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable dt = FillGrid();
            //dgvRoles.DataSource = dt;
            //dgvRoles.DataBind();
            if (Session["userid"] != null && Convert.ToInt32(Session["userid"]) > 0)
            {
                if (!Page.IsPostBack)
                {
                    Initialize();
                    utility.ClearForm(tblmain);
                    
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