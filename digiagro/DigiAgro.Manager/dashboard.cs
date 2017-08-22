using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiAgro.Manager
{
    public class dashboard
    {
        #region properties and variable

        Manager.customer manager_customer;
        Manager.customer_address manager_customer_address;
        Manager.tickets manager_tickets;
        Manager.Enums _enums;
        Manager.ticketattachment manager_tattach;
        //Utility utility;

        BLL.hunaidBLL bll_customer;
        BLL.tickets bll_tickets;
        BLL.ticketattachment bll_ticketattach;

        BOL.ticketattachment bol_ticketattach;
        BOL.tickets bol_ticket;
        BOL.customers bol_customer;
        List<BOL.tickets> bol_ticketses;
        List<BOL.customers> bol_customerses;

        string ConnectionString = string.Empty;
        MySqlConnection conn = null;
        MySqlTransaction trans;
        BLL.Utility bll_utility;

        #endregion

        #region methods and functions

        public void Initialize()
        {
            manager_customer = new customer();
            manager_customer_address = new Manager.customer_address();
            manager_tickets = new Manager.tickets();
            manager_tattach = new Manager.ticketattachment();
            _enums = new Manager.Enums();
            //utility = new Utility();

            bol_ticket = new BOL.tickets();
            bol_customer = new BOL.customers();
            bol_ticketattach = new BOL.ticketattachment();
            bol_ticketses = new List<BOL.tickets>();
            bol_customerses = new List<BOL.customers>();

            bll_customer = new BLL.hunaidBLL();
            bll_tickets = new BLL.tickets();
            bll_ticketattach = new BLL.ticketattachment();
            bll_utility = new BLL.Utility();

            ConnectionString = Utility.GetConnectionString();

        }
        public void LoadMethods()
        {

        }

        //public void ClearForm(Control c)
        //{
        //    utility.ClearForm(c);
        //}

        public BOL.customers VerifyCustomerbyMobile(BOL.customers _customer)
        {
            if (manager_customer != null && bol_customerses != null && _customer != null
                && !string.IsNullOrEmpty(_customer.Mobile))
            {
                List<BOL.customers> _customerses = manager_customer.Select(_customer);
                if (_customerses != null && _customerses.Count > 0 &&
                    _customerses[0] != null && _customerses[0].Customerid > 0)
                {
                    _customer.Customerid = _customerses[0].Customerid;
                    return _customerses[0];
                }

            }
            return new BOL.customers();
        }
        public Int32 VerifyOpenAnonymousTicketbyCustomerid(BOL.tickets _ticket)
        {
            if (manager_tickets != null && _ticket != null && _ticket.Customerid > 0)
            {
                List<BOL.tickets> _ticketses = manager_tickets.GetTicketsByStatus(TicketStatusEnum.Open.GetHashCode().ToString() + "," +
                                                                TicketStatusEnum.Anonymous.GetHashCode().ToString(), _ticket);
                if (_ticketses != null && _ticketses.Count > 0 &&
                    _ticketses[0] != null && _ticketses[0].Ticketid > 0)
                {
                    _ticket.Customerid = _ticketses[0].Customerid;
                    _ticket.Ticketid = _ticketses[0].Ticketid;
                    return _ticket.Ticketid;
                }
            }
            return 0;
        }
        public Int32 ProcessTickets(List<BOL.customers> customersList, Int32 userid)
        {
            try
            {
                Initialize();
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                trans = conn.BeginTransaction();

                //bll_objCustomer.Insert(obj, conn, trans);
                //Int32 customerid = bll_utility.GetMaxId("customers", "Customerid", conn, trans);

                if (customersList != null && customersList.Count > 0)
                {
                    this.bol_customerses = customersList;
                    if (this.bol_customerses != null && this.bol_customerses.Count > 0)
                    {
                        foreach (BOL.customers c in this.bol_customerses)
                        {
                            if (!string.IsNullOrEmpty(c.Mobile))
                            {
                                bol_customer = VerifyCustomerbyMobile(c);
                                if (bol_customer.Customerid == 0)
                                {
                                    bol_customer.Status = StatusEnum.firstcall.GetHashCode();
                                    bol_customer.Isdeleted = "F";
                                    bol_customer.Createdby = userid;
                                    bol_customer.Createdon = DateTime.Now;
                                    bol_customer.Modifyby = userid;
                                    bol_customer.Modifyon = DateTime.Now;
                                    bll_customer.Insert(c, conn, trans);
                                    bol_customer.Customerid = bll_utility.GetMaxId("customers", "Customerid", conn, trans);

                                }
                                if (c.Ticketses != null && c.Ticketses[0].Ticketattachments != null)
                                {
                                    bol_ticket.Customerid = bol_customer.Customerid;
                                    bol_ticket.Ticketid = VerifyOpenAnonymousTicketbyCustomerid(bol_ticket);
                                }
                                if (bol_ticket.Ticketid == 0)
                                {
                                    bol_ticket.Ticketstatusid = TicketStatusEnum.Open.GetHashCode();
                                    bol_ticket.Description = "Open ticket";
                                    bol_ticket.Title = "Open ticket";
                                    if (bol_customer.Status == StatusEnum.firstcall.GetHashCode())
                                    {
                                        bol_ticket.Ticketstatusid = TicketStatusEnum.Anonymous.GetHashCode();
                                        bol_ticket.Description = "Anonymous ticket";
                                        bol_ticket.Title = "Anonymous ticket";
                                    }
                                    bol_ticket.Customerid = bol_customer.Customerid;
                                    bol_ticket.Isdeleted = "F";
                                    bol_ticket.Createdby = userid;
                                    bol_ticket.Createdon = DateTime.Now;
                                    bol_ticket.Modifiedby = userid;
                                    bol_ticket.Modifiedon = DateTime.Now;
                                    bol_ticket.Userid = userid;

                                    bll_tickets.Insert(bol_ticket, conn, trans);
                                    bol_ticket.Ticketid = bll_utility.GetMaxId("tickets", "Ticketid", conn, trans);
                                }
                                if (c.Ticketses != null && c.Ticketses[0].Ticketattachments != null
                                    && c.Ticketses.Count > 0)
                                {
                                    foreach (BOL.ticketattachment tattch in c.Ticketses[0].Ticketattachments)
                                    {
                                        if (!string.IsNullOrEmpty(tattch.Link))
                                        {
                                            tattch.Isdeleted = "F";
                                            tattch.Ticketid = bol_ticket.Ticketid;

                                            tattch.Ticketattachmentid = bll_ticketattach.Insert(tattch, conn, trans);
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
                trans.Commit();
                conn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (trans != null)
                {
                    trans.Rollback();
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return 0;
        }

        public List<BOL.tickets> TicketsbyUserid(BOL.tickets _ticket)
        {
            manager_tickets = new Manager.tickets();
            if (manager_tickets != null && _ticket != null && _ticket.Userid > 0)
            {
                List<BOL.tickets> _ticketses = manager_tickets.Select(_ticket);
                if (_ticketses != null && _ticketses.Count > 0)
                {
                    return _ticketses;
                }
            }
            return new List<BOL.tickets>();
        } 
        #endregion
    }
}
