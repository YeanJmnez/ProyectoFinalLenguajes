<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUI.Administration.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/css/dashboard.css" rel="stylesheet" />
    <script src="Content/js/jquery-1.11.1.min.js"></script>
    <script src="Content/js/bootstrap.min.js"></script>
    <script src="Content/js/login.js"></script>
</head>
<body>
    <div id="login-form" class="container">
            <div class="col-md-6 center-block">
                <div class="jumbotron">
                    <div class="form-group" id="header">
                        <h1>Log In</h1>
                    </div>
                    <hr />
                        <div class="form-group input-group">
                            <span class="input-group-addon">
                                <span class="fa fa-envelope"></span>
                            </span>
                            <input runat="server" id="loginUserEmail" class="form-control" type="email" name="userEmail" placeholder="Email" required="required" />
                            <span class="input-group-addon warn hidden" id="loginEmptyEmail">Complete this field</span>
                            <span class="input-group-addon warn hidden" id="wrongEmail">Email not found</span>
                        </div>
                        <div class="form-group input-group">
                            <span class="input-group-addon">
                                <span class="fa fa-lock" style="font-size: 20px;"></span>
                            </span>
                            <input runat="server" id="loginUserPassword" class="form-control" type="password" name="userPassword" placeholder="Password" required="required" />
                            <span class="input-group-addon warn hidden" id="loginEmptyPassword">Complete this field</span>
                            <span class="input-group-addon warn hidden" id="wrongPassword">Wrong password</span>
                        </div>
                        <div class="form-group">
                            <button class="btn custom-btn-red btn-block" onclick="userLogin()">Log In</button>
                        </div>
                </div>
            </div>
        </div>
</body>
</html>
