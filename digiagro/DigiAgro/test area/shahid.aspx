<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="shahid.aspx.cs" Inherits="DigiAgro.test_area.shahid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlmain" runat="server">
        <table style="width: 804px" runat="server" id="tblmain">
            <tr>
                <td align="right" class="style1" width="30%">
                    &nbsp;
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    &nbsp;
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label4" runat="server" Text="Test Name :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtTestName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label5" runat="server" Text="Test Email :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtTestEmail" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label1" runat="server" Text="Last Name :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
           <tr>
                <td align="right" class="style1" width="30%">
                    &nbsp;
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
