using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.guest
{

    public partial class payment : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["SelectedCake"] != null)
            {
                var cake = (dynamic)Session["SelectedCake"];
                lblCakeDetails.Text = $"<b>Cake:</b> {cake.CakeName}<br/><b>Price:</b> ${cake.Price}<br/><b>Category:</b> {cake.Category}";
            }
        }

        protected void SubmitPayment(object sender, EventArgs e)
        {
            string cardName = txtCardName.Text.Trim();
            string cardNumber = txtCardNumber.Text.Trim();
            string expiryDate = txtExpiryDate.Text.Trim();
            string cvv = txtCVV.Text.Trim();

            if (string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(expiryDate) || string.IsNullOrEmpty(cvv))
            {
                Response.Write("<script>alert('Please fill all payment fields!');</script>");
                return;
            }

            if (cardNumber.Length != 16)
            {
                Response.Write("<script>alert('Card number must be 16 digits!');</script>");
                return;
            }

            var cake = (dynamic)Session["SelectedCake"];
            string username = Session["Username"]?.ToString();

            if (!string.IsNullOrEmpty(username))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Payment (Username, CakeName, Category, PaymentPrice, PaymentDate)
                                     VALUES (@Username, @CakeName, @Category, @Price, @Date)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@CakeName", cake.CakeName);
                        cmd.Parameters.AddWithValue("@Category", cake.Category);
                        cmd.Parameters.AddWithValue("@Price", cake.Price);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                Response.Write("<script>alert('Payment successful! Your order will be delivered within 24 hours.');</script>");
            }
            else
            {
                Response.Redirect("../guest/login.aspx");
            }
        }
    }
}
