using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.user
{
    public partial class shop : System.Web.UI.Page
    {


        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCakes();
            }
        }


        private void LoadCakes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, CakeName, Description, Category, Weight, Price, ImagePath FROM AddCake";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    RepeaterCakes.DataSource = dt;
                    RepeaterCakes.DataBind();
                }
            }
        }

        protected void BookCake(object sender, CommandEventArgs e)
        {
            //if (e.CommandArgument != null)
            //{
            //    string cakeId = e.CommandArgument.ToString();
            //    string username = Session["Username"]?.ToString(); 

            //    if (!string.IsNullOrEmpty(username))
            //    {
            //        using (SqlConnection conn = new SqlConnection(connectionString))
            //        {
            //            string query = @"
            //            INSERT INTO Book (CakeId, CakeName, Description, Category, Weight, Price, Username)
            //            SELECT Id, CakeName, Description, Category, Weight, Price, @Username
            //            FROM AddCake WHERE Id = @CakeId";

            //            using (SqlCommand cmd = new SqlCommand(query, conn))
            //            {
            //                cmd.Parameters.AddWithValue("@CakeId", cakeId);
            //                cmd.Parameters.AddWithValue("@Username", username);
            //                conn.Open();
            //                cmd.ExecuteNonQuery();
            //            }
            //        }


            //        Response.Write("<script>alert('Cake booked successfully!');</script>");
            //    }
            //    else
            //    {

            //        Response.Redirect("../guest/login.aspx");
            //    }
            //}

            //-------------------------------
            //    if (e.CommandArgument != null)
            //    {
            //        string cakeId = e.CommandArgument.ToString();
            //        string username = Session["Username"]?.ToString();



            //        if (!string.IsNullOrEmpty(username))
            //        {
            //            using (SqlConnection conn = new SqlConnection(connectionString))
            //            {
            //                // Check if the user has already booked this cake
            //                string checkQuery = @"
            //            SELECT COUNT(*) 
            //            FROM Book 
            //            WHERE CakeId = @CakeId AND Username = @Username";

            //                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
            //                {
            //                    checkCmd.Parameters.AddWithValue("@CakeId", cakeId);
            //                    checkCmd.Parameters.AddWithValue("@Username", username);

            //                    conn.Open();
            //                    int count = (int)checkCmd.ExecuteScalar();
            //                    conn.Close();

            //                    if (count > 0)
            //                    {
            //                        // Cake already booked by this user
            //                        Response.Write("<script>alert('You have already booked this cake!');</script>");
            //                        return;
            //                    }
            //                }


            //                //using (SqlConnection conn = new SqlConnection(connectionString))
            //                {
            //                    string query = "SELECT CakeName, Price, Category FROM AddCake WHERE Id = @CakeId";
            //                    using (SqlCommand cmd = new SqlCommand(query, conn))
            //                    {
            //                        cmd.Parameters.AddWithValue("@CakeId", cakeId);
            //                        conn.Open();
            //                        SqlDataReader reader = cmd.ExecuteReader();
            //                        if (reader.Read())
            //                        {
            //                            string cakeName = reader["CakeName"].ToString();
            //                            string price = reader["Price"].ToString();
            //                            string category = reader["Category"].ToString();

            //                            // Store selected cake details in Session and redirect to payment page
            //                            Session["SelectedCake"] = new
            //                            {
            //                                CakeId = cakeId,
            //                                CakeName = cakeName,
            //                                Price = price,
            //                                Category = category
            //                            };
            //                            Response.Redirect("payment.aspx");
            //                        }
            //                    }
            //                }
            //            }
            //        }

            //    }
            //}
            if (e.CommandArgument != null)
            {
                string cakeId = e.CommandArgument.ToString();
                string username = Session["Username"]?.ToString();

                if (!string.IsNullOrEmpty(username))
                {
                    // Check if the user has already booked this cake
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string checkQuery = @"
                SELECT COUNT(*) 
                FROM Book 
                WHERE CakeId = @CakeId AND Username = @Username";

                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@CakeId", cakeId);
                            checkCmd.Parameters.AddWithValue("@Username", username);

                            conn.Open();
                            int count = (int)checkCmd.ExecuteScalar();
                            conn.Close();

                            if (count > 0)
                            {
                                // Cake already booked by this user
                                Response.Write("<script>alert('You have already booked this cake!');</script>");
                                return;
                            }
                        }
                    }

                    // Retrieve selected cake details
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "SELECT CakeName, Price, Category FROM AddCake WHERE Id = @CakeId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CakeId", cakeId);
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                string cakeName = reader["CakeName"].ToString();
                                string price = reader["Price"].ToString();
                                string category = reader["Category"].ToString();

                                // Store selected cake details in Session and redirect to payment page
                                Session["SelectedCake"] = new
                                {
                                    CakeId = cakeId,
                                    CakeName = cakeName,
                                    Price = price,
                                    Category = category
                                };
                                conn.Close();
                                Response.Redirect("payment.aspx");
                            }
                            conn.Close();
                        }
                    }
                }
                else
                {
                    // Redirect to login if not logged in
                    Response.Redirect("../guest/login.aspx");
                }
            }

        }
    }
}