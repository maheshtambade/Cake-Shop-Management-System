using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.user
{
    public partial class payment : System.Web.UI.Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack && Session["SelectedCake"] != null)
            {
                var cake = (dynamic)Session["SelectedCake"];
                lblCakeDetails.Text = $"<b>Cake:</b> {cake.CakeName}<br/><b>Price:</b> {cake.Price}<br/><b>Category:</b> {cake.Category}";
            }
        }

        protected void SubmitPayment(object sender, EventArgs e)
        {
            string cardName = txtCardName.Text.Trim();
            string cardNumber = txtCardNumber.Text.Trim();
            string expiryDate = txtExpiryDate.Text.Trim();
            string cvv = txtCVV.Text.Trim();
            string deliveryaddress = txtDeliveryAddress.Text.Trim();

            if (string.IsNullOrEmpty(cardName) || string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(expiryDate) || string.IsNullOrEmpty(cvv))
            {
                Response.Write("<script>alert('Please fill all payment fields!');</script>");
                return;
            }

            // Validate that Card Name contains only alphabets
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardName, @"^[a-zA-Z\s]+$"))
            {
                Response.Write("<script>alert('Cardholder name must contain only letters and spaces!');</script>");
                return;
            }

            // Validate that Card Number contains exactly 16 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^\d{16}$"))
            {
                Response.Write("<script>alert('Card number must be 16 digits and contain only numbers!');</script>");
                return;
            }

            // Validate Expiry Date
            DateTime expiryDateValue;
            if (!DateTime.TryParseExact(expiryDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out expiryDateValue))
            {
                Response.Write("<script>alert('Expiry date must be in the format MM/YY!');</script>");
                return;
            }

            if (expiryDateValue < DateTime.Now)
            {
                Response.Write("<script>alert('Card is expired! Please use a valid card.');</script>");
                return;
            }

            // Validate CVV
            if (!System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3,4}$"))
            {
                Response.Write("<script>alert('CVV must be 3 or 4 digits!');</script>");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(deliveryaddress, @"^[a-zA-Z\s]+$"))
            {
                Response.Write("<script>alert('Delivery Address must contain only letters and spaces!');</script>");
                return;
            }




            var cake = (dynamic)Session["SelectedCake"];
            string username = Session["Username"]?.ToString();

            if (!string.IsNullOrEmpty(username))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
    INSERT INTO Payment 
    (Username, CakeName, Category, PaymentPrice, PaymentDate, CardName, CardNumber, ExpiryDate, DeliveryAddress)
    VALUES 
    (@Username, @CakeName, @Category, @Price, @Date, @CardName, @CardNumber, @ExpiryDate, @DeliveryAddress)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@CakeName", cake.CakeName);
                        cmd.Parameters.AddWithValue("@Category", cake.Category);
                        cmd.Parameters.AddWithValue("@Price", cake.Price);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CardName", txtCardName.Text.Trim());
                        cmd.Parameters.AddWithValue("@CardNumber", txtCardNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@ExpiryDate", txtExpiryDate.Text.Trim());
                        cmd.Parameters.AddWithValue("@DeliveryAddress", txtDeliveryAddress.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

                //Response.Write("<script>alert('Payment successful! Your order will be delivered within 24 hours.');</script>");
                //txtCardName.Text = "";
                //txtCardNumber.Text = "";
                //txtCVV.Text = "";
                //txtExpiryDate.Text = "";
                //Response.Redirect("home.aspx");

                Response.Write(@"
    <script>
        alert('Payment successful! Your order will be delivered after 24 hours.');
        setTimeout(function() {
            window.location.href = 'home.aspx';
        }, 2000);
    </script>");

                // Clear the input fields
                txtCardName.Text = "";
                txtCardNumber.Text = "";
                txtCVV.Text = "";
                txtExpiryDate.Text = "";
                txtDeliveryAddress.Text = "";



            }
            else
            {
                Response.Redirect("../guest/login.aspx");
            }
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        //protected void RedirectToOrders(object sender, EventArgs e)
        //{
        //    Response.Redirect("home.aspx");
        //}
    }
}
