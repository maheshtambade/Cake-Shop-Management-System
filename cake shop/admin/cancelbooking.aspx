<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="cancelbooking.aspx.cs" Inherits="cake_shop.admin.cancelbooking" %>
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
            background-color: #ff0000;
            color: white;
            font-weight: bold;
        }

        .data-row:hover {
            background-color: #f1f1f1;
        }
    </style>
    

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
   <asp:GridView ID="CanceledOrdersGrid" runat="server" AutoGenerateColumns="False" CssClass="styled-table"
              HeaderStyle-CssClass="header-row" RowStyle-CssClass="data-row">
    <Columns>
        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:BoundField DataField="Category" HeaderText="Category" />
        <asp:BoundField DataField="Weight" HeaderText="Weight (kg)" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="Username" HeaderText="Username" />
        <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="CanceledDate" HeaderText="Canceled Date" DataFormatString="{0:yyyy-MM-dd HH:mm:ss}" />
    </Columns>
     </asp:GridView>
        </form>
</asp:Content>
