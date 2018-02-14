using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["products"];
        if (cookie == null)
        {
            pnlProducts.Visible = false;
            pnlEmpty.Visible = true;
        }
        else
        {
            int[] myarray = new int[5];
            int produ = 0;
            pnlProducts.Visible = true;
            pnlEmpty.Visible = false;
            string proids = cookie.Value;
            for (int i = 0; i < proids.Length; i++)
            {
                if (proids[i] != ',')
                {
                    myarray[produ] = (int)Char.GetNumericValue(proids[i]);
                    produ++;
                    lblCartProducts.Text = "You have " + produ + " products in your shopping cart!";
                }
            }
            if (produ == 1)
            {
                pnlProduct2.Visible = false;
                pnlProduct3.Visible = false;
                pnlProduct4.Visible = false;
                pnlProduct5.Visible = false;
                int ProductId = myarray[0];

                List<Book> Products = (List<Book>)Application["Products"];

                Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

               
              
                lblBookAuthor.Text = Product.Author;
                lblBookPublisher.Text = Product.Publisher;
                lblBookPage.Text = Product.PageNumber.ToString();
                imgProduct.ImageUrl = Product.ImageUrl;
            }
            if (produ == 2)
            {
                
                pnlProduct3.Visible = false;
                pnlProduct4.Visible = false;
                pnlProduct5.Visible = false;
                int ProductId = myarray[0];

                List<Book> Products = (List<Book>)Application["Products"];

                Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();


              //  lblProductType.Text = Product.Title;
                lblBookAuthor.Text = Product.Author;
                lblBookPublisher.Text = Product.Publisher;
                lblBookPage.Text = Product.PageNumber.ToString();
                imgProduct.ImageUrl = Product.ImageUrl;
               
                ProductId = myarray[1];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

              //  lblProductType2.Text = Product.Title;
                lblBookAuthor2.Text = Product.Author;
                lblBookPublisher2.Text = Product.Publisher;
                lblBookPage2.Text = Product.PageNumber.ToString();
                imgProduct2.ImageUrl = Product.ImageUrl;
            }
            if (produ == 3)
            {
              
                pnlProduct4.Visible = false;
                pnlProduct5.Visible = false;
                int ProductId = myarray[0];

                List<Book> Products = (List<Book>)Application["Products"];

                Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();


               // lblProductType.Text = Product.Title;
                lblBookAuthor.Text = Product.Author;
                lblBookPublisher.Text = Product.Publisher;
                lblBookPage.Text = Product.PageNumber.ToString();
                imgProduct.ImageUrl = Product.ImageUrl;
                
                ProductId = myarray[2];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();
              //  lblProductType3.Text = Product.Title;
                lblBookAuthor3.Text = Product.Author;
                lblBookPublisher3.Text = Product.Publisher;
                lblBookPage3.Text = Product.PageNumber.ToString();
                imgProduct3.ImageUrl = Product.ImageUrl;

                ProductId = myarray[1];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

              //  lblProductType2.Text = Product.Title;
                lblBookAuthor2.Text = Product.Author;
                lblBookPublisher2.Text = Product.Publisher;
                lblBookPage2.Text = Product.PageNumber.ToString();
                imgProduct2.ImageUrl = Product.ImageUrl;
            }
            if (produ == 4)
            {
               
                pnlProduct5.Visible = false;
                int ProductId = myarray[0];

                List<Book> Products = (List<Book>)Application["Products"];

                Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();


              //  lblProductType.Text = Product.Title;
                lblBookAuthor.Text = Product.Author;
                lblBookPublisher.Text = Product.Publisher;
                lblBookPage.Text = Product.PageNumber.ToString();
                imgProduct.ImageUrl = Product.ImageUrl;

                ProductId = myarray[3];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

              //  lblProductType4.Text = Product.Title;
                lblBookAuthor4.Text = Product.Author;
                lblBookPublisher4.Text = Product.Publisher;
                lblBookPage4.Text = Product.PageNumber.ToString();
                imgProduct4.ImageUrl = Product.ImageUrl;

                ProductId = myarray[2];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();
              //  lblProductType3.Text = Product.Title;
                lblBookAuthor3.Text = Product.Author;
                lblBookPublisher3.Text = Product.Publisher;
                lblBookPage3.Text = Product.PageNumber.ToString();
                imgProduct3.ImageUrl = Product.ImageUrl;

                ProductId = myarray[1];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

              //  lblProductType2.Text = Product.Title;
                lblBookAuthor2.Text = Product.Author;
                lblBookPublisher2.Text = Product.Publisher;
                lblBookPage2.Text = Product.PageNumber.ToString();
                imgProduct2.ImageUrl = Product.ImageUrl;
            }
            if (produ == 5)
            {
                
                int ProductId = myarray[0];

                List<Book> Products = (List<Book>)Application["Products"];

                Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();


               // lblProductType.Text = Product.Title;
                lblBookAuthor.Text = Product.Author;
                lblBookPublisher.Text = Product.Publisher;
                lblBookPage.Text = Product.PageNumber.ToString();
                imgProduct.ImageUrl = Product.ImageUrl;

                ProductId = myarray[4];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

               // lblProductType5.Text = Product.Title;
                lblBookAuthor5.Text = Product.Author;
                lblBookPublisher5.Text = Product.Publisher;
                lblBookPage5.Text = Product.PageNumber.ToString();
                imgProduct5.ImageUrl = Product.ImageUrl;

                ProductId = myarray[3];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

                //lblProductType4.Text = Product.Title;
                lblBookAuthor4.Text = Product.Author;
                lblBookPublisher4.Text = Product.Publisher;
                lblBookPage4.Text = Product.PageNumber.ToString();
                imgProduct4.ImageUrl = Product.ImageUrl;

                ProductId = myarray[2];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();
               // lblProductType3.Text = Product.Title;
                lblBookAuthor3.Text = Product.Author;
                lblBookPublisher3.Text = Product.Publisher;
                lblBookPage3.Text = Product.PageNumber.ToString();
                imgProduct3.ImageUrl = Product.ImageUrl;

                ProductId = myarray[1];
                Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

                //lblProductType2.Text = Product.Title;
                lblBookAuthor2.Text = Product.Author;
                lblBookPublisher2.Text = Product.Publisher;
                lblBookPage2.Text = Product.PageNumber.ToString();
                imgProduct2.ImageUrl = Product.ImageUrl;
            }
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        HttpCookie cookieControl = Request.Cookies["products"];
        string test = cookieControl.Value;
        if (test.Length==1)
        {
            HttpCookie cookie = new HttpCookie("products");
            cookie.Expires = DateTime.Now.AddMonths(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
        else
        {
            string tmp = test.Substring(2);
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
           
        }


    }
    protected void btnDelete2_Click(object sender, EventArgs e)
    {
        HttpCookie cookieControl = Request.Cookies["products"];
        string test = cookieControl.Value;
        if (test.Length == 3)
        {
            string tmp = test.Substring(0, 1);
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
        else
        {
            string tmp = test.Substring(0,2);
            string tmp2 = test.Substring(4);
            tmp += tmp2;
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");

        }
    }
    protected void btnDelete5_Click(object sender, EventArgs e)
    {
        HttpCookie cookieControl = Request.Cookies["products"];
        string test = cookieControl.Value;
       
            string tmp = test.Substring(0, 7);
           
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");

    
    }
    protected void btnDelete4_Click(object sender, EventArgs e)
    {
        HttpCookie cookieControl = Request.Cookies["products"];
        string test = cookieControl.Value;
        if (test.Length == 7)
        {
            string tmp = test.Substring(0, 5);
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
        else
        {
            string tmp = test.Substring(0, 6);
            string tmp2 = test.Substring(8);
            tmp += tmp2;
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
    }
    protected void btnDelete3_Click(object sender, EventArgs e)
    {
         HttpCookie cookieControl = Request.Cookies["products"];
        string test = cookieControl.Value;
        if (test.Length == 5)
        {
            string tmp = test.Substring(0, 3);
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
        else
        {
            string tmp = test.Substring(0,4);
            string tmp2 = test.Substring(6);
            tmp += tmp2;
            HttpCookie cookie = new HttpCookie("products");
            cookie.Value = tmp;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Cart.aspx");
        }
    }
}