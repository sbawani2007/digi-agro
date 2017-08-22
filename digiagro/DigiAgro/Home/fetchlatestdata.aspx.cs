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
    public partial class fetchlatestdata : System.Web.UI.Page
    {


        #region properties and variable

        //Manager.customer manager_customer;
        //Manager.customer_address manager_customer_address;
        //Manager.tickets manager_tickets;        
        //Manager.Enums _enums;
        //Manager.ticketattachment manager_tattach;
        //Utility utility;

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
            //manager_customer = new customer();
            //manager_customer_address = new Manager.customer_address();
            //manager_tickets = new Manager.tickets();
            //manager_tattach = new Manager.ticketattachment();
            //_enums = new Manager.Enums();
            //utility = new Utility();

            bol_ticket = new BOL.tickets();
            bol_customer = new BOL.customers();
            bol_ticketattach = new BOL.ticketattachment();
            bol_ticketses = new List<BOL.tickets>();
            bol_customerses = new List<BOL.customers>();

        }
        

        public void FetchLatestUploadData()
        {
            Initialize();

            // Create a new XmlDocument  
            XmlDocument doc = new XmlDocument();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Load data  
            doc.Load("http://techupgraded.info/andriod/xmltest.php");

            // Set up namespace manager for XPath  
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("tickets", "http://techupgraded.info/andriod/xmltest.php");

            // Get forecast with XPath  
            XmlNodeList nodes = doc.SelectNodes("data/Ticket", ns);

            // You can also get elements based on their tag name and namespace,  
            // though this isn't recommended  
            //XmlNodeList nodes = doc.GetElementsByTagName("forecast",   
            //                          "http://xml.weather.yahoo.com/ns/rss/1.0");  

            foreach (XmlNode node in nodes)
            {
                //Response.Write(node.ChildNodes.Count.ToString());

                if (node != null && node.ChildNodes.Count > 0)
                {
                    bol_customer = new BOL.customers();
                    bol_customer.Ticketses = new List<BOL.tickets>();
                    bol_ticket = new BOL.tickets();
                    bol_ticket.Ticketattachments = new List<BOL.ticketattachment>();

                    foreach (XmlNode inner in node.ChildNodes)
                    {                        

                        if (inner.Name == "mobile")
                        {
                            sb.Append("mobile: " + inner.InnerText + "<br/>");
                            bol_customer.Mobile = inner.InnerText;
                        }
                        if (inner.Name == "link")
                        {
                            sb.Append("link: " + inner.InnerText + "<br/>");
                            bol_ticketattach = new BOL.ticketattachment();
                            bol_ticketattach.Link = inner.InnerText;
                            bol_ticket.Ticketattachments.Add(bol_ticketattach);
                        
                        }
                    }
                    bol_customer.Ticketses.Add(bol_ticket);
                    bol_customerses.Add(bol_customer);
                    sb.Append("<br/>");
                }
            }
            divMain.InnerHtml = sb.ToString();
            Session["bol.customerslist"] = bol_customerses;
        }

        public void ProcessTickets()
        {
            manager_dashboard = new Manager.dashboard();
            if (Session["bol.customerslist"] != null)
            {
                this.bol_customerses = (List<BOL.customers>)Session["bol.customerslist"];
                if (this.bol_customerses != null && this.bol_customerses.Count > 0)
                {
                    Int32 result = manager_dashboard.ProcessTickets(this.bol_customerses, Convert.ToInt32(Session["userid"]));
                }
            }
                 
        }

        #endregion

        #region event handlers

        protected void Page_Load(object sender, EventArgs e)
        {
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


        protected void btnFetchData_Click(object sender, EventArgs e)
        {
            FetchLatestUploadData();
        }

        protected void btnProcessData_Click(object sender, EventArgs e)
        {
            divMain.InnerHtml = string.Empty;
            ProcessTickets();
        }


        #endregion



    }
}