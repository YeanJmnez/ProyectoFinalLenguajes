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
                    <span class="input-group-addon">Select type of Filter 
                         <asp:Button ID="bt1" CssClass="btn btn-primary" runat="server" Text="multi-filter" OnClick="bt1_Click" />
                        <asp:Button ID="bt2" runat="server" CssClass="btn btn-primary" Text="one filter" OnClick="bt2_Click" />
                    </span>
                </div>

                <div runat="server" id="oneFilter" style="display: none">
                    <asp:DropDownList ID="dropDownone" runat="server" CssClass="form-control" Width="200">
                        <asp:ListItem Value="0">Filter by Client</asp:ListItem>
                        <asp:ListItem Value="1">Filter by Date</asp:ListItem>
                        <asp:ListItem Value="2">Filter by status</asp:ListItem>
                    </asp:DropDownList>

                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Height="28px" Text="Select Filter" Width="116px" OnClick="Button1_Click" />
                    <br />
                    <br />
                </div>

                <div runat="server" id="divMuti" style="display: none">
                    <fieldset class="form-group">
                        <legend class="col-sm-3 control-label">Select the filters</legend>
                        <div class="checkbox checkboxlist col-sm-7">
                            <asp:CheckBoxList ID="checkBox" runat="server">
                                <asp:ListItem Text="Filter by Client"></asp:ListItem>
                                <asp:ListItem Text="Filter by Date"></asp:ListItem>
                                <asp:ListItem Text="Filter by State"></asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                    </fieldset>
                </div>
                &nbsp;<br />

                <div runat="server" id="divClientCode" style="display: none">
                    <div class="form-group input-group">
                        <span class="input-group-addon">Client Email</span>
                        <asp:TextBox CssClass="form-control" ID="TxtClientEmail" Width="240" runat="server"></asp:TextBox>&nbsp;
                        <asp:Button ID="btfinClient" CssClass="btn btn-primary" runat="server" Text="Find" OnClick="btfindbyClient" />
                    </div>
                </div>




                <div runat="server" id="box" class="table-responsive" style="display: none">
                    <asp:Label ID="Label1" runat="server" CssClass="label label-primary" Text="Order List"></asp:Label>
                    <asp:ListBox ID="List_User" runat="server" BackColor="#CCFFFF" ForeColor="Black" Rows="10"></asp:ListBox>
                    <span class="input-group-addon">Status
                        <asp:DropDownList ID="change" runat="server" CssClass="form-control" Width="200">
                            <asp:ListItem Value="0">on_Time</asp:ListItem>
                            <asp:ListItem Value="1">about_Time</asp:ListItem>
                            <asp:ListItem Value="2">late</asp:ListItem>
                            <asp:ListItem Value="3">canceled</asp:ListItem>
                            <asp:ListItem Value="4">committed</asp:ListItem>
                        </asp:DropDownList>
                    </span>
                    <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Height="28px" Text="Change Status" Width="116px" OnClick="clickChange" />

                </div>

                <div runat="server" id="div3" style="display: none">
                    <span class="input-group-addon">Status
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="200">
                            <asp:ListItem Value="0">on_Time</asp:ListItem>
                            <asp:ListItem Value="1">about_Time</asp:ListItem>
                            <asp:ListItem Value="2">late</asp:ListItem>
                            <asp:ListItem Value="3">canceled</asp:ListItem>
                            <asp:ListItem Value="4">committed</asp:ListItem>
                        </asp:DropDownList>
                    </span>
                    <asp:Button ID="Button3" CssClass="btn btn-primary" runat="server" Height="28px" Text="apply filter" Width="116px" OnClick="Button3_Click" />

                    <br />
                </div>
                <br />
                <div id="datesCale" runat="server" style="display: none">
                    <div id="divBDate" runat="server" style="display: block">
                        <asp:Calendar ID="beginDate" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="182px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                        <asp:Label ID="lbBeginDate" runat="server" Text="Begin date"></asp:Label>
                        <br />
                        <br />

                        &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" CssClass="btn btn-primary" Text="save Begin date" OnClick="Button4_Click" />
                    </div>
                    <br />


                    <div id="divFdate" runat="server" style="display: block">
                        <asp:Calendar ID="finalDate" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="182px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                        <asp:Label ID="lbfinDate" runat="server" Text="end date"></asp:Label>
                        <br />
                        <br />

                        <asp:Button ID="Button5" runat="server" CssClass="btn btn-primary" Text="save end date" OnClick="Button5_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
