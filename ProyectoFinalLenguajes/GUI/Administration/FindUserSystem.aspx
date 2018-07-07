<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="FindUserSystem.aspx.cs" Inherits="GUI.Administration.FindUserSystem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div>
        <h1>Serch System User</h1>
        <br />
        <br />
        <asp:Label ID="L_Informacion" CssClass="label label-primary labels" runat="server" Text="Enter The User Name"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="T_Code" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="L_State" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="B_Find" CssClass="btn btn-primary boton"  runat="server" Text="Find" OnClick="B_Find_Click" />
        <br />
        <br />
        <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="grid_User" runat="server" Width="368px"></asp:GridView>
    </div>
</asp:Content>
