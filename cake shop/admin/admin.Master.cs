using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop.admin
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUsername"] == null)
            {
                Response.Redirect("../admin/adminlogin.aspx");
            }
            else
            {
                lblUsername.Text = Session["AdminUsername"].ToString();
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../guest/home.aspx");
        }
    }
}