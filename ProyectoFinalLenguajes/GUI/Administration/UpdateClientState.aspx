<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateClientState.aspx.cs" Inherits="GUI.Administration.UpdateClientState" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
        <div class="center-block">
        <h1>Change Client State</h1>
        <br />
        <asp:Label ID="Label1" CssClass="label label-primary custom-label" runat="server" Text="Complete Client List"></asp:Label>
            <br />
        <br />
        <asp:ListBox ID="List_User" runat="server" Height="167px" Width="508px" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp
            <asp:Button ID="BtEnable" runat="server" CssClass="btn btn-primary" OnClick="BtEnable_Click" Text="Enable Client" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtDisable" runat="server" CssClass="btn btn-primary" OnClick="BtDisable_Click" Text="Disable Client" />
    </div>
</asp:Content>
