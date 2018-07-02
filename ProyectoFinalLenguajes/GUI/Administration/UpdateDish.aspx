<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateDish.aspx.cs" Inherits="GUI.Administration.UpdateDish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <h2>Lista General de Platos</h2>
    <p>
        <asp:GridView ID="GridCompleteDishesList" runat="server">
        </asp:GridView>
    </p>
    <h4>Seleccione el código del plato que desea modificar.</h4>

        <asp:Label ID="LbUpdateCD" runat="server" Text="Código del Plato"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtCodeUpdate" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtChargeDU" runat="server" Text="Buscar Plato" OnClick="BtChargeDU_Click" />

<br />
<br />
<br />
<br />
<asp:Label ID="LbName" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TxtUpdateName" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="LbDescription" runat="server" Text="Descripción"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TxtUpdateDescription" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="LbPrice" runat="server" Text="Precio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TxtUpdatePrice" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="LbState" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TxtUpdateState" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="LbImage" runat="server" Text="Imagen"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:FileUpload ID="FileUploadUpdateImage" runat="server" />
    <br />
    <asp:Button ID="btUpdateDish" runat="server" OnClick="btUpdateDish_Click" Text="Modificar Plato" />

</asp:Content>
