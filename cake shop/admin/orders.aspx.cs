using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    BindOrders();
            //}
            if (!IsPostBack)
            {
                LoadPaymentData();
            }
        }

        //public class Book
        //{
        //    public string CakeName { get; set; }
        //    public string Description { get; set; }
        //    public string Category { get; set; }
        //    public double Weight { get; set; }
        //    public decimal Price { get; set; }
        //    public string Username { get; set; }
        //    public DateTime BookingDate { get; set; }
        //}

        //public class RegisterUser
        //{
        //    public string Username { get; set; }
        //    public string FullName { get; set; }
        //    public string LastName { get; set; }
        //}

        //public class Order
        //{
        //    public string CakeName { get; set; }
        //    public string Description { get; set; }
        //    public string Category { get; set; }
        //    public double Weight { get; set; }
        //    public decimal Price { get; set; }
        //    public string FullName { get; set; }
        //    public string LastName { get; set; }
        //    public DateTime BookingDate { get; set; }
        //}



        //public List<Order> GetOrders()
        //{
        //    List<Order> orders = new List<Order>();

        //    string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True;";
        //    string query = @"
        //SELECT b.CakeName, b.Description, b.Category, b.Weight, b.Price, b.BookingDate, 
        //       r.FullName, r.LastName
        //FROM Book b
        //INNER JOIN RegisterUser r ON b.Username = r.Username";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            orders.Add(new Order
        //            {
        //                CakeName = reader["CakeName"].ToString(),
        //                Description = reader["Description"].ToString(),
        //                Category = reader["Category"].ToString(),
        //                Weight = Convert.ToDouble(reader["Weight"]),
        //                Price = Convert.ToDecimal(reader["Price"]),
        //                BookingDate = Convert.ToDateTime(reader["BookingDate"]),
        //                FullName = reader["FullName"].ToString(),
        //                LastName = reader["LastName"].ToString()
        //            });
        //        }
        //    }

        //    return orders;
        //}








        ////private void BindOrders()
        ////{
        ////    DatabaseHelper dbHelper = new DatabaseHelper();
        ////    List<Order> orders = dbHelper.GetOrders();

        ////    OrdersGrid.DataSource = orders;
        ////    OrdersGrid.DataBind();
        ////}

        //private void BindOrders()
        //{
        //    List<Order> orders = GetOrders();
        //    OrdersGrid.DataSource = orders;
        //    OrdersGrid.DataBind();
        //}



        private void LoadPaymentData()
        {
            string connectionString = "Data Source=DESKTOP-P3ULETT\\SQLEXPRESS;Initial Catalog=cakeshop;Integrated Security=True"; // Replace with your database connection string
            string query = "SELECT UserName, CakeName, Category, PaymentPrice, CardName, CardNumber, ExpiryDate, DeliveryAddress FROM Payment";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        GridViewPayment.DataSource = dataTable;
                        GridViewPayment.DataBind();
                    }
                }
            }
        }


    }
}