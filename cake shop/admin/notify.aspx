<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="notify.aspx.cs" Inherits="cake_shop.admin.notify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet">



</asp:Content>






<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
    <div class="container mt-5">
        <h2 class="mb-4">Create Notification</h2>
        <asp:Panel ID="NotifyPanel" runat="server" CssClass="form-group">
            <asp:Label ID="UsernameLabel" runat="server" Text="Username" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="UsernameTextBox" runat="server" CssClass="form-control" Required="true"></asp:TextBox>

            <asp:Label ID="CakeNameLabel" runat="server" Text="Cake Name" CssClass="form-label mt-3"></asp:Label>
            <asp:TextBox ID="CakeNameTextBox" runat="server" CssClass="form-control" Required="true"></asp:TextBox>

            <asp:Label ID="NotificationLabel" runat="server" Text="Notification" CssClass="form-label mt-3"></asp:Label>
            <asp:TextBox ID="NotificationTextBox" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5" Required="true"></asp:TextBox>

            <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn btn-primary mt-3" OnClick="SubmitNotification_Click" />
        </asp:Panel>
    </div>
        </form>
</asp:Content>
