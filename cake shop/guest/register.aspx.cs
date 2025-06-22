using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.guest
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
           
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Input Validation
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('All fields are required!');", true);
                    return;
                }

                // Connection string (update with your database credentials)
                string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO RegisterUser (FullName, LastName, Username, Password) VALUES (@FullName, @LastName, @Username, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@FullName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registration successful!');", true);
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    
                    
                    }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Registration failed. Please try again!');", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
                    }
                }
            }
        }
    }
