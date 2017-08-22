<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ticketdetails.aspx.cs" Inherits="DigiAgro.Tickets.ticketdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblmain" runat="server">
        <tr>
            <td colspan="2">
                <asp:LinkButton ID="lnkbtnFeedbackHistory" runat="server">View Feedback History</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server">View Assignment History</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
            </td>
            <td style="margin-left: 40px">
                <asp:TextBox ID="txtTickettitle" runat="server" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTicketDescription" runat="server" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Feed Back"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtfeedback" runat="server" TextMode="MultiLine" Height="79px" Width="245px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Ticket Status"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTicketStatus" runat="server" Width="245px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td >
                <asp:Button ID="btnUpdate" runat="server" Text="Update Ticket" 
                    onclick="btnUpdate_Click" />
                
            </td>
            
        </tr>
        <tr>
            <td colspan="2" align="center">
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DropDownList ID="ddlUserQueues" runat="server">
                    <asp:ListItem>Customer Care</asp:ListItem>
                    <asp:ListItem>Advisory</asp:ListItem>
                    <asp:ListItem>Survey</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:Button ID="btnAssignTickets" runat="server" Text="Assign Ticket" />
                &nbsp;&nbsp;
            </td>
        </tr>
    </table>

    <div runat="server" id="accordion">
        <h3>
            Attachments</h3>
        <div>
            <asp:Repeater ID="repAttachment" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <a href='http://www.techupgraded.info/andriod/uploads/<%#Eval("Customers.Mobile")%><%#Eval("Link")%>'>
                                    <%#Eval("Link")%>
                                </a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SeparatorTemplate>
                    <table>
                        <tr>
                            <td>
                                _
                                <hr />
                            </td>
                        </tr>
                    </table>
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
        <h3>
            Feedback History</h3>
        <div>
            <asp:Repeater ID="repFeedbackHistory" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <%#Eval("Users.Username")%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#Eval("Createdon")%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <%#Eval("Feedback")%>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SeparatorTemplate>
                    <table>
                        <tr>
                            <td>
                                _
                                <hr />
                            </td>
                        </tr>
                    </table>
                </SeparatorTemplate>
            </asp:Repeater>
        </div>
        <h3>
            Assignment History</h3>
        <div>
        </div>
    </div>


</asp:Content>
