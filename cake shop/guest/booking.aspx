<%@ Page Title="" Language="C#" MasterPageFile="~/guest/guest.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="cake_shop.guest.booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <style>
    body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    margin: 0;
    padding: 0;
   
}

.card {
    border: 1px solid #ddd;
    border-radius: 8px;
    margin: 15px;
    padding: 20px;
    width: 300px;
    display: inline-block;
    vertical-align: top;
    background-color: #fff;
    text-align: center;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
}

.cake-image {
    width: 100%;
    height: auto;
    border-radius: 8px;
}

.card h3 {
    color: #333;
    margin: 10px 0;
}

.card p {
    margin: 5px 0;
    color: #555;
}

.btn-book {
    display: inline-block;
    margin-top: 10px;
    padding: 10px 20px;
    background-color: #28a745;
    color: #fff;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

.btn-book:hover {
    background-color: #218838;
}
.parent{
    display:flex;
    flex-wrap:wrap;
    justify-content:center;
}

        </style>


</asp:Content>





<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="parent">
     <asp:Repeater ID="RepeaterCakes" runat="server">
         <ItemTemplate>
             <div class="card">
                 <img src='<%# Eval("ImagePath") %>' alt="Cake Image" class="cake-image" />
                 <h3><%# Eval("CakeName") %></h3>
                 <p><%# Eval("Description") %></p>
                 <p>Category: <%# Eval("Category") %></p>
                 <p>Weight: <%# Eval("Weight") %>kg</p>
                 <p>Price: $<%# Eval("Price") %></p>
                 <asp:Button ID="btnBook" runat="server" Text="Book Now" CommandArgument='<%# Eval("Id") %>' OnCommand="BookCake" CssClass="btn-book" />
             </div>
         </ItemTemplate>
     </asp:Repeater>
     </div>


</asp:Content>
