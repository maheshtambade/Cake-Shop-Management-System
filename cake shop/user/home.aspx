<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="cake_shop.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  


  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <!-- Bootstrap CSS -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/about.css" />
 <style>
    .carousel-item img {
      height: 90vh;
      object-fit: cover;
    }
    .carousel-caption {
      background: rgba(0, 0, 0, 0.5);
      padding: 15px;
      border-radius: 10px;
    }
    #cakeCarousel{
        margin-top:0px;
        transform:translateY(-20px);
    }
  </style>





</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <div id="cakeCarousel" class="carousel slide" data-bs-ride="carousel">
    <!-- Indicators -->
    <div class="carousel-indicators">
      <button type="button" data-bs-target="#cakeCarousel" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Chocolate Cake"></button>
      <button type="button" data-bs-target="#cakeCarousel" data-bs-slide-to="1" aria-label="Vanilla Cake"></button>
      <button type="button" data-bs-target="#cakeCarousel" data-bs-slide-to="2" aria-label="Red Velvet Cake"></button>
    </div>

    <!-- Carousel Items -->
    <div class="carousel-inner">
      
         <div class="carousel-item active">
   <img src="../images/red velvet.jpg" class="d-block w-100" alt="Red Velvet Cake">
   <div class="carousel-caption">
     <h3>Red Velvet Cake</h3>
     <p>A perfect blend of cocoa and vanilla with cream cheese frosting.</p>
   </div>
 </div>


      <div class="carousel-item">
        <img src="../images/vanilla cake.jpg" class="d-block w-100" alt="Vanilla Cake">
        <div class="carousel-caption">
          <h3>Vanilla Cake</h3>
          <p>Classic vanilla flavor with a soft and fluffy texture.</p>
        </div>
      </div>

     

        <div class="carousel-item ">
        <img src="../images/chocolate cake.jpg" class="d-block w-100" alt="Chocolate Cake">
        <div class="carousel-caption">
        <h3>Chocolate Cake</h3>
        <p>Rich and creamy chocolate delight for all occasions.</p>
       </div>
     </div>
    </div>

    <!-- Controls -->
    <button class="carousel-control-prev" type="button" data-bs-target="#cakeCarousel" data-bs-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#cakeCarousel" data-bs-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="visually-hidden">Next</span>
    </button>
  </div>

  <!-- Bootstrap JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>



   
        
   





     <section id="product1" class="section-p1">
      <h2>BEST SELLER</h2>
      <p>Delicious cakes at affordable prices</p>
<a href="/user/shop.aspx">
      <div class="pro-cont js-pro-cont"></div>
</a>
    </section>

    <section id="banner">
      <h2>Up to <span>30% Off</span> on All Cakes & Decoratives</h2>
      <button class="button-normal">EXPLORE MORE</button>
    </section>

    <%--<section id="chotu1banner" class="section-p1">
      <div class="bannerbox">
        <h4>Crazy Deals</h4>
        <h3>Buy 1 cake get 2 cucakes free</h3>
        <span>Great offers are on Cakes at this cake shop</span>
        <button class="button-transparent">Learn More</button>
      </div>

      <div class="bannerbox">
        <h4>Summer Special</h4>
        <h3>Upcomming Cakes</h3>
        <span>Great offers are on Cakes at this cake shop</span>
        <button class="button-transparent">Collection</button>
      </div>
    </section>--%>

    <section id="banner3" class="section-p1">
      <div class="bannerbox">
        <h2>Cupcakes</h2>
        <h3>Customized / Flavoured Cupcakes</h3>
      </div>

      <div class="bannerbox">
        <h2>Doughnuts</h2>
        <h3>Flavoured Doughnuts</h3>
      </div>

      <div class="bannerbox">
        <h2>Brownies</h2>
        <h3>Delicious Brownies</h3>
      </div>
    </section>

   <%-- <section id="newslater">
      <div class="newstxt">
        <h4>Sign up for Newsletters</h4>
        <p>Get E-mail updates about our latest cakes and special offers.</p>
      </div>
      <div class="form">
        <input type="text" placeholder="Your E-mail Address" />
        <button>Sign Up</button>
      </div>
    </section>--%>


    <script src="../js/cart.js"></script>
    <script src="../js/products.js"></script>
    <script src="../js/home.js"></script>


</asp:Content>

