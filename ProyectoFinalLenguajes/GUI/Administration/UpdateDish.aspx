<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateDish.aspx.cs" Inherits="GUI.Administration.UpdateDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div class="center-block">
        <h2>Lista General de Platos</h2>
        <br />
        <br />
        <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="GridCompleteDishesList" runat="server"></asp:GridView>
        <br />
        <br />
        <h4>Seleccione el código del plato que desea modificar.</h4>

        <asp:Label ID="LbUpdateCD" CssClass="label label-primary" runat="server" Text="Código del Plato"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtCodeUpdate" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtChargeDU" CssClass="btn btn-primary" runat="server" Text="Buscar Plato" OnClick="BtChargeDU_Click" Height="30px" Width="140px" />

        <br />
        <br />
        <asp:Label ID="LbName" CssClass="label label-primary" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUpdateName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LbDescription" CssClass="label label-primary" runat="server" Text="Descripción"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUpdateDescription" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LbPrice" CssClass="label label-primary" runat="server" Text="Precio"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUpdatePrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LbState" CssClass="label label-primary" runat="server" Text="Estado"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUpdateState" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LbImage" CssClass="label label-primary" runat="server" Text="Imagen"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUploadUpdateImage" CssClass="btn-primary" runat="server" />
        <br />
        <asp:Button ID="btUpdateDish" CssClass="btn btn-primary" runat="server" OnClick="btUpdateDish_Click" Text="Modificar Plato" Height="30px" Width="140px" />
    </div>
</asp:Content>
