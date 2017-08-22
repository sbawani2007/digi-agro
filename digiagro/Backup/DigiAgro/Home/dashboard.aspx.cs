using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DigiAgro.BOL;
using DigiAgro.Manager;

namespace DigiAgro.Home
{
    public partial class dashboard : System.Web.UI.Page
    {

        #region properties and variable
        
        BOL.ticketattachment bol_ticketattach;
        BOL.tickets bol_ticket;
        BOL.customers bol_customer;
        List<BOL.tickets> bol_ticketses;

        List<BOL.customers> bol_customerses;
        Manager.dashboard manager_dashboard;

        #endregion

        #region methods and functions

        public void Initialize()
        {
            bol_ticket = new BOL.tickets();
            bol_customer = new BOL.customers();
            bol_ticketattach = new BOL.ticketattachment();
            bol_ticketses = new List<BOL.tickets>();
            bol_customerses = new List<BOL.customers>();

        }

        public void LoadUserOpenTickets()
        {
            manager_dashboard = new Manager.dashboard();
            bol_ticket = new BOL.tickets();
            bol_ticket.Ticketstatusid = Manager.TicketStatusEnum.Open.GetHashCode();
            bol_ticket.Userid = Convert.ToInt32(Session["userid"]);
            bol_ticketses = manager_dashboard.TicketsbyUserid(bol_ticket);
            if (bol_ticketses != null && bol_ticketses.Count > 0)
            {
                grdOpenTickets.DataSource = bol_ticketses;
                grdOpenTickets.DataBind();
            }
        }
        public void LoadUserAnonymousTickets()
        {
            manager_dashboard = new Manager.dashboard();
            bol_ticket = new BOL.tickets();
            bol_ticket.Ticketstatusid = Manager.TicketStatusEnum.Anonymous.GetHashCode();
            bol_ticket.Userid = Convert.ToInt32(Session["userid"]);
            bol_ticketses = manager_dashboard.TicketsbyUserid(bol_ticket);
            if (bol_ticketses != null && bol_ticketses.Count > 0)
            {
                grdAnonymousTickets.DataSource = bol_ticketses;
                grdAnonymousTickets.DataBind();
            }
        }
        #endregion

        #region event handler

        protected void grdOpen_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null && Convert.ToInt32(Session["userid"]) > 0)
            {
                if (!Page.IsPostBack)
                {
                    LoadUserOpenTickets();
                    LoadUserAnonymousTickets();
                }
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}