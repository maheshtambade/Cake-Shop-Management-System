using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.user
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("../guest/login.aspx");
                
            }
            else
            {
                lblUsername.Text = Session["Username"].ToString();
            }
            
         
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Destroy the session
            Session.Abandon();
            Session.Clear();

            // Redirect to Home.aspx
            Response.Redirect("../guest/home.aspx");
        }
    }
}