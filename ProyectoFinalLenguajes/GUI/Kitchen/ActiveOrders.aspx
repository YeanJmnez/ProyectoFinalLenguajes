<%@ Page Title="" Language="C#" MasterPageFile="~/Kitchen/KitchenSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="ActiveOrders.aspx.cs" Inherits="GUI.Kitchen.ActiveOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="KitchenPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="KitchenPanelContent" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="content/js/SystemUser.js"></script>
    <div onload="getAllOrder()">
        <br />
        <br />
        <h5>List Of Pending Orders</h5>
        <br />
        <br />
        <table class="table">
            <thead>
                <tr>
                    <th>Code Order</th>
                    <th>Password</th>
                    <th>Role</th>
                </tr>
            </thead>
            <tbody id="tbSystemUser">
            </tbody>
        </table>
    </div>
</asp:Content>
