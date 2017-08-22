using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigiAgro.test_area
{
    public partial class shahid : System.Web.UI.Page
    {
        #region properties and variable

        Manager.customer manager_customer;
        Manager.customer_address manager_customer_address;
        Manager.status manager_status;
        Utility utility;

        List<BOL.status> bol_statuses;
        BOL.customers bol_customer;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            //manager_customer = new customer();
            //manager_customer_address = new Manager.customer_address();
            //manager_status = new Manager.status();
            //utility = new Utility();
            //bol_statuses = new List<BOL.status>();
            //bol_customer = new customers();

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
            //bol_statuses = manager_status.Select(new BOL.status(), SearchCriterias.all);
            //if (bol_statuses != null && bol_statuses.Count > 0)
            //{
            //    ddlStatus.DataSource = bol_statuses;
            //    ddlStatus.DataTextField = "Statusname";
            //    ddlStatus.DataValueField = "Statusid";
            //    ddlStatus.DataBind();
            //    ddlStatus.Items.Insert(0, new ListItem("--Select--", "-1"));

            //}
        }
        public Int32 Save()
        {
            //bol_customer = new BOL.customers();
            //manager_customer = new Manager.customer();
            //bol_customer.Firstname = txtFirstName.Text;
            //bol_customer.Lastname = txtLastName.Text;
            //bol_customer.Email = txtEmail.Text;
            //bol_customer.Mobile = txtMobile.Text;
            //bol_customer.Isdeleted = "F";
            //bol_customer.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            //bol_customer.Createdby = Convert.ToInt32(Session["userid"]);
            //bol_customer.Createdon = DateTime.Parse(System.DateTime.Now.ToString("dd/MMM/yyyy"));
            //bol_customer.Customerid = manager_customer.Insert(bol_customer);
            //return bol_customer.Customerid;
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
                    //LoadMethods();
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