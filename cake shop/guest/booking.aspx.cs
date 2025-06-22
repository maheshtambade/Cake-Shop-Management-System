using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.guest
{
    public partial class booking : System.Web.UI.Page
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
            if (e.CommandArgument != null)
            {
                string cakeId = e.CommandArgument.ToString();
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
                            Response.Redirect("payment.aspx");
                        }
                    }
                }
            }
        }


    }
}