<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="cake_shop.admin.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
    .center-form {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-card {
            width: 50%;
            max-width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container center-form">
            <div class="card shadow-lg p-4 login-card">
                <h3 class="text-center mb-4">Admin Login</h3>
                <div class="mb-3">
                    <label for="txtUsername" class="form-label">Username</label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtPassword" class="form-label">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                </div>
                <div class="d-grid gap-2">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>

    </form>
     <!-- Custom Script -->
    
</body>
</html>
