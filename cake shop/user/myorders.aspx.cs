using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.user
{
    public partial class myorders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOrders();
            }
        }

        private void BindOrders()
        {
            string username = Session["Username"].ToString(); // Assuming username is stored in session
            string query = @"SELECT Username, CakeName, Category, PaymentPrice, PaymentDate, CardName, CardNumber, ExpiryDate, DeliveryAddress FROM Payment WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvOrders.DataSource = dt;
                    gvOrders.DataBind();
                }
            }
        }

        //-----------------------------------

        //private void BindOrders()
        //{
        //    // Replace this with actual username from session or authentication mechanism.
        //    string username = Session["Username"]?.ToString();

        //    if (string.IsNullOrEmpty(username))
        //    {
        //        // Handle user not logged in
        //        Response.Redirect("../guest/login.aspx");
        //        return;
        //    }

        //    string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        //    string query = @"
        //        SELECT CakeName, Description, Weight, Price, BookingDate
        //        FROM Book
        //        WHERE Username = @Username";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Username", username);

        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        OrdersGrid.DataSource = reader;
        //        OrdersGrid.DataBind();
        //    }
        //}

        //protected void OrdersGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    //if (e.CommandName == "CancelOrder")
        //    //{
        //    //    int rowIndex = Convert.ToInt32(e.CommandArgument);
        //    //    string cakeName = OrdersGrid.DataKeys[rowIndex].Value.ToString();
        //    //    DeleteOrder(cakeName);
        //    //    BindOrders(); // Refresh the grid
        //    //}

        //    if (e.CommandName == "CancelOrder")
        //    {
        //        // Retrieve the row index from the CommandArgument
        //        int rowIndex = Convert.ToInt32(e.CommandArgument);

        //        // Ensure the row index is within bounds
        //        if (rowIndex >= 0 && rowIndex < OrdersGrid.DataKeys.Count)
        //        {
        //            // Retrieve the CakeName from DataKeys
        //            string cakeName = OrdersGrid.DataKeys[rowIndex].Value.ToString();

        //            // Cancel the order
        //            DeleteOrder(cakeName);

        //            // Refresh the grid to reflect the changes
        //            BindOrders();
        //        }
        //        else
        //        {
        //            // Log or handle the error case
        //            throw new ArgumentOutOfRangeException("Index was out of range.");
        //        }
        //    }





        //}

        //private void DeleteOrder(string cakeName)
        //{
        //    //// Replace this with actual username from session or authentication mechanism.
        //    //string username = Session["Username"]?.ToString();

        //    //string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        //    //string query = @"
        //    //DELETE FROM Book
        //    //WHERE CakeName = @CakeName AND Username = @Username";

        //    //using (SqlConnection conn = new SqlConnection(connectionString))
        //    //{
        //    //    SqlCommand cmd = new SqlCommand(query, conn);
        //    //    cmd.Parameters.AddWithValue("@CakeName", cakeName);
        //    //    cmd.Parameters.AddWithValue("@Username", username);

        //    //    conn.Open();
        //    //    cmd.ExecuteNonQuery();
        //    //}
        //    string username = Session["Username"]?.ToString();

        //    string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        //    string query = @"
        //        UPDATE Book
        //         SET IsCanceled = 1
        //        WHERE CakeName = @CakeName AND Username = @Username";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@CakeName", cakeName);
        //        cmd.Parameters.AddWithValue("@Username", username);

        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }


        //    // Query to insert canceled order into CancelBooking table
        //    string insertQuery = @"
        //INSERT INTO CancelBooking (CakeName, Description, Category, Weight, Price, Username, BookingDate)
        //SELECT CakeName, Description, Category, Weight, Price, Username, BookingDate
        //FROM Book
        //WHERE CakeName = @CakeName AND Username = @Username";

        //    // Query to delete the canceled order from Book table
        //    string deleteQuery = @"
        //DELETE FROM Book
        //WHERE CakeName = @CakeName AND Username = @Username";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
        //        {
        //            insertCmd.Parameters.AddWithValue("@CakeName", cakeName);
        //            insertCmd.Parameters.AddWithValue("@Username", username);
        //            insertCmd.ExecuteNonQuery();
        //        }

        //        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
        //        {
        //            deleteCmd.Parameters.AddWithValue("@CakeName", cakeName);
        //            deleteCmd.Parameters.AddWithValue("@Username", username);
        //            deleteCmd.ExecuteNonQuery();
        //        }
        //    }



    }
}



