﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Owais01.aspx.cs" Inherits="DigiAgro.owas01.Owais01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <asp:Label ID="Label4" runat="server" Text="First Name :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label5" runat="server" Text="Last Name :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtlastName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label6" runat="server" Text="Email :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td style="width: 800">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="right" class="style1" width="30%">
                    <asp:Label ID="Label7" runat="server" Text="Contact Num :"></asp:Label>
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td class="style2" width="60%">
                    <asp:TextBox ID="txtcontactNum" runat="server"></asp:TextBox>
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
            <tr>
                <td align="right" class="style1" width="30%">
                    &nbsp;
                </td>
                <td style="width: 1%;" align="right" colspan="1">
                    &nbsp;
                </td>
                <td style="text-align: center;" class="style2" width="60%">
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
