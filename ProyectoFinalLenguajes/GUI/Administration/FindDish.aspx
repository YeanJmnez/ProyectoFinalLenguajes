<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="FindDish.aspx.cs" Inherits="GUI.Administration.FindDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <form runat="server">

        <asp:Label ID="Label1" CssClass="labels" runat="server" Text="Please enter the dish yo want in the box below "></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TbFindDish" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" CssClass="btn-primary boton" runat="server" Text="Find" />

    </form>
</asp:Content>
