<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="GUIManagerOrdes.aspx.cs" Inherits="GUI.Administration.GUIManagerOrdes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
                <div class="center-block">
        <h1>Filter and Modify Order</h1>
        <br />
        <asp:Label ID="Label1" CssClass="label label-primary boton custom-label" runat="server" Text="Filter By Client" ></asp:Label>
        <br />
        <div runat="server" id="idList" class="table-responsive">
        <asp:ListBox ID="List_ClientFilter" runat="server" Height="167px" Width="908px" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
         </div>
                <br />
                <br />
                <div class="form-group input-group">
                 <span class="input-group-addon custom-addon">Client Email</span>
                 <asp:TextBox CssClass="form-control" Width="350" ID="TxtEmail" runat="server"></asp:TextBox>
                </div>
                   <br />
                <br />
        <asp:Button ID="BtChargeList" CssClass="btn btn-primary boton" runat="server" Text="Filter List" Width="149px" OnClick="B_charge_Click" />
                    <br />
                <br />
                <asp:RadioButton ID="RBOntime" runat="server" Text="on_Time" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBAboutTime" runat="server" Text="about_Time" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBCanceled" runat="server" Text="canceled" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBComitted" runat="server" Text="committed" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBLate" runat="server" Text="late" />
                <br />
        <br />
                <asp:Button ID="BtChageStatus" CssClass="btn btn-primary boton" runat="server" Text="Change Status" OnClick="BtChageStatus_Click" />
    </div>
</asp:Content>
