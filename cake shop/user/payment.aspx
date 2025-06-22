<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="cake_shop.user.payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
     .payment-container {
         margin: 20px auto;
         padding: 20px;
         max-width: 400px;
         background: #fff;
         border-radius: 8px;
         box-shadow: 0 2px 5px rgba(0, 0, 0, 0.2);
     }

     .payment-container h2 {
         margin-bottom: 15px;
         color: #333;
     }

     .payment-container label {
         display: block;
         margin-bottom: 5px;
         font-weight: bold;
     }

     .payment-container input {
         width: 100%;
         margin-bottom: 15px;
         padding: 10px;
         border: 1px solid #ddd;
         border-radius: 4px;
     }

     .payment-container .btn-pay {
         background-color: #28a745;
         color: #fff;
         padding: 10px 20px;
         border: none;
         border-radius: 4px;
         cursor: pointer;
         display: block;
         width: 100%;
     }

     .payment-container .btn-pay:hover {
         background-color: #218838;
     }
     a{
         text-decoration:none;
     }
 </style>

    <script>
    window.onload = function() {
        alert("After successful payment, you cannot cancel your order.");
    };
</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <div class="payment-container">
    <h2>Payment Details</h2>
    <asp:Label ID="lblCakeDetails" runat="server"></asp:Label>
    <asp:TextBox ID="txtCardName" runat="server" Placeholder="Cardholder Name"></asp:TextBox>
    <asp:TextBox ID="txtCardNumber" runat="server" Placeholder="Card Number"></asp:TextBox>
    <asp:TextBox ID="txtExpiryDate" runat="server" Placeholder="Expiry Date (MM/YY)"></asp:TextBox>
    <asp:TextBox ID="txtCVV" runat="server" Placeholder="CVV"></asp:TextBox>
    <asp:TextBox ID="txtDeliveryAddress" runat="server" Placeholder="Delivery Address"></asp:TextBox>
    <asp:Button ID="btnPay" runat="server" Text="Pay Now" CssClass="btn-pay" OnClick="SubmitPayment" />
   <asp:Button ID="btnRedirect" runat="server" Text="Go to Home" CssClass="btn-pay" OnClick="btnRedirect_Click" />

</div>
        </div>
    </form>
</body>
</html>
