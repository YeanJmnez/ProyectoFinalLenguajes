<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="EnableOrDisableDish.aspx.cs" Inherits="GUI.EnableOrDisableDish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
        <div class="center-block">
        <h1>Enable or Disable Dish</h1>
        <br />
        <asp:Label ID="Label1" CssClass="btn btn-primary boton" runat="server" Text="Dishes List" Width="224px"></asp:Label>
        <br />
        <asp:ListBox ID="List_User" runat="server" Height="167px" Width="508px" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="B_Disable" CssClass="btn btn-primary boton" runat="server" Text="Disable" Width="149px" OnClick="B_disable_Click" />
        &nbsp;&nbsp;&nbsp
        <asp:Button ID="B_Enable" CssClass="btn btn-primary boton" runat="server" Text="Enable" OnClick="B_enable_Click" />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp<a href="index.aspx">Back</a>
    </div>
</asp:Content>
