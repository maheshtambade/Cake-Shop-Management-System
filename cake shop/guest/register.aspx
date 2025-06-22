<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="cake_shop.guest.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
        }
        .register-form {
            max-width: 400px;
            margin: auto;
            background: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
    </style>
</asp:Content>











<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <%--<form id="form1" runat="server">--%>
        <div class="d-flex justify-content-center align-items-center vh-100">
            <div class="register-form">
                <h4 class="text-center mb-4">Register</h4>
                <div class="mb-3">
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="First Name"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Last Name"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary w-100" OnClick="btnRegister_Click" />
                <div class="mt-3 text-center">
                    <p>Already have an account? <a href="../guest/login.aspx">Login</a></p>
                </div>
            </div>
        </div>
  <%--  </form>--%>

</asp:Content>
