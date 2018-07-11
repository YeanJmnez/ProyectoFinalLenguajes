<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="FindDish.aspx.cs" Inherits="GUI.Administration.FindDish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <div  class="center-block">
      

        
        <asp:Label ID="Label1" CssClass="label label-primary labels" runat="server" Text="Please enter the dish yo want in the box below "></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="tbFind" runat="server" required="required" Width="147px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" CssClass="btn btn-primary boton" runat="server" Text="Find" OnClick="Button1_Click" />
        <br />
        <br />
       
         <div id="divfind" >
            <asp:GridView AlternatingRowStyle-CssClass="alternarColores" CssClass="customGrid" ID="grid" runat="server" Width="368px">
                <Columns>

                    <asp:TemplateField HeaderText="image">
                        <ItemTemplate>
                            <img src='dd' height="100" width="100" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
