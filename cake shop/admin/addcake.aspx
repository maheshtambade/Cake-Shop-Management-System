<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addcake.aspx.cs" Inherits="cake_shop.admin.addcake" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


     <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
     <script>
         function showForm() {
             document.getElementById("cakeForm").style.display = "block";
         }
 </script>





</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <%--  <form id="form1" runat="server">--%>
      <%-- <%-- <div class="container mt-5">
            <h2>Add Cake</h2>
            <asp:Button ID="btnShowForm" runat="server" Text="Add Cake" CssClass="btn btn-primary mb-3" OnClick="btnShowForm_Click" />

            <!-- Add Cake Form -->
            <div id="cakeForm" runat="server" style="display:none;">
                <div class="form-group">
                    <label for="txtCakeName">Cake Name:</label>

                    <%--<asp:TextBox ID="txtCakeName" runat="server" CssClass="form-control" />--%>
              <%--  </div>
         

                <div class="form-group">
                    <label for="txtCategory">Category:</label>
                    <asp:TextBox ID="txtCategory" runat="server" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <label for="txtWeight">Weight (kg):</label>
                    <asp:TextBox ID="txtWeight" runat="server" CssClass="form-control" TextMode="Number" />
                </div>

                <div class="form-group">
                    <label for="txtPrice">Price:</label>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" TextMode="Number" />
                </div>

                <div class="form-group">
                    <label for="txtDescription">Description:</label>
                    <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" TextMode="MultiLine" />
                </div>

                <div class="form-group">
                    <label for="fileUpload">Upload Image:</label>
                    <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control" />
                </div>

                <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" CssClass="btn btn-success" OnClick="btnAddCake_Click" />
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" />
            </div>--%>--%>--%>

           <%-- <!-- GridView to display data -->
            <asp:GridView ID="gridViewCakes" runat="server" AutoGenerateColumns="False" CssClass="table table-striped mt-5" OnRowEditing="gridViewCakes_RowEditing" OnRowDeleting="gridViewCakes_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                    <asp:BoundField DataField="Category" HeaderText="Category" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight (kg)" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="ImagePath" HeaderText="Image Path" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>--%>
       <%-- </div>--%>
 <%--   </form>--%>
      
    


</asp:Content>
