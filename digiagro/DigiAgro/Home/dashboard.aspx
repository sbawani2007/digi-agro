<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="DigiAgro.Home.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div runat="server" id="accordion">
	<h3>My Open Tickets</h3>
    <div>
        <asp:GridView ID="grdOpenTickets" runat="server" AutoGenerateColumns="false" DataKeyNames="Ticketid"
            OnRowCommand="grdOpen_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <%# Eval("Title") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <%# Eval("Description") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# Eval("Ticketid", "/tickets/ticketdetails.aspx?id={0}") %>'>See Details</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
	<h3>Anonymous Tickets</h3>
	<div><asp:GridView ID="grdAnonymousTickets" runat="server" AutoGenerateColumns="false" DataKeyNames="Ticketid"
            OnRowCommand="grdOpen_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <%# Eval("Title") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <%# Eval("Description") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href='<%# Eval("Ticketid", "/tickets/ticketdetails.aspx?id={0}") %>'>See Details</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView></div>
	<h3>Feedback Required Tickets</h3>
	<div>Nam dui erat, auctor a, dignissim quis.</div>
    <h3>Advise required Tickets</h3>
	<div>Nam dui erat, auctor a, dignissim quis.</div>
</div>
</asp:Content>
