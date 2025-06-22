<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="orders.aspx.cs" Inherits="cake_shop.admin.orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .styled-table {
    border-collapse: collapse;
    width: 100%;
    margin: 20px 0;
    font-size: 18px;
    font-family: Arial, sans-serif;
    text-align: left;
    border: 1px solid #ddd;
    border-spacing:5px;
    border-collapse:5px;
}

.styled-table th, .styled-table td {
    padding: 12px 15px;
    border: 1px solid #ddd;
}

.header-row {
    background-color: #007ACC;
    color: white;
    font-weight: bold;
}

.data-row:hover {
    background-color: #f1f1f1;
}
/*#OrdersGrid
{
    margin-left:0px auto;
}
  */      

h1{
    text-align:center;
}

 .gridview-header {
            background-color: green;
            color: white;
        }

     .orders-grid {
    width: 100%;
    border-collapse: collapse;
    margin: 20px 0;
    font-size: 18px;
    text-align: left;
}

.orders-grid th {
    background-color: blue;
    color: white;
    padding: 10px;
    border: 1px solid black;
}

.orders-grid td {
    padding: 10px;
    border: 1px solid black;
}

.orders-grid tr:nth-child(even) {
    background-color: #f2f2f2;
}
    </style>

</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <form id="form1" runat="server">
        <%--<h1>Order Details</h1>
        <asp:GridView ID="OrdersGrid" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#007ACC" HeaderStyle-ForeColor="White" class="styled-table">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Category" HeaderText="Category" />
                <asp:BoundField DataField="Weight" HeaderText="Weight (kg)" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="FullName" HeaderText="Full Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" DataFormatString="{0:yyyy-MM-dd}" />
            </Columns>
        </asp:GridView>--%>

           <asp:GridView ID="GridViewPayment" runat="server" AutoGenerateColumns="true" HeaderStyle-CssClass="gridview-header" CssClass="orders-grid" />
    </form>

</asp:Content>
