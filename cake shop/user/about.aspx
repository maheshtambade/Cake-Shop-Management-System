<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="cake_shop.user.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>About Us</title>
    <%--<link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Poppins&display=swap"
      rel="stylesheet"
    />--%>
    <link rel="stylesheet" href="../css/about.css" />
   <%-- <script
      src="https://kit.fontawesome.com/eedbcd0c96.js"
      crossorigin="anonymous"
    ></script>--%>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <section id="pageheader" class="aboutheader">
      <h2>#KnowUs</h2>
      <p>Serving Sweet Delights: Discover the Story Behind Our Cake Shop</p>
    </section>

    <div id="aboutdiv" class="section-p1">
      <img src="../images/about.jpeg" alt="" />
      <div>
        <h2>Who are we ?</h2>
        <p>
          At our Cake Shop, we are a team of dedicated and passionate
          bakers on a mission to create unforgettable cake experiences. With our
          expertise and love for baking, we pour our hearts into crafting the
          most delicious and visually stunning cakes for every occasion. From
          elegant wedding cakes to whimsical birthday creations, we believe that
          every celebration deserves a centerpiece that not only looks
          incredible but also tastes divine. Using only the finest ingredients,
          we meticulously bake and decorate each cake to perfection, ensuring
          that every bite is a moment of pure indulgence. We are committed to
          exceeding your expectations, bringing smiles to faces, and creating
          memories that last a lifetime with our delectable creations. Welcome
          to our cake shop, where sweetness and creativity blend harmoniously to
          delight your senses.
        </p>

        <marquee behavior="" direction=""
          >Where Every Slice is a Sweet Delight - Welcome to  Cake
          Shop</marquee
        >
      </div>
    </div>

    <section id="feature" class="section-p1">
      <div class="featurebox">
        <img src="../images/fs.png" alt="" class="fsimg" />
        <h4>Free Shipping</h4>
      </div>
      <div class="featurebox">
        <img src="../images/oo.png" alt="" class="fsimg" />
        <h4>Order Online</h4>
      </div>
      <div class="featurebox">
        <img src="../images//sm.png" alt="" class="fsimg" />
        <h4>Save Money</h4>
      </div>
      <div class="featurebox">
        <img src="../images/pp.png" alt="" class="fsimg" />
        <h4>Promotions</h4>
      </div>
      <div class="featurebox">
        <img src="../images/hs.png" alt="" class="fsimg" />
        <h4>Happy Sell</h4>
      </div>
      <div class="featurebox">
        <img src="../images/tss.png" alt="" class="fsimg" />
        <h4>24/7 Support</h4>
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
    
         
        

      

   
</asp:Content>
