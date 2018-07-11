<%@ Page Title="" Language="C#" MasterPageFile="~/Kitchen/KitchenSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="IndexKitchen.aspx.cs" Inherits="GUI.Kitchen.IndexKitchen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="KitchenPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="KitchenPanelContent" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>


    </div>
</asp:Content>
