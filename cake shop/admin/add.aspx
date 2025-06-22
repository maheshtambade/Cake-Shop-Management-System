<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="cake_shop.admin.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        #change{
            padding:8px;
            text-align:center;
            background-color:red;
            color:white;
        }
    </style>
    
     <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
     <script>
         function showForm() {
             document.getElementById("cakeForm").style.display = "block";
         }
     </script>


</head>
<body>
    <form id="form1" runat="server">
        <div>





             <div class="container mt-5">
     <h2>Add Cake</h2>
                
                  
                     
                 
                  <button type="button" class="btn btn-primary mb-3" onclick="showForm()">Add Cake</button>
    <%-- <asp:Button ID="btnShowForm" runat="server" Text="Add Cake" CssClass="btn btn-primary mb-3" OnClick="showForm()" />--%>
                <%-- <asp:Button ID="Button1" runat="server" Text="Add Cake" CssClass="btn btn-primary mb-3" OnClick="btnShowForm_Click" />--%>
                 <a href="dashboard.aspx" id="change">Go to Dashboard</a>
                 

     <!-- Add Cake Form -->
     <div id="cakeForm" runat="server" style="display:none;">
         <div class="form-group">
             <label for="txtCakeName">Cake Name:</label>

             <asp:TextBox ID="txtCakeName" runat="server" CssClass="form-control" />
         </div>
  

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
     </div>
       </div>


        </div>


       
          <!-- GridView to display data -->
 <%-- <asp:GridView ID="gridViewCakes" runat="server" AutoGenerateColumns="False" CssClass="table table-striped mt-5" OnRowEditing="gridViewCakes_RowEditing" OnRowDeleting="gridViewCakes_RowDeleting" OnRowUpdating="gridViewCakes_RowUpdating"  OnRowCancelingEdit="gridViewCakes_RowCancelingEdit"  DataKeyNames="Id" >
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


        <asp:GridView ID="gridViewCakes" runat="server" AutoGenerateColumns="False" CssClass="table table-striped mt-5"
    OnRowEditing="gridViewCakes_RowEditing" OnRowDeleting="gridViewCakes_RowDeleting" OnRowUpdating="gridViewCakes_RowUpdating"
    OnRowCancelingEdit="gridViewCakes_RowCancelingEdit" DataKeyNames="Id">
    <Columns>
        
        <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" SortExpression="Id" />

       
        <asp:TemplateField HeaderText="Cake Name" SortExpression="CakeName">
            <ItemTemplate>
                <asp:Label ID="lblCakeName" runat="server" Text='<%# Bind("CakeName") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEditCakeName" runat="server" Text='<%# Bind("CakeName") %>' />
            </EditItemTemplate>
        </asp:TemplateField>

        
        <asp:TemplateField HeaderText="Category" SortExpression="Category">
            <ItemTemplate>
                <asp:Label ID="lblCategory" runat="server" Text='<%# Bind("Category") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEditCategory" runat="server" Text='<%# Bind("Category") %>' />
            </EditItemTemplate>
        </asp:TemplateField>

        
        <asp:TemplateField HeaderText="Weight (kg)" SortExpression="Weight">
            <ItemTemplate>
                <asp:Label ID="lblWeight" runat="server" Text='<%# Bind("Weight") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEditWeight" runat="server" Text='<%# Bind("Weight") %>' />
            </EditItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Price" SortExpression="Price">
            <ItemTemplate>
                <asp:Label ID="lblPrice" runat="server" Text='<%# Bind("Price") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEditPrice" runat="server" Text='<%# Bind("Price") %>' />
            </EditItemTemplate>
        </asp:TemplateField>

       
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
            <ItemTemplate>
                <asp:Label ID="lblDescription" runat="server" Text='<%# Bind("Description") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtEditDescription" runat="server" Text='<%# Bind("Description") %>' TextMode="MultiLine" />
            </EditItemTemplate>
        </asp:TemplateField>

       
        <asp:BoundField DataField="ImagePath" HeaderText="Image Path" SortExpression="ImagePath" ReadOnly="True" />

       
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>





         </form>
    
</body>
</html>
