using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class addcake : System.Web.UI.Page
    {


        //private string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;Encrypt=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    //LoadData();
            //}
        }



        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            //    string name = txtCakeName.Text;
            //    string category = txtCategory.Text;
            //    decimal weight = Convert.ToDecimal(txtWeight.Text);
            //    decimal price = Convert.ToDecimal(txtPrice.Text);
            //    string description = txtDescription.Text;
            //    string imagePath = null;

            //    if (fileUpload.HasFile)
            //    {
            //        string fileName = Path.GetFileName(fileUpload.FileName);
            //        string folderPath = Server.MapPath("~/Imagess/");
            //        Directory.CreateDirectory(folderPath); // Ensure folder exists
            //        fileUpload.SaveAs(Path.Combine(folderPath, fileName));
            //        imagePath = "~/Imagess/" + fileName;
            //    }

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        string query = "INSERT INTO AddCake (CakeName, Category, Weight, Price, Description, ImagePath) VALUES (@CakeName, @Category, @Weight, @Price, @Description, @ImagePath)";
            //        SqlCommand command = new SqlCommand(query, connection);
            //        command.Parameters.AddWithValue("@CakeName", name);
            //        command.Parameters.AddWithValue("@Category", category);
            //        command.Parameters.AddWithValue("@Weight", weight);
            //        command.Parameters.AddWithValue("@Price", price);
            //        command.Parameters.AddWithValue("@Description", description);
            //        command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        connection.Close();
            //    }

            //    Response.Write("<script>alert('Cake added successfully!');</script>");
            //    //LoadData();
            //}

            //private void LoadData()
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        string query = "SELECT * FROM AddCake";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //        DataTable table = new DataTable();
            //        adapter.Fill(table);
            //        gridViewCakes.DataSource = table;
            //        gridViewCakes.DataBind();
            //    }
            //}

            //protected void gridViewCakes_RowEditing(object sender, GridViewEditEventArgs e)
            //{
            //    gridViewCakes.EditIndex = e.NewEditIndex;
            //    LoadData();
            //}

            //protected void gridViewCakes_RowDeleting(object sender, GridViewDeleteEventArgs e)
            //{
            //    int id = Convert.ToInt32(gridViewCakes.DataKeys[e.RowIndex].Value);

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        string query = "DELETE FROM AddCake WHERE Id = @Id";
            //        SqlCommand command = new SqlCommand(query, connection);
            //        command.Parameters.AddWithValue("@Id", id);

            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        connection.Close();
            //    }

            //    LoadData();
            //}
        }
    }
}




    