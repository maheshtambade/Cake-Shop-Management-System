<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="notification.aspx.cs" Inherits="cake_shop.user.notification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet">



</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- <div class="container mt-5">
        <h2 class="mb-4">Notifications</h2>
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Cake Name</th>
                    <th>Notification</th>
                </tr>
            </thead>
            <tbody>
                <%-- Notification rows will be populated here --%>
               <%-- <% foreach (var notification in Notifications) { %>
                    <tr>
                        <td><%= notification.CreatedDate.ToString("yyyy-MM-dd HH:mm") %></td>
                        <td><%= notification.CakeName %></td>
                        <td><%= notification.NotificationText %></td>
                    </tr>
                <% } %>
            </tbody>
        </table>
    </div>--%>



    <div class="container mt-5">
        <h2 class="mb-4">Your Notifications</h2>
        <asp:GridView ID="NotificationsGridView" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CreatedDate" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd HH:mm}" />
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="NotificationText" HeaderText="Notification" />
            </Columns>
        </asp:GridView>
    </div>









</asp:Content>
