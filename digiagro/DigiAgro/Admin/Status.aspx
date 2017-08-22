<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Status.aspx.cs" Inherits="DigiAgro.Admin.Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
                            <asp:Label ID="Label9" runat="server" Text="Status Name :"></asp:Label>
                        </td>
                        <td style="width: 1%;" align="right" colspan="1">
                            &nbsp;</td>
                        <td class="style2" width="60%" >
                                    <asp:TextBox ID="txtStatusName" runat="server"></asp:TextBox>
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
                            <asp:CheckBox ID="cbIsDeleted" runat="server" Text="Is Deleted" />
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
                            <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save" />
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
                            <asp:GridView ID="dgvStatus" runat="server" AutoGenerateColumns="False" 
                                style="text-align: center; margin-left: 0px" Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="Status Name" DataField="RoleName" >
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="Status Discription" />
                                    <asp:TemplateField HeaderText="Edit">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbEdit" runat="server">Edit</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                                               
                        
                    </tr>                
                        </table>

</asp:Content>
