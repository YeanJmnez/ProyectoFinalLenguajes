<%@ Page Title="" Language="C#" MasterPageFile="~/Kitchen/KitchenSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="DefinitionStatusTime.aspx.cs" Inherits="GUI.Kitchen.DefinitionStatusTime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="KitchenPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="KitchenPanelContent" runat="server">
    <div>

        <h2>Configuration Of Time Status</h2>
        <br />
        <asp:Label ID="L_State" runat="server" CssClass="label label-primary labels" Text=""></asp:Label>
        <br />
        <h4>Definition of the time of the status "A Tiempo - Sobre Tiempo"</h4>
        <asp:Label ID="L_M1" runat="server" Text="Label">Minutes: </asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="T_Minu1" runat="server" Width="80px"></asp:TextBox><br />
        <br />

        <h4>Definition of the time of the status "Sobre Tiempo - Demorado"</h4>
        <asp:Label ID="L_M2" runat="server" Text="Label">Minutes: </asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="T_Minu2" runat="server" Width="82px"></asp:TextBox><br />
        <br />

        <h4>Definition of the time of the status "Demorado - Anulado"</h4>
        <asp:Label ID="L_M3" runat="server" Text="Label">Minutes: </asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="T_Minute3" runat="server" Width="75px"></asp:TextBox><br />
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" CssClass="btn btn-primary boton" Text="Save Times" OnClick="Button9_Click" /><br />
    </div>
</asp:Content>
