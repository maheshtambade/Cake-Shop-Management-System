using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if session exists; redirect to dashboard if already logged in
            if (Session["AdminUsername"] != null)
            {
                Response.Redirect("../admin/dashboard.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM AdminCredentials WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        // Set session and redirect
                        Session["AdminUsername"] = username;
                        Response.Redirect("../admin/dashboard.aspx");
                    }
                    else
                    {
                        // Trigger JavaScript alert with a simple alert() function
                        ClientScript.RegisterStartupScript(this.GetType(), "InvalidAlert", "alert('Invalid username or password.');", true);
                    }
                }
            }
        }
    }
}
