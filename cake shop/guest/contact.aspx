<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="cake_shop.guest.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
        }
        .contact-form {
            max-width: 50%;
            margin: auto;
            background: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        .contact-form h1 {
            font-family: 'Arial', sans-serif;
            font-weight: bold;
            text-align: center;
            margin-bottom: 20px;
        }
    </style>


  




</asp:Content>






<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




      <%--<form id="form1" runat="server">--%>
      <div class="d-flex justify-content-center align-items-center vh-100">
          <div class="contact-form">
              <h1>Contact Us</h1>
              <div class="mb-3">
                  <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="First Name"></asp:TextBox>
              </div>
              <div class="mb-3">
                  <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Last Name"></asp:TextBox>
              </div>
              <div class="mb-3">
                  <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
              </div>
              <div class="mb-3">
                  <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Address"></asp:TextBox>
              </div>
              <div class="mb-3">
                  <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
              </div>
              <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary w-100" OnClick="btnSubmit_Click" />
          </div>
      </div>
  <%--</form>--%>


</asp:Content>
