<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateDish.aspx.cs" Inherits="GUI.Administration.UpdateDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
    <link href="Content/css/updateDish.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div id="contact-form-div">
        <div id="contact-form-row" class="row">
            <div id="dish-form-div-column" class="col-sm-6">
                <h3>Search by code the dish to modify</h3>
                <div class="form-group input-group">
                    <span class="input-group-addon">Dish Code</span>
                    <asp:TextBox CssClass="form-control" ID="TxtCodeUpdate" Width="240" runat="server"></asp:TextBox>&nbsp;
                        <asp:Button ID="BtChargeDU" CssClass="btn btn-primary" runat="server" Text="Buscar Plato" OnClick="BtChargeDU_Click" />
                </div>
                <br />
                <h4>Selected Dish Data</h4>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Name</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtUpdateName" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Description</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtUpdateDescription" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Price</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtUpdatePrice" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish State</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtUpdateState" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Image</span>
                    <asp:FileUpload ID="FileUploadUpdateImage" Width="350" CssClass="form-control" runat="server" />
                </div>
                <asp:Button ID="btUpdateDish" CssClass="btn btn-primary" runat="server" OnClick="btUpdateDish_Click" Text="Modificar Plato" />
            </div>
            <div id="dishes-list-div-column" class="col-sm-4">
                <h3>Lista General de Platos</h3>
                <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="GridCompleteDishesList" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
