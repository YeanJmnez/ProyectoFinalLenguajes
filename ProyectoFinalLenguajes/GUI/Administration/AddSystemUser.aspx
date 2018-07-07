<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="AddSystemUser.aspx.cs" Inherits="GUI.AddSystemUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div class="center-block">
        <h1>Enter New User</h1>
        <br />
        <asp:Label ID="L_Name" runat="server" Text="Name: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Text_Name" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
        &nbsp;
        <asp:TextBox ID="Text_Password" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="L_State" runat="server"></asp:Label>
        <br />
        <asp:Label ID="L_Rol" runat="server" Text="Role: "></asp:Label>
        <br />
        <asp:RadioButtonList ID="Radio_Role" runat="server" Width="403px">
            <asp:ListItem Value="Admin">Administrador User</asp:ListItem>
            <asp:ListItem Value="Kitchen">Kitchen User</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="B_addUSer" runat="server" OnClick="B_addUSer_Click" Text="Add User" />
    </div>
</asp:Content>
