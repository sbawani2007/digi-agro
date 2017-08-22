<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rights.aspx.cs" Inherits="DigiAgro.RolesRights.Rights" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 165px;
        }
        .style2
        {
            width: 555px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

                        <table style="width: 804px" runat="server" id="tblmain">
                     <tr >
                        <td align="right" class="style1" width="30%">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                            &nbsp;</td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1" width="30%">
                            <asp:Label ID="Label9" runat="server" Text="Roles :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                            <asp:DropDownList ID="ddlRoles" runat="server" Width="154px">
                            </asp:DropDownList>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1" width="30%">
                                    <asp:Label ID="Label2" runat="server" Text="Discription :"></asp:Label>
                                </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                                    <asp:TextBox ID="txtRoleDiscription" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1" width="30%">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                            &nbsp;</td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1" width="30%">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                            <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                            </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>                
                    <tr >
                        <td align="right" class="style1" width="30%">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td style="text-align: center;" class="style2" width="60%" >
                            <asp:GridView ID="dgvRoles" runat="server" DataKeyNames = "ticketstatusid" AutoGenerateColumns="False" 
                                style="text-align: center; margin-left: 0px" Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="Ticket Status" DataField="RoleName" >
                                    <ItemStyle Width="30%" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Select">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="cbSelect" runat="server" Text="Select" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" />
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                                               
                        
                    </tr>                
                        </table>

</asp:Content>

