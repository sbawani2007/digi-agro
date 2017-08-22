<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="DigiAgro.Users.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 30%;
        }
        .style2
        {
            width: 60%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

                        <table style="width: 804px" runat="server" id="tblmain">
                     <tr >
                        <td align="right" class="style1">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                            &nbsp;</td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                            <tr>
                                <td align="right" class="style1">
                                    <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
                                </td>
                                <td align="right" colspan="1" style="width: 1%;">
                                    &nbsp;</td>
                                <td class="style2">
                                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                                </td>
                                <td style="width: 800">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right" class="style1">
                                    <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
                                </td>
                                <td align="right" colspan="1" style="width: 1%;">
                                    &nbsp;</td>
                                <td class="style2">
                                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                                </td>
                                <td style="width: 800">
                                    &nbsp;</td>
                            </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label3" runat="server" Text="Confirm Password :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                                    <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label4" runat="server" Text="First Name :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label5" runat="server" Text="Last Name :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label6" runat="server" Text="Email :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label7" runat="server" Text="Mobile :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label8" runat="server" Text="Role :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                            <asp:DropDownList ID="ddlRoles" runat="server" Width="154px">
                            </asp:DropDownList>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            <asp:Label ID="Label9" runat="server" Text="Status :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                            <asp:DropDownList ID="ddlStatus" runat="server" Width="154px">
                            </asp:DropDownList>
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                            <asp:CheckBox ID="cbIsDeleted" runat="server" Text="Is Deleted" />
                        </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>
                    <tr >
                        <td align="right" class="style1">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" >
                            <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click1" />
                            </td>
                        
                        <td style="width: 800" >
                            &nbsp;</td>
                        
                    </tr>                
                    <tr >
                        <td align="right" class="style1">
                            &nbsp;</td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td style="text-align: center;" class="style2" >
                            &nbsp;</td>
                                               
                        
                    </tr>                
                        </table>

</asp:Content>

