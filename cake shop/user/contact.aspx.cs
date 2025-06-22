using System;
using System.Data.SqlClient;

namespace cake_shop.user
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

        //protected void SubmitForm(object sender, EventArgs e)
        //{
        //    // Get the form data
        //    string name = txtName.Value;
        //    string email = txtEmail.Value;
        //    string message = txtMessage.Value;

        //    // Database connection string (replace with your actual credentials)
        //    string connectionString = "Server=localhost; Database=cakashop; Uid=root; Pwd=yourpassword;";

        //    try
        //    {
        //        // Open a connection to the database
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();

        //            // SQL query to insert form data into the ContactUs table
        //            string query = "INSERT INTO ContactUs (Name, Email, Message) VALUES (@Name, @Email, @Message)";

        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                // Add parameters to prevent SQL injection
        //                cmd.Parameters.AddWithValue("@Name", name);
        //                cmd.Parameters.AddWithValue("@Email", email);
        //                cmd.Parameters.AddWithValue("@Message", message);

        //                // Execute the query
        //                cmd.ExecuteNonQuery();
        //            }
        //        }

        //        // Display success message
        //        msg.InnerHtml = "Thank you for your message! We will get back to you soon.";
        //        msg.Style["color"] = "green";
        //    }
        //    catch (Exception ex)
        //    {
        //        // Display error message
        //        msg.InnerHtml = "Error: " + ex.Message;
        //        msg.Style["color"] = "red";
        //    }
        //}
    }



    

