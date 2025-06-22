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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch Total Users
                lblTotalUsers.Text = GetCount(con, "SELECT COUNT(*) FROM RegisterUser").ToString();

                // Fetch Total Cakes
                lblCakes.Text = GetCount(con, "SELECT COUNT(*) FROM AddCake").ToString();

                // Fetch Total Bookings
                lblBookings.Text = GetCount(con, "SELECT COUNT(*) FROM Payment").ToString();

                // Fetch Total Cancel Bookings
                //lblCancelBookings.Text = GetCount(con, "SELECT COUNT(*) FROM CancelBooking").ToString();
            }
        }

        private int GetCount(SqlConnection con, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}