using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.user
{
    public partial class notification : System.Web.UI.Page
    {
        protected List<Notification> Notifications = new List<Notification>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //        string username = User.Identity.Name; // Assuming logged-in username
            //        string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";
            //        string query = "SELECT NotificationText, CakeName, CreatedDate FROM Notifications WHERE Username = @Username";

            //        using (SqlConnection connection = new SqlConnection(connectionString))
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@Username", username);
            //            connection.Open();
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    Notifications.Add(new Notification
            //                    {
            //                        NotificationText = reader.GetString(0),
            //                        CakeName = reader.IsDBNull(1) ? null : reader.GetString(1),
            //                        CreatedDate = reader.GetDateTime(2)
            //                    });
            //                }
            //            }
            //        }
            //    }
            //}

            //public class Notification
            //{
            //    public string NotificationText { get; set; }
            //    public string CakeName { get; set; }
            //    public DateTime CreatedDate { get; set; }
            //}


            if (!IsPostBack) // Load data only on the initial load
            {
                if (Session["Username"] == null)
                {
                    // Redirect to login page if the session is not set
                    Response.Redirect("../guest/login.aspx");
                    return;
                }

                LoadNotifications();
                BindNotifications();
            }
        }





        private void LoadNotifications()
        {
            string username = Session["Username"] as string; // Retrieve username from session
            if (string.IsNullOrEmpty(username))
            {
                // Handle cases where the session value is null or empty
                Notifications.Add(new Notification
                {
                    NotificationText = "No notifications available.",
                    CakeName = null,
                    CreatedDate = DateTime.Now
                });
                return;
            }

            string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";
            string query = "SELECT NotificationText, CakeName, CreatedDate FROM Notifications WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Notifications.Add(new Notification
                            {
                                NotificationText = reader.GetString(0),
                                CakeName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                CreatedDate = reader.GetDateTime(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and handle the error (for debugging, consider logging to a file or database)
                Notifications.Add(new Notification
                {
                    NotificationText = $"Error loading notifications: {ex.Message}",
                    CakeName = null,
                    CreatedDate = DateTime.Now
                });
            }
        }

        private void BindNotifications()
        {
            NotificationsGridView.DataSource = Notifications;
            NotificationsGridView.DataBind();
        }
    }

    public class Notification
    {
        public string NotificationText { get; set; }
        public string CakeName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}






    
