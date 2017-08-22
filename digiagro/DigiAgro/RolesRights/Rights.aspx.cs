using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.RolesRights
{
    public partial class Rights : System.Web.UI.Page
    {

        #region properties and variable

        Manager.rolerights manager_rolerights;
        Utility utility;        
        BOL.rolerights bol_rolerights;
        Manager.roles manager_roles;
        List<BOL.roles> bol_roles;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_rolerights = new Manager.rolerights();
            utility = new Utility();
            bol_rolerights = new BOL.rolerights();
            manager_roles = new Manager.roles();
            bol_roles = new List<BOL.roles>();

        }
        public void LoadMethods()
        {
            LoadRoles();
        }

        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
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
        public Int32 Save(Int32 ticketstatusid)
        {
            bol_rolerights = new BOL.rolerights();
            manager_rolerights = new Manager.rolerights();
            bol_rolerights.Roleid = Convert.ToInt32(ddlRoles.SelectedValue);
            bol_rolerights.Ticketstatusid = ticketstatusid;
            bol_rolerights.Isdeleted = "F";
            bol_rolerights.Createdby = Convert.ToInt32(Session["userid"]);
            bol_rolerights.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            bol_rolerights.Rolerightsid = manager_rolerights.Insert(bol_rolerights);
            return bol_rolerights.Rolerightsid;
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
            foreach (GridViewRow row in dgvRoles.Rows)
            {
                if (((CheckBox)row.FindControl("cbSelect")).Checked)
                {
                    int ticketstatusid = Convert.ToInt32(dgvRoles.DataKeys[row.RowIndex].Value);
                    Save(ticketstatusid);
                }
            }
        }
    }
}