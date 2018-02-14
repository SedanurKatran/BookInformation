<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div style="position:absolute; left:500px; top:150px;">
             <asp:Panel ID="pnlNotLoggedIn" runat="server">
                <h1>You are not logged in
                <br />
                Please login
                <a href="Login.aspx"> here</a></h1>
             </asp:Panel>
         </div>
          <div style="position:absolute; left:55px; top:150px;">    
            <h2> <asp:Panel ID="pnlLoggedIn" runat="server">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click on a link below :<br /> Welcome
                 <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                 <a href="Cart.aspx">Display Shopping Cart</a><br />
                 <asp:Button ID="btnLogout" runat="server"  style="height: 26px" Text="Logout" OnClick="btnLogout_Click" /></h2>
                  <h3><div style="position:absolute; left:250px; top:80px;">
                      <asp:Panel ID="pnlProducts" runat="server" style="margin-left: 288px; margin-top: 0px">
                      </asp:Panel>
                  </div></h3>
             </asp:Panel>
         </div>
       
    </div>
    </form>
</body>
</html>
