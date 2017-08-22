using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.Customer
{
    public partial class hunaid : System.Web.UI.Page
    {

        #region properties and variable

        Manager.hunaidManager manager_hunaidManager;
        Manager.customer_address manager_customer_address;
        Manager.status manager_status;
        Utility utility;

        List<BOL.status> bol_statuses;
        BOL.Hunaid1BOL bol_hunaidBOL;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            //manager_hunaidManager = new customer();
            //manager_customer_address = new Manager.customer_address();
            //manager_status = new Manager.status();
            //utility = new Utility();
            //bol_statuses = new List<BOL.status>();
            //bol_hunaidBOL = new customers();

        }
        public void LoadMethods()
        {
            LoadStatus();
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
        public Int32 Save()
        {
            //bol_hunaidBOL = new BOL.customers();
            //manager_hunaidManager = new Manager.customer();
            //bol_hunaidBOL.Firstname = txtFirstName.Text;
            //bol_hunaidBOL.Lastname = txtLastName.Text;
            //bol_hunaidBOL.Email = txtEmail.Text;
            //bol_hunaidBOL.Mobile = txtMobile.Text;
            //bol_hunaidBOL.Isdeleted = "F";
            //bol_hunaidBOL.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            //bol_hunaidBOL.Createdby = Convert.ToInt32(Session["userid"]);
            //bol_hunaidBOL.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            //bol_hunaidBOL.Customerid = manager_hunaidManager.Insert(bol_hunaidBOL);
            //return bol_hunaidBOL.Customerid;
            return 0;
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
                    LoadMethods();
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