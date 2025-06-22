using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class add : System.Web.UI.Page
    {


        private string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected void btnShowForm_Click(object sender, EventArgs e)
        {
            cakeForm.Visible = true; // Set the panel containing the form to be visible
        }


        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            string name = txtCakeName.Text;
            string category = txtCategory.Text;
            decimal weight = Convert.ToDecimal(txtWeight.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string description = txtDescription.Text;
            string imagePath = null;

            if (fileUpload.HasFile)
            {
                string fileName = Path.GetFileName(fileUpload.FileName);
                string folderPath = Server.MapPath("../img/");
                Directory.CreateDirectory(folderPath); // Ensure folder exists
                fileUpload.SaveAs(Path.Combine(folderPath, fileName));
                imagePath = "../img/" + fileName;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AddCake (CakeName, Category, Weight, Price, Description, ImagePath) VALUES (@CakeName, @Category, @Weight, @Price, @Description, @ImagePath)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CakeName", name);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Weight", weight);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@ImagePath", (object)imagePath ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            Response.Write("<script>alert('Cake added successfully!');</script>");
            LoadData();
            txtCakeName.Text = "";
            txtCategory.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtWeight.Text = "";
           
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AddCake";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridViewCakes.DataSource = table;
                gridViewCakes.DataBind();
            }
        }

        protected void gridViewCakes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                gridViewCakes.EditIndex = e.NewEditIndex; // Set the row index to edit mode
                LoadData(); // Reload data to refresh the GridView
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while entering edit mode: " + ex.Message;
            }
        }

        //  protected void gridViewCakes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //  {
        //      try
        //      {
        //          // Retrieve the Id of the row being updated
        //          int id = Convert.ToInt32(gridViewCakes.DataKeys[e.RowIndex].Value);

        //          // Retrieve new values from the edit controls in the GridView row
        //          GridViewRow row = gridViewCakes.Rows[e.RowIndex];
        //          string cakeName = (row.FindControl("txtEditCakeName") as TextBox)?.Text;
        //          string category = (row.FindControl("txtEditCategory") as TextBox)?.Text;
        //          decimal weight = Convert.ToDecimal((row.FindControl("txtEditWeight") as TextBox)?.Text);
        //          decimal price = Convert.ToDecimal((row.FindControl("txtEditPrice") as TextBox)?.Text);
        //          string description = (row.FindControl("txtEditDescription") as TextBox)?.Text;

        //          // Update the record in the database
        //          using (SqlConnection connection = new SqlConnection(connectionString))
        //          {
        //              string query = @"UPDATE AddCake 
        //                               SET CakeName = @CakeName, 
        //                                   Category = @Category, 
        //                                   Weight = @Weight, 
        //                                   Price = @Price, 
        //                                   Description = @Description 
        //                               WHERE Id = @Id";

        //              using (SqlCommand command = new SqlCommand(query, connection))
        //              {
        ////                  command.Parameters.AddWithValue("@Id", id);
        ////                  command.Parameters.AddWithValue("@CakeName", cakeName);
        ////                  command.Parameters.AddWithValue("@Category", category);
        ////                  command.Parameters.AddWithValue("@Weight", weight);
        ////                  command.Parameters.AddWithValue("@Price", price);
        ////                  command.Parameters.AddWithValue("@Description", description);

        ////                  connection.Open();
        ////                  command.ExecuteNonQuery();
        //              }
        //           }

        //           // Exit edit mode
        //          gridViewCakes.EditIndex = -1;
        //          LoadData(); // Reload the GridView with updated data
        //}
        //      catch (Exception ex)
        //      {
        //          lblErrorMessage.Text = "An error occurred while updating the row: " + ex.Message;
        //      }
        //  }

        // This method is triggered when the user clicks on the "Edit" button.
        //protected void gridViewCakes_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    gridViewCakes.EditIndex = e.NewEditIndex;  // Set the row in edit mode
        //    /*LoadData*/();  // Reload data into the GridView
        //}

        // This method is triggered when the user clicks on the "Update" button.
        protected void gridViewCakes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                // Retrieve the Id of the row being updated
                int id = Convert.ToInt32(gridViewCakes.DataKeys[e.RowIndex].Value);

                // Retrieve new values from the edit controls in the GridView row
                GridViewRow row = gridViewCakes.Rows[e.RowIndex];
                string cakeName = (row.FindControl("txtEditCakeName") as TextBox).Text;
                string category = (row.FindControl("txtEditCategory") as TextBox).Text;
                decimal weight = Convert.ToDecimal((row.FindControl("txtEditWeight") as TextBox).Text);
                decimal price = Convert.ToDecimal((row.FindControl("txtEditPrice") as TextBox).Text);
                string description = (row.FindControl("txtEditDescription") as TextBox).Text;

                // Update the record in the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE AddCake 
                             SET CakeName = @CakeName, 
                                 Category = @Category, 
                                 Weight = @Weight, 
                                 Price = @Price, 
                                 Description = @Description 
                             WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@CakeName", cakeName);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Description", description);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Exit edit mode
                gridViewCakes.EditIndex = -1;
                LoadData(); // Reload the GridView with updated data
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while updating the row: " + ex.Message;
            }
        }

        // This method is triggered when the user clicks on the "Cancel" button during editing.
        //protected void gridViewCakes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        //{
        //    gridViewCakes.EditIndex = -1;  // Exit edit mode
        //    /*LoadData()*/;  // Reload the data into the GridView
        //}






        protected void gridViewCakes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Retrieve the Id of the row to delete
                int id = Convert.ToInt32(gridViewCakes.DataKeys[e.RowIndex].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM AddCake WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Reload GridView after deletion
                LoadData();
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while deleting the row: " + ex.Message;
            }
        }

        protected void gridViewCakes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                // Exit edit mode
                gridViewCakes.EditIndex = -1;
                LoadData(); // Reload the GridView
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = "An error occurred while canceling edit mode: " + ex.Message;
            }
        }





    }
}
