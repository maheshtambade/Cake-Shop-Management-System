<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="myorders.aspx.cs" Inherits="cake_shop.user.myorders" %>
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

        .cancelbtn{
            height:50px;
            text-align:center;
            background-color:red;
            color:white;
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

    <%-- <form id="form1" runat="server">--%>
       <%-- <h1>My Orders</h1>
        <asp:GridView ID="OrdersGrid" runat="server" AutoGenerateColumns="False" CssClass="styled-table" 
                      OnRowCommand="OrdersGrid_RowCommand" HeaderStyle-CssClass="header-row" 
                      RowStyle-CssClass="data-row">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Weight" HeaderText="Weight (kg)" />
                <asp:BoundField DataField="Price" HeaderText="Price ($)" />
                <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:ButtonField CommandName="CancelOrder" ButtonType="Button" Text="Cancel" />
            </Columns>
        </asp:GridView>--%>
    <%--</form>--%>

    <%--<asp:GridView ID="OrdersGrid" runat="server" AutoGenerateColumns="False" OnRowCommand="OrdersGrid_RowCommand" DataKeyNames="CakeName" CssClass="styled-table">
    <Columns>
        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="Weight" HeaderText="Weight (kg)" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="CancelOrderButton" runat="server" CommandName="CancelOrder" CommandArgument='<%# Container.DataItemIndex %>' Text="Cancel" CssClass="cancelbtn" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>--%>


    <div class="orders-container">
    <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" CssClass="orders-grid">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Username" />
            <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
            <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:BoundField DataField="PaymentPrice" HeaderText="Price" DataFormatString="{0:C}" />
            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" DataFormatString="{0:MM/dd/yyyy}" />
            <asp:BoundField DataField="CardName" HeaderText="Cardholder Name" />
            <asp:BoundField DataField="CardNumber" HeaderText="Card Number" />
            <asp:BoundField DataField="ExpiryDate" HeaderText="Expiry Date" />
            <asp:BoundField DataField="DeliveryAddress" HeaderText="Delivery Address" />
        </Columns>
    </asp:GridView>
</div>


</asp:Content>
