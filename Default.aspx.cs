using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["username"];

        if (cookie == null)
        {
            pnlLoggedIn.Visible = false;
            pnlNotLoggedIn.Visible = true;
        }
        else
        {
            pnlLoggedIn.Visible = true;
            pnlNotLoggedIn.Visible = false;

            lblUserName.Text = cookie.Value;
            
                pnlProducts.Controls.Clear();

                List<Book> Products = (List<Book>)Application["Products"];

                foreach (Book product in Products)
                {
                    HyperLink link = new HyperLink();

                    link.NavigateUrl = "BookInfo.aspx?id=" + product.BookID;
                    link.Text = product.Author + " " + product.Publisher;

                    pnlProducts.Controls.Add(link);

                    Literal lit = new Literal();
                    lit.Text = "<br /><br />";

                    pnlProducts.Controls.Add(lit);
                }
           
        }
    }



    protected void btnLogout_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("username");
        cookie.Expires = DateTime.Now.AddMonths(-1);

        Response.Cookies.Add(cookie);

        Response.Redirect("Default.aspx");
    }
}