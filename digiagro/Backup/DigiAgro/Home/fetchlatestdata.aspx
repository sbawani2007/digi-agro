<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fetchlatestdata.aspx.cs" Inherits="DigiAgro.Home.fetchlatestdata" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="btnFetchData" runat="server" Text="Fetch Data" OnClick="btnFetchData_Click" />
    <asp:Button ID="btnProcessData" runat="server" Text="Process Data" 
        onclick="btnProcessData_Click" />
    <div id="divMain" runat="server">
    </div>
</asp:Content>
