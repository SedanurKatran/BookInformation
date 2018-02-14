using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookInfo: System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        string strProductId = Request.QueryString["id"];

        if (string.IsNullOrEmpty(strProductId))
        {
            pnlError.Visible = true;
            pnlProduct.Visible = false;

            lblError.Text = "Please Specify a Product ID!!!";
            return;
        }

        int ProductId = 0;
        bool parseResult = int.TryParse(strProductId, out ProductId);

        List<Book> Products = (List<Book>)Application["Products"];



        Book Product = Products.Where(c => c.BookID == ProductId).FirstOrDefault();

        if (Product == null)
        {
            pnlError.Visible = true;
            pnlProduct.Visible = false;

            lblError.Text = "Invalid Product ID!!!";
            return;
        }

        pnlError.Visible = false;
        pnlProduct.Visible = true;
        lblBookAuthor.Text = Product.Author;
        lblProductId.Text = Product.BookID.ToString();
        lblProductId.Visible = false;
       
        lblBookPage.Text = Product.PageNumber.ToString();
        lblBookPublisher.Text = Product.Publisher;
        imgProduct.ImageUrl = Product.ImageUrl;
    }
    protected void btnAddCart_Click(object sender, EventArgs e)
    {
       

        HttpCookie cookieControl = Request.Cookies["products"];
        HttpCookie cookieAddCart = new HttpCookie("products");
        

        if (cookieControl == null)
        {
           
            cookieAddCart.Value =  lblProductId.Text;
            cookieAddCart.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookieAddCart);
            lblInfoAddCart.Text = "Product is added to the cart!";
        }
        
        else 
        {
            int a=0;
            string lbl = lblProductId.Text;
            char ch = lbl[0];
            string checklist = cookieControl.Value;
            for (int i = 0; i < checklist.Length; i++ )
            {
                if (checklist[i] != ',' )
                    if(ch.Equals(checklist[i]))
                                a++;
               
                   
            } 
            if(a > 0)
                lblInfoAddCart.Text = "Product is already in the list!";
            else
            {
                cookieAddCart.Value = cookieControl.Value + "," + lblProductId.Text;
                cookieAddCart.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(cookieAddCart);
                lblInfoAddCart.Text = "Product is added to the cart!";
            }
           
        }
          
      
       
    }
}