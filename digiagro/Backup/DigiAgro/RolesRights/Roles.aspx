<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="DigiAgro.RoleRights.Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    dear anas i am editing it too.
    <style type="text/css">
        .style1
        {
            width: 60%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

                        <table style="width: 804px" runat="server" id="tblmain">
                     <tr >
                        <td style="width: 20%" align="right">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style1" >
                            &nbsp;</td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                            <tr>
                                <td align="right" style="width: 20%">
                                    <asp:Label ID="Label1" runat="server" Text="Role Name :"></asp:Label>
                                </td>
                                <td align="right" colspan="1" style="width: 1%;">
                                    &nbsp;</td>
                                <td class="style1">
                                    <asp:TextBox ID="txtRoleName" runat="server"></asp:TextBox>
                                </td>
                                <td style="width: 800">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 20%">
                                    <asp:Label ID="Label2" runat="server" Text="Discription :"></asp:Label>
                                </td>
                                <td align="right" colspan="1" style="width: 1%;">
                                    &nbsp;</td>
                                <td class="style1">
                                    <asp:TextBox ID="txtRoleDiscription" runat="server"></asp:TextBox>
                                </td>
                                <td style="width: 800">
                                    &nbsp;</td>
                            </tr>
                    <tr >
                        <td style="width: 20%" align="right">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style1" >
                            <asp:CheckBox ID="cbIsDeleted" runat="server" Text="Is Deleted" />
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td style="width: 20%" align="right">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style1" >
                            <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                            </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>                
                    <tr >
                        <td style="width: 20%" align="right">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td style="text-align: left;" class="style1" >
                            <asp:GridView ID="dgvRoles" runat="server" AutoGenerateColumns="False" 
                                style="text-align: center; margin-left: 0px" Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="RoleName" DataField="RoleName" >
                                    <ItemStyle Width="30%" />
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="Discription" DataField="Discription" >
                                    <ItemStyle Width="30%" />
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="IsDeleted" DataField="IsDeleted" >
                                    <ItemStyle Width="20%" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbEdit" runat="server">Edit</asp:LinkButton>
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" />
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                                               
                        
                    </tr>                
                        </table>

</asp:Content>
