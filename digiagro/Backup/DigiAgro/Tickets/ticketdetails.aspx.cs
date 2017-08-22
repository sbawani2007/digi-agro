using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DigiAgro.Tickets
{
    public partial class ticketdetails : System.Web.UI.Page
    {
        #region properties and variable

        Manager.ticketstatus manager_ticketstatus;
        Manager.tickets manager_tickets;
        Manager.ticketfeedback manager_ticketfeedback;
        Manager.ticketattachment manager_ticketattachment;
        Manager.customer manager_customer;
        Utility utility;
        BOL.ticketstatus bol_ticketstatus;
        BOL.tickets bol_tickets;
        BOL.ticketfeedback bol_ticketfeedback;
        BOL.ticketattachment bol_ticketattachment;
        BOL.customers bol_customers;
        
        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_ticketstatus = new Manager.ticketstatus();
            utility = new Utility();
            bol_ticketstatus = new BOL.ticketstatus();
            
        }
        public void LoadMethods()
        {
            LoadTicketStatuses();
            LoadTicket();
        }

        public void LoadTicket()
        {
            if (Request.QueryString["id"] != null && Convert.ToInt32(Convert.ToString(Request.QueryString["id"])) > 0)
            {
                manager_tickets = new Manager.tickets();
                manager_ticketfeedback = new Manager.ticketfeedback();
                manager_ticketattachment = new Manager.ticketattachment();
                
                bol_tickets = new BOL.tickets();
                bol_ticketfeedback = new BOL.ticketfeedback();
                bol_ticketattachment = new BOL.ticketattachment();
                
                bol_tickets.Ticketid = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));                
                List<BOL.tickets> _ticketses = manager_tickets.Select(bol_tickets);
                if (_ticketses != null && _ticketses.Count > 0 && _ticketses[0].Ticketid > 0)
                {
                    txtTickettitle.Text = _ticketses[0].Title;
                    txtTicketDescription.Text = _ticketses[0].Description;
                    ddlTicketStatus.SelectedValue = _ticketses[0].Ticketstatusid.ToString();


                    bol_ticketfeedback.Ticketid = _ticketses[0].Ticketid;
                    bol_ticketattachment.Ticketid = _ticketses[0].Ticketid;                    
                    
                    _ticketses[0].Ticketfeedbacks = manager_ticketfeedback.GetAllFeedbacksByTicket(bol_ticketfeedback);
                    _ticketses[0].Ticketattachments = manager_ticketattachment.Select(bol_ticketattachment);

                    if (_ticketses[0].Ticketfeedbacks != null && _ticketses[0].Ticketfeedbacks.Count > 0)
                    {
                        _ticketses[0].Ticketfeedbacks.OrderByDescending(t => t.Ticketfeedbackid);
                        txtfeedback.Text = _ticketses[0].Ticketfeedbacks[0].Feedback;

                        repFeedbackHistory.DataSource = _ticketses[0].Ticketfeedbacks.OrderByDescending(t => t.Ticketfeedbackid);
                        repFeedbackHistory.DataBind();                        
                    }

                    repAttachment.DataSource = _ticketses[0].Ticketattachments.OrderByDescending(t => t.Ticketattachmentid);
                    repAttachment.DataBind();

                    Session["bol.ticket"] = _ticketses[0];
                }
            }
        }
        public void LoadTicketStatuses()
        {
            manager_ticketstatus = new Manager.ticketstatus();
            bol_ticketstatus = new BOL.ticketstatus();
            List<BOL.ticketstatus> _ticketStatuses = manager_ticketstatus.SelectAll(bol_ticketstatus);
            ddlTicketStatus.DataValueField = "Ticketstatusid";
            ddlTicketStatus.DataTextField = "Ticketstatusname";
            ddlTicketStatus.DataSource = _ticketStatuses;
            ddlTicketStatus.DataBind();
        }        
        
        public void ClearForm(Control c)
        {
            utility.ClearForm(c);
        }
       
        public Int32 Update()
        {
            if (Session["bol.ticket"] != null)
            {
                BOL.tickets _ticket = (BOL.tickets)Session["bol.ticket"];
                bol_ticketfeedback = new BOL.ticketfeedback();
                manager_tickets = new Manager.tickets();
                manager_ticketfeedback = new Manager.ticketfeedback();

                if (_ticket != null)
                {
                    _ticket.Title = txtTickettitle.Text;
                    _ticket.Description = txtTicketDescription.Text;
                    _ticket.Modifiedby = Convert.ToInt32(Session["userid"]);
                    _ticket.Modifiedon = DateTime.Now;
                    _ticket.Ticketstatusid = Convert.ToInt32(ddlTicketStatus.SelectedValue);
                    manager_tickets.Update(_ticket);

                    bol_ticketfeedback.Ticketid = _ticket.Ticketid;
                    bol_ticketfeedback.Feedback = txtfeedback.Text;
                    bol_ticketfeedback.Isdeleted = "F";
                    bol_ticketfeedback.Userid = _ticket.Modifiedby;
                    manager_ticketfeedback.Insert(bol_ticketfeedback);


                }
            }
            return 0;
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        #endregion
    }
}