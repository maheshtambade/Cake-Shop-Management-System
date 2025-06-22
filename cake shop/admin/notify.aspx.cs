using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class notify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void SubmitNotification_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string cakeName = CakeNameTextBox.Text;
            string notificationText = NotificationTextBox.Text;

            string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";
            string query = "INSERT INTO Notifications (Username, CakeName, NotificationText) VALUES (@Username, @CakeName, @NotificationText)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@CakeName", cakeName);
                command.Parameters.AddWithValue("@NotificationText", notificationText);
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Redirect or show a success message
            Response.Write("<script>alert('Data Inserted Successfully')</script>");
            UsernameTextBox.Text = "";
            CakeNameTextBox.Text = "";
            NotificationTextBox.Text = "";
        }
    }
}
