<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="GuiManagerOrderStatus.aspx.cs" Inherits="GUI.Administration.GuiManagerOrderStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
                    <div class="center-block">
        <h1>Filter and Modify Order by Status</h1>
        <br />
        <asp:Label ID="Label1" CssClass="label label-primary boton custom-label" runat="server" Text="Filter By Status" ></asp:Label>
        <br />
        <div runat="server" id="idList" class="table-responsive">
        <asp:ListBox ID="List_StatusFilter" runat="server" Height="167px" Width="908px" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
         </div>
                <br />
                <br />
                <asp:RadioButton ID="RBOntime0" runat="server" Text="on_Time" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBAboutTime0" runat="server" Text="about_Time" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBCanceled0" runat="server" Text="canceled" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBComitted0" runat="server" Text="committed" />
&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RBLate0" runat="server" Text="late" />
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
