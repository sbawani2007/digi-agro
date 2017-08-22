using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.Admin
{
    public partial class Status : System.Web.UI.Page
    {

        #region properties and variable

        Manager.status manager_status;
        Utility utility;
        BOL.status bol_status;
        //Manager.roles manager_roles;
        //List<BOL.roles> bol_roles;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_status = new Manager.status();
            utility = new Utility();
            bol_status = new BOL.status();
            //manager_roles = new Manager.roles();
            //bol_roles = new List<BOL.roles>();

        }
        public void LoadMethods()
        {
            //LoadRoles();
        }

        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }
        //public void LoadRoles()
        //{
        //    bol_roles = manager_roles.Select(new BOL.roles(), SearchCriterias.all);
        //    if (bol_roles != null && bol_roles.Count > 0)
        //    {
        //        ddlRoles.DataSource = bol_roles;
        //        ddlRoles.DataTextField = "Rolename";
        //        ddlRoles.DataValueField = "roleid";
        //        ddlRoles.DataBind();
        //        ddlRoles.Items.Insert(0, new ListItem("--Select--", "-1"));

        //    }
        //}
        public Int32 Save()
        {
            bol_status = new BOL.status();
            manager_status = new Manager.status();
            bol_status.Statusname = txtStatusName.Text;
            bol_status.Isdeleted = "F";
            bol_status.Createdby = Convert.ToInt32(Session["userid"]);
            bol_status.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            bol_status.Statusid = manager_status.Insert(bol_status);
            return bol_status.Statusid;
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null && Convert.ToInt32(Session["userid"]) > 0)
            {
                if (!Page.IsPostBack)
                {
                    Initialize();
                    utility.ClearForm(tblmain);
                    LoadMethods();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}