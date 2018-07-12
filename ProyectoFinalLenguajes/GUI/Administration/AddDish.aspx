<%@ Page Title="" Language="C#" MasterPageFile="~/Administration/AdminSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="AddDish.aspx.cs" Inherits="GUI.Administration.AddDish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminPanelHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminPanelContent" runat="server">
    <div runat="server" id="addDishForm" class="center-block">
        <br />
        <br />
        <h2>Add new Dishes to Menu</h2>
        <br />
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Name</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtName" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Description</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtDescription" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Price</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtPrice" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish State</span>
                    <asp:TextBox CssClass="form-control" Width="350" ID="TxtState" runat="server"></asp:TextBox>
                </div>
                <div class="form-group input-group">
                    <span class="input-group-addon custom-addon">Dish Image</span>
                    <asp:FileUpload ID="FileUploadImage" Width="350" CssClass="form-control" runat="server" />
                </div>
        <asp:Button ID="BtAddDish" CssClass="btn btn-primary" runat="server" Text="Add Dish" OnClick="BtAddDish_Click" />
    </div>
    <br />
      <div  id="successRegistration" runat="server" class="hidden center-block">    
         <div class="form-group">

            <span class="input-group-addon correct">

                <img src="Content/img/checkIcon.png" class="img-responsive img-center-block" alt="Successfull registration" />

                <br />
                Successfull Add.<br />
             
            </span>
        </div>
        <div class="form-group">
            <asp:Button ID="btnAccept" CssClass="btn btn-primary btn-block " runat="server"  Text="Accept" OnClick="btnAccept_Click"/>
         
        </div>
           </div>

</asp:Content>
