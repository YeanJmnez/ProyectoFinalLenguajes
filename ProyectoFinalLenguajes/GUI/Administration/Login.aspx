<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUI.Administration.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css/login.css" rel="stylesheet" />
    <script src="Content/js/jquery-1.11.1.min.js"></script>
    <script src="Content/js/bootstrap.min.js"></script>
    <script src="Content/js/login.js"></script>
</head>
<body class="center-block">
    <div id="login-form">
        <label class="label label-primary login-title">Log In To Admin Panel</label>
        <hr />
        <form runat="server" novalidate="novalidate">
            <div class="form-group input-group">
                <span class="input-group-addon">
                    <span class="fa fa-envelope"></span>
                </span>
                <input runat="server" id="txtLoginUserName" class="form-control" type="text" name="userName" placeholder="User Name" required="required" />
                <span class="input-group-addon warn hidden" runat="server" id="loginEmptyUserName">Complete this field</span>
                <span class="input-group-addon warn hidden" runat="server" id="wrongUserName">Username not found</span>
            </div>
            <div class="form-group input-group">
                <span class="input-group-addon">
                    <span class="fa fa-lock" style="font-size: 20px;"></span>
                </span>
                <input runat="server" id="txtLoginUserPassword" class="form-control" type="password" name="userPassword" placeholder="Password" required="required" />
                <span class="input-group-addon warn hidden" runat="server" id="loginEmptyPassword">Complete this field</span>
                <span class="input-group-addon warn hidden" runat="server" id="wrongPassword">Wrong password</span>
            </div>
            <div class="form-group input-group">
                <asp:RadioButtonList CssClass="form-control" ID="rblRoleSelector" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="Admin" Selected="True">Admin User&nbsp;&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem Value="Kitchen">Kitchen User</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="form-group">
                <asp:Button CssClass="btn custom-btn-blue btn-block" ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />
            </div>
            <asp:ScriptManager ID="ScriptManager" runat="server">
            </asp:ScriptManager>
            <asp:Timer ID="Timer_State" runat="server" Enabled="False" OnTick="Timer_State_Tick">
            </asp:Timer>
        </form>
    </div>
</body>
</html>
