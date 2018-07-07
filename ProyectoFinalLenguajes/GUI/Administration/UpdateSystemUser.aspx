<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateSystemUser.aspx.cs" Inherits="GUI.Administration.UpdateSystemUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div class="center-block">
        <h1>Update System User</h1>
        <asp:Label ID="L_Informacion" CssClass="label label-primary labels" runat="server" Text="Enter The User Name"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="T_Code" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="B_Find" CssClass="btn btn-primary boton" runat="server" Text="Find" OnClick="B_Find_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="L_State" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="L_Name" runat="server" Text="Name: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Name" IsReadOnly="True" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
        &nbsp;
        <asp:TextBox ID="Text_Password" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="L_Role" runat="server" Text="Role:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Role" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="L_Rol" runat="server" Text="Role: "></asp:Label>
        <br />
        <asp:RadioButtonList ID="Radio_Role" runat="server" Width="178px">
            <asp:ListItem Value="Admin">Administrador</asp:ListItem>
            <asp:ListItem Value="Kitchen">Kitchen User</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="B_addUSer" CssClass="btn btn-primary boton" runat="server" OnClick="B_addUSer_Click" Text="Update User" Width="138px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="B_cancel" CssClass="btn btn-primary boton" runat="server" Text="Cancel" OnClick="B_cancel_Click" />
        <br />
    </div>
</asp:Content>
