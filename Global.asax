<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        List<Book> products = new List<Book>();
        products.Add(new Book(1, "ASP.NET 3.5 Unleashed ", "Stephen Walther", "Sams", 1920,"images/1.jpg"));
        products.Add(new Book(2, "ASP.NET Evolution", "Dan Kent", "Sams",384, "images/2.jpg"));
        
        products.Add(new Book(3, "Mastering Web Development with Microsoft Visual Studio 2005", "John Paul Mueller", "Sams",848, "images/3.jpg"));
        products.Add(new Book(4, "Beginning ASP.NET 2.0", "Chris Hart, John Kauffman,Dave Sussman, and Chris Ullman", "Wrox", 792,"images/4.jpg"));
       
        products.Add(new Book(5, "Beginning ASP.NET 3.5 in C# 2008:From Novice to Professional,Second Edition ", "Matthew MacDonald", "Apress", 954,"images/5.jpg"));


        Application["products"] = products;
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
