using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.guest
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Input Validation
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('All fields are required!');", true);
                return;
            }

            // Connection string (update with your database credentials)
            string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Contact (FirstName, LastName, PhoneNumber, Address, Email) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber, @Address, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                       
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Your information has been submitted successfully!');", true);

                        txtFirstName.Text = string.Empty;
                        txtLastName.Text = string.Empty;
                        txtPhoneNumber.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtEmail.Text = string.Empty;


                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Submission failed. Please try again!');", true);
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
    