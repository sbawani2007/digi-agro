using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.owais
{
    public partial class owais : System.Web.UI.Page
    {

        #region properties and variable

        Manager.OwaisManager manager_OwaisManager;
        Manager.customer_address manager_customer_address;
        Manager.status manager_status;
        Utility utility;

        List<BOL.status> bol_statuses;
        BOL.OwaisBOL bol_OwaisBOL;


        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_OwaisManager = new OwaisManager();
            //manager_customer_address = new Manager.customer_address();
            manager_status = new Manager.status();
            utility = new Utility();
            bol_statuses = new List<BOL.status>();
            bol_OwaisBOL = new OwaisBOL();

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
            //bol_OwaisBOL = new BOL.OwaisBOL();
            //manager_OwaisManager = new Manager.OwaisManager();
            //bol_OwaisBOL.FirstName = txtFirstName.Text;
            //bol_OwaisBOL.LastName = txtLastName.Text;
            //bol_OwaisBOL.Email = txtEmail.Text;
            //return bol_OwaisBOL.IdNumber;
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
                    //Initialize();
                    //utility.ClearForm(tblmain);
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