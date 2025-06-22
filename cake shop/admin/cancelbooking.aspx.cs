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
    public partial class cancelbooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCanceledOrders();
            }
        }


        private void BindCanceledOrders()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            //string query = @"
            //    SELECT CakeName, Description, Category, Weight, Price, Username, BookingDate
            //    FROM Book
            //    WHERE IsCanceled = 1";

            string query = @"
                SELECT CakeName, Description, Category, Weight, Price, Username, BookingDate, CanceledDate
                FROM CancelBooking";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                CanceledOrdersGrid.DataSource = reader;
                CanceledOrdersGrid.DataBind();
            }







        }


    }
}