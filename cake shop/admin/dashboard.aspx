<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="cake_shop.admin.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


  <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap" rel="stylesheet">
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>
    body {
      margin: 0;
      font-family: 'Poppins', sans-serif;
      background-color: lightslategray;
      overflow:hidden;
    }

    .dashboard-header{
      background-color:;
      padding: 20px 0;
      text-align: center;
      width:1100px;
    }

    .header-content{
      width: 100%;
      margin: 0 auto;
      color: black;
    }

    .dashboard-title{
      font-size: 2.5rem;
      font-weight: bold;
      letter-spacing: 1.5px;
      margin: 0;
     
    }

    .bg-skyblue{
    background-color:#0A5EB0;
     }

    .card{
    border-radius:10px;
    }

    .shadow-lg{
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    }

    .card-header{
    font-weight: bold;
    text-transform: uppercase;
    }

     .card-title{
            font-size: 24px;
            font-weight: bold;
            margin-top: 15px;
        }

  </style>

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


     <header class="dashboard-header" style="background-color:;">
    <div class="header-content">
      <h1 class="dashboard-title">Admin Dashboard</h1>
    </div>
  </header> 
  <%-- <div class="container mt-5">
    <div class="row justify-content-center">
        <!-- Total Users Card -->
        <div class="col-md-3">
            <div class="card text-center shadow-lg rounded">
                <div class="card-header bg-skyblue text-white">
                    Total Users
                </div>
                <div class="card-body">
                    <h5 class="card-title" id="lblTotalUsers">0</h5>
                </div>
            </div>
        </div>

        <!-- Cakes Card -->
        <div class="col-md-3">
            <div class="card text-center shadow-lg rounded">
                <div class="card-header bg-skyblue text-white">
                    Cakes
                </div>
                <div class="card-body">
                    <h5 class="card-title" id="lblCakes">0</h5>
                </div>
            </div>
        </div>

        <!-- Bookings Card -->
        <div class="col-md-3">
            <div class="card text-center shadow-lg rounded">
                <div class="card-header bg-skyblue text-white">
                    Bookings
                </div>
                <div class="card-body">
                    <h5 class="card-title" id="lblBookings">0</h5>
                </div>
            </div>
        </div>

        <!-- Cancel Bookings Card -->
        <div class="col-md-3">
            <div class="card text-center shadow-lg rounded">
                <div class="card-header bg-skyblue text-white">
                    Cancel Bookings
                </div>
                <div class="card-body">
                    <h5 class="card-title" id="lblCancelBookings">0</h5>
                </div>
            </div>
        </div>
    </div>
</div>--%>


   <%-- <form id="form1" runat="server">--%>
        <div class="container mt-5">
            <div class="row justify-content-center">
                <!-- Total Users Card -->
                <div class="col-md-3">
                    <div class="card text-center shadow-lg rounded">
                        <div class="card-header bg-skyblue" style="background-color:#0A5EB0;color:white;">
                            Total Users
                        </div>
                        <div class="card-body">
                            <asp:Label ID="lblTotalUsers" runat="server" CssClass="card-title">0</asp:Label>
                        </div>
                    </div>
                </div>

                <!-- Cakes Card -->
                <div class="col-md-3">
                    <div class="card text-center shadow-lg rounded">
                        <div class="card-header bg-skyblue" style="background-color:#0A5EB0;color:white;">
                            Cakes
                        </div>
                        <div class="card-body">
                            <asp:Label ID="lblCakes" runat="server" CssClass="card-title">0</asp:Label>
                        </div>
                    </div>
                </div>

                <!-- Bookings Card -->
                <div class="col-md-3">
                    <div class="card text-center shadow-lg rounded">
                        <div class="card-header bg-skyblue" style="background-color:#0A5EB0;color:white;">
                            Bookings
                        </div>
                        <div class="card-body">
                            <asp:Label ID="lblBookings" runat="server" CssClass="card-title">0</asp:Label>
                        </div>
                    </div>
                </div>

                <!-- Cancel Bookings Card -->
               <%-- <div class="col-md-3">
                    <div class="card text-center shadow-lg rounded">
                        <div class="card-header bg-skyblue" style="background-color:#0A5EB0;color:white;">
                            Cancel Bookings
                        </div>
                        <div class="card-body">
                            <asp:Label ID="lblCancelBookings" runat="server" CssClass="card-title">0</asp:Label>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
  <%--  </form>--%>
</asp:Content>
