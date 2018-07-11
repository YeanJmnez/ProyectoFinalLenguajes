<%@ Page Title="" Language="C#" MasterPageFile="~/Kitchen/KitchenSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="ActiveOrders.aspx.cs" Inherits="GUI.Kitchen.ActiveOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="KitchenPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="KitchenPanelContent" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="Content/js/JSKitchenModule.js"></script>
    <div ">
        <br />
        <h3>List Of Orders</h3>
         <table class="table">
         <thead>
<tr>
 <th>#Order</th>
 <th>Name Client</th>
 <th>Dishes</th>
 </tr>
</thead>
         <tbody id="user">
         </tbody>
         </table>
    </div>
</asp:Content>
