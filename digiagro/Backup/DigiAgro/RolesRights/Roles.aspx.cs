using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.RoleRights
{
    public partial class Roles : System.Web.UI.Page
    {

        #region properties and variable


        Manager.roles manager_roles;
        Utility utility;
        BOL.roles bol_roles;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_roles = new Manager.roles();
            utility = new Utility();
            bol_roles =new BOL.roles();
        }
        public void LoadMethods()
        {
            //LoadStatus();
        }

        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }
        //public void LoadStatus()
        //{
        //    bol_roles = manager_roles.Select(new BOL.status(), SearchCriterias.all);
        //    if (bol_roles != null && bol_roles.Count > 0)
        //    {
        //        ddlStatus.DataSource = bol_roles;
        //        ddlStatus.DataTextField = "Statusname";
        //        ddlStatus.DataValueField = "Statusid";
        //        ddlStatus.DataBind();
        //        ddlStatus.Items.Insert(0, new ListItem("--Select--", "-1"));

        //    }
        //}
        public Int32 Save()
        {
            bol_roles = new BOL.roles();
            manager_roles = new Manager.roles();
            bol_roles.Rolename = txtRoleName.Text;
            bol_roles.Description = txtRoleDiscription.Text;
            bol_roles.Isdeleted = "F";
            bol_roles.Createdby = Convert.ToInt32(Session["userid"]);
            bol_roles.Createdon = DateTime.Now;
            bol_roles.Modifiedby = Convert.ToInt32(Session["userid"]);
            bol_roles.Modifiedon = DateTime.Now;
            bol_roles.Roleid = manager_roles.Insert(bol_roles);
            return bol_roles.Roleid;
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