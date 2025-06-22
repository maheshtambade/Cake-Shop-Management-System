<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="cake_shop.user.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%--<form id="form1" runat="server" class="container mt-5">--%>
        <div class="card">
            <div class="card-header bg-primary text-white">Register</div>
            <div class="card-body">
                <div class="form-group">
                    <label for="FullName">Full Name</label>
                    <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" Placeholder="Enter your full name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Email">Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Placeholder="Enter your email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Password">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" Placeholder="Enter your password"></asp:TextBox>
                </div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary btn-block" OnClick="btnRegister_Click" />
            </div>
        </div>
    <%--</form>--%>

    <script>
        function showPopup(message) {
            alert(message);
        }
    </script>


</asp:Content>
