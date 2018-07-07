<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="RemoveSystemUser.aspx.cs" Inherits="GUI.Administration.RemoveSystemUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div class="center-block">
        <h1>Delete User</h1>
        <br />
        <asp:Label ID="Label1" CssClass="btn btn-primary boton" runat="server" Text="List Of Available Users" Width="224px"></asp:Label>
        <br />
        <asp:ListBox ID="List_User" runat="server" Height="167px" Width="508px" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="B_Delete" CssClass="btn btn-primary boton" runat="server" Text="Delete User" Width="149px" OnClick="B_Delete_Click" />
        &nbsp;&nbsp;&nbsp
        <asp:Button ID="B_Cancel" CssClass="btn btn-primary boton" runat="server" Text="Cancel" OnClick="B_Cancel_Click" />
    </div>
</asp:Content>
