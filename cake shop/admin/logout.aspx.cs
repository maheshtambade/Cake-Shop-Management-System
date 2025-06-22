using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Destroy the session
            Session.Abandon();

            // Optionally clear cookies if used for session identification
            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);

            // Redirect to the login page
            Response.Redirect("../guest/home.aspx");
        }
    }
}