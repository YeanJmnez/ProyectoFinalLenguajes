<%@ Page Title="" Language="C#" MasterPageFile="~/Kitchen/KitchenSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="ActiveOrders.aspx.cs" Inherits="GUI.Kitchen.ActiveOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="KitchenPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="KitchenPanelContent" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="Content/js/JSKitchenModule.js"></script>
    <div ">
        <br />
        <br />
        <h5>List Of Pending Orders</h5>
        <br />
        <br />
        <table class="table">
            <thead>
                <tr>
                    <th>Code Order</th>
                    <th>Name Client</th>
                    <th>List Dishes</th>
                </tr>
            </thead>
            <tbody id="tbSystemUser">
            </tbody>
        </table>
    </div>
</asp:Content>
