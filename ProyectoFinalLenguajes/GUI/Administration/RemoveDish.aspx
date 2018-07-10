<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="RemoveDish.aspx.cs" Inherits="GUI.Administration.RemoveDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div id="contact-form-div">
        <div id="contact-form-row" class="row">
            <div id="dish-form-div-column" class="col-sm-6">
                <br />
                <h2>Delete Dish Menu</h2>
                <asp:Label ID="Label1" CssClass="labels" runat="server" Text="Please enter the dish yo want to delete in the box below "></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="tbDeleteCode" runat="server"></asp:TextBox>
                <asp:Button ID="btDelete" CssClass="btn btn-primary"  runat="server" Text="delete" OnClick="btDelete_Click" />
                <br />

                <br />
                <br />
                <div id="dishes-list-div-column" class="col-sm-4">
                    <h3>Lista General de Platos</h3>
                    <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="grid" runat="server"
                        Width="368px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    </asp:GridView>
                </div>
                <br />
                <br />

            </div>
        </div>
    </div>
</asp:Content>
