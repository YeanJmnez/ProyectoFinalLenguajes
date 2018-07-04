<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="RemoveDish.aspx.cs" Inherits="GUI.Administration.RemoveDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div>
        <asp:Label ID="Label1" CssClass="labels" runat="server" Text="Please enter the dish yo want to delete in the box below "></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TbFindDish" runat="server" Width="187px"></asp:TextBox>
        <br />
        <br />
        <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="grid" runat="server" Width="368px" OnSelectedIndexChanged="grid_SelectedIndexChanged"></asp:GridView>
        <br />
        <br />
        <asp:Button ID="btRemove" CssClass="btn-primary boton" runat="server" Text="Delete" OnClick="btRemove_Click" />
    </div>
</asp:Content>
