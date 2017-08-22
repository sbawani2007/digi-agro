using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.Users
{
    public partial class NewUser : System.Web.UI.Page
    {

        #region properties and variable

        Manager.users manager_users;
        Manager.status manager_status;
        Manager.roles manager_roles;

        Utility utility;

        List<BOL.status> bol_statuses;
        List<BOL.roles> bol_roles;
        BOL.users bol_users;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_users = new Manager.users();
            manager_status = new Manager.status();

            manager_roles = new Manager.roles(); utility = new Utility();
            bol_statuses = new List<BOL.status>();

            bol_roles = new List<BOL.roles>(); bol_users = new BOL.users();

        }
        public void LoadMethods()
        {
            LoadStatus();

            LoadRoles();
        }

        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }
        public void LoadStatus()
        {
            bol_statuses = manager_status.Select(new BOL.status(), SearchCriterias.all);
            if (bol_statuses != null && bol_statuses.Count > 0)
            {
                ddlStatus.DataSource = bol_statuses;
                ddlStatus.DataTextField = "Statusname";
                ddlStatus.DataValueField = "Statusid";
                ddlStatus.DataBind();
                ddlStatus.Items.Insert(0, new ListItem("--Select--", "-1"));

            }
        }
        public void LoadRoles()
        {
            bol_roles = manager_roles.Select(new BOL.roles(), SearchCriterias.all);
            if (bol_roles != null && bol_roles.Count > 0)
            {
                ddlRoles.DataSource = bol_roles;
                ddlRoles.DataTextField = "Rolename";
                ddlRoles.DataValueField = "roleid";
                ddlRoles.DataBind();
                ddlRoles.Items.Insert(0, new ListItem("--Select--", "-1"));

            }
        }
        public Int32 Save()
        {
            bol_users = new BOL.users();
            manager_users = new Manager.users();
            bol_users.Firstname = txtFirstName.Text;
            bol_users.Lastname = txtLastName.Text;
            bol_users.Email = txtEmail.Text;
            bol_users.Mobile = txtMobile.Text;
            bol_users.Isdeleted = "F";
            bol_users.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            bol_users.Createdby = Convert.ToInt32(Session["userid"]);
            bol_users.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            bol_users.Username = txtUserName.Text;
            bol_users.Password = txtPassword.Text;
            bol_users.Roleid = Convert.ToInt32(ddlRoles.SelectedValue);
            bol_users.Userid = manager_users.Insert(bol_users);
            return bol_users.Userid;
        }


        #endregion

        #region event handlers

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

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            Save();
        }

        #endregion

    }
}