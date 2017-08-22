using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.Tickets
{
    public partial class TicketStatus : System.Web.UI.Page
    {

        #region properties and variable

        Manager.ticketstatus manager_ticketstatus;
        Utility utility;
        BOL.ticketstatus bol_ticketstatus;
        //Manager.roles manager_roles;
        //List<BOL.roles> bol_roles;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_ticketstatus = new Manager.ticketstatus();
            utility = new Utility();
            bol_ticketstatus = new BOL.ticketstatus();
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
            bol_ticketstatus = new BOL.ticketstatus();
            manager_ticketstatus = new Manager.ticketstatus();
            bol_ticketstatus.Ticketstatusname = txtStatusName.Text;
            bol_ticketstatus.Description = txtStatusDiscription.Text;
            bol_ticketstatus.Isdeleted = "F";
            bol_ticketstatus.Createdby = Convert.ToInt32(Session["userid"]);
            bol_ticketstatus.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            bol_ticketstatus.Ticketstatusid = manager_ticketstatus.Insert(bol_ticketstatus);
            return bol_ticketstatus.Ticketstatusid;
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