﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cake_shop
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                //lblUsername.Text = Session["Username"].ToString();
            }

        }
    }
}