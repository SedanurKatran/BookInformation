﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("username");
        cookie.Value = tbFirstName.Text + " " + tbLastName.Text;
        cookie.Expires = DateTime.Now.AddMonths(1);
        Response.Cookies.Add(cookie);
        Response.Redirect("Default.aspx");
    }
}