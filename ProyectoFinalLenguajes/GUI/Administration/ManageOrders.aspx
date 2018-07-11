<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="ManageOrders.aspx.cs" Inherits="GUI.Administration.ManageOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
    <link href="Content/css/updateDish.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div id="contact-form-div">
        <div id="contact-form-row" class="row">
            <div id="dish-form-div-column" class="col-sm-6">
                <h3>Manage Orders Menu</h3>

                <div class="form-group input-group">
                    <span class="input-group-addon">Select type of Filter</span>
                    <asp:RadioButtonList CssClass="form-control" ID="rblRoleSelector" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="filter" Selected="True">filter &nbsp;&nbsp;&nbsp;</asp:ListItem>
                        <asp:ListItem Value="multi-filter"> multi-filter</asp:ListItem>
                    </asp:RadioButtonList>
                       </div>

                    <div>
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                Select  filter
                       <span class="fa fa-arrow-circle-down"></span>
                            </button>


                            <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenuButton">
                                <li><a class="dropdown-item" href="#">Filter by Client</a></li>
                                <li><a class="dropdown-item" href="#">Filter by Date</a></li>
                                <li><a class="dropdown-item" href="#">Filter by State</a></li>
                            </ul>
                        </div>
                    </div>


                <br />



                <div id="dishes-list-div-column" class="col-sm-4">
                    <h3>Lista de Ordenes</h3>
                    <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid table-responsive" ID="GridCompleteDishesList" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
