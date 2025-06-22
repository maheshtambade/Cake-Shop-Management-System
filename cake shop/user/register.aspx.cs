//using System;
//using System.Web.UI;
//using System.Configuration;
//using System.Text.RegularExpressions;
//using System.Data.SqlClient;

//namespace cake_shop.user
//{
//    public partial class register : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {



//        }



//        protected void btnRegister_Click(object sender, EventArgs e)
//        {
//            string fullname = txtFullName.Text.Trim();
//            string email = txtEmail.Text.Trim();
//            string password = txtPassword.Text.Trim();

//            // Validate input fields
//            string validationMessage = ValidateInput(fullname, email, password);
//            if (!string.IsNullOrEmpty(validationMessage))
//            {
//                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", $"showPopup('{validationMessage}');", true);
//                return;
//            }

//            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                string query = "INSERT INTO registeruser (fullname, email, password) VALUES (@FullName, @Email, @Password)";
//                using (SqlCommand cmd = new SqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@FullName", fullname);
//                    cmd.Parameters.AddWithValue("@Email", email);
//                    cmd.Parameters.AddWithValue("@Password", password);

//                    try
//                    {
//                        con.Open();
//                        int result = cmd.ExecuteNonQuery();

//                        if (result > 0)
//                        {
//                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "showPopup('Inserted data successfully!');", true);
//                            ClearFields();
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", $"showPopup('Error: {ex.Message}');", true);
//                    }
//                }
//            }
//        }

//        private string ValidateInput(string fullName, string email, string password)
//        {
//            if (string.IsNullOrWhiteSpace(fullName))
//                return "Full Name is required.";

//            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
//                return "A valid Email is required.";

//            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
//                return "Password is required and must be at least 6 characters long.";

//            return string.Empty; // No validation errors
//        }

//        private bool IsValidEmail(string email)
//        {
//            // Regular expression to validate email
//            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//            return Regex.IsMatch(email, emailPattern);
//        }

//        private void ClearFields()
//        {
//            txtFullName.Text = string.Empty;
//            txtEmail.Text = string.Empty;
//            txtPassword.Text = string.Empty;
//        }
//    }
//}






using System;
using System.Web.UI;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace cake_shop.user
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize page resources
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input fields
            string validationMessage = ValidateInput(fullname, email, password);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", $"showPopup('{validationMessage}');", true);
                return;
            }

            string connectionString = string.Empty;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", $"showPopup('Connection error: {ex.Message}');", true);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO registeruser (fullname, email, password) VALUES (@fullname, @email, @password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "showPopup('Inserted data successfully!');", true);
                            ClearFields();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "showPopup('Failed to insert data.');", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", $"showPopup('Error: {ex.Message}');", true);
                    }
                }
            }
        }

        private string ValidateInput(string fullName, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return "Full Name is required.";

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                return "A valid Email is required.";

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return "Password is required and must be at least 6 characters long.";

            return string.Empty; // No validation errors
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression to validate email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void ClearFields()
        {
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}

