<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="cake_shop.guest.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
        }
        .login-form {
            max-width: 400px;
            margin: auto;
            background: #f1f1f1;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
    </style>

</asp:Content>







<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <%--  <form id="form1" runat="server">--%>
        <div class="d-flex justify-content-center align-items-center vh-100">
            <div class="login-form">
                <h4 class="text-center mb-4">Login</h4>
                <div class="mb-3">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary w-100" OnClick="btnLogin_Click" />
                <div class="mt-3 text-center">
                    <p>Don't have an account? <a href="../guest/register.aspx">Register</a></p>
                </div>
            </div>
        </div>
    <%--</form>--%>
</asp:Content>
