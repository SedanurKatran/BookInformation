<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shopping Cart</title>
</head>
<body>
    <form id="form1" runat="server">
   
        <div style="position:absolute; left:500px; top:150px;">
            <h2>
			    <asp:Panel ID="pnlEmpty" runat="server">
				   Your Shopping Cart is Empty
				 <br />
				 <br />
				 <br />
				 <br />
					<a href="Default.aspx">Return to Main Page</a>
				</asp:Panel>
            </h2>
        </div>
        <div style="position:absolute; left:400px; top:20px;"><h3>
            <asp:Panel ID="pnlProducts" runat="server">
       		    <asp:Label ID="lblCartProducts" runat="server" Text="Label"></asp:Label>
			    <asp:Panel ID="pnlProduct1" runat="server">
                
                <br />
                <br />
                <div style="position:absolute; left:452px; top:240px; width: 156px; height: 118px;">
                <h3>
                Author:<asp:Label ID="lblBookAuthor" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;
                <br />
                Publisher:<asp:Label ID="lblBookPublisher" runat="server" Text="Label"></asp:Label>
                <br />
                Page:<asp:Label ID="lblBookPage" runat="server" Text="Label"></asp:Label>
                <br />
            
                <p>
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Product" Width="102px" />
                </p></h3>
                 </div>
                <asp:Image ID="imgProduct" runat="server" Height="400px" Width="400px" />
                 <br />
		          </asp:Panel>
				  <asp:Panel ID="pnlProduct2" runat="server">
               
                <br />
                <br />
                <div style="position:absolute; left:452px; top:640px; width: 156px; height: 118px;">
                <h3>
                Author:<asp:Label ID="lblBookAuthor2" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;
                <br />
                Publisher:<asp:Label ID="lblBookPublisher2" runat="server" Text="Label"></asp:Label>
                <br />
                Page:<asp:Label ID="lblBookPage2" runat="server" Text="Label"></asp:Label>
                <br />
            
                <p>
                    <asp:Button ID="btnDelete2" runat="server" OnClick="btnDelete2_Click" Text="Delete Product" Width="102px" />
                </p></h3>
                 </div>
                <asp:Image ID="imgProduct2" runat="server" Height="400px" Width="400px" />
                 <br />
		          </asp:Panel>
				  <asp:Panel ID="pnlProduct3" runat="server">
                
                <br />
                <br />
                <div style="position:absolute; left:452px; top:1103px; width: 156px; height: 118px;">
                <h3>
                Author:<asp:Label ID="lblBookAuthor3" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;
                <br />
                Publisher:<asp:Label ID="lblBookPublisher3" runat="server" Text="Label"></asp:Label>
                <br />
                Page:<asp:Label ID="lblBookPage3" runat="server" Text="Label"></asp:Label>
                <br />
            
                <p>
                    <asp:Button ID="btnDelete3" runat="server" OnClick="btnDelete3_Click" Text="Delete Product" Width="102px" />
                </p></h3>
                 </div>
                <asp:Image ID="imgProduct3" runat="server" Height="400px" Width="400px" />
                 <br />
		          </asp:Panel>
				  <asp:Panel ID="pnlProduct4" runat="server">
               
                <br />
                <br />
                <div style="position:absolute; left:452px; top:1515px; width: 156px; height: 118px;">
                <h3>
                Author:<asp:Label ID="lblBookAuthor4" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;
                <br />
                Publisher:<asp:Label ID="lblBookPublisher4" runat="server" Text="Label"></asp:Label>
                <br />
                Page:<asp:Label ID="lblBookPage4" runat="server" Text="Label"></asp:Label>
                <br />
            
                <p>
                    <asp:Button ID="btnDelete4" runat="server" OnClick="btnDelete4_Click" Text="Delete Product" Width="102px" />
                </p></h3>
                 </div>
                <asp:Image ID="imgProduct4" runat="server" Height="400px" Width="400px" />
                 <br />
		          </asp:Panel>
				  <asp:Panel ID="pnlProduct5" runat="server">
                
                <br />
                <br />
                <div style="position:absolute; left:452px; top:1997px; width: 156px; height: 118px;">
                <h3>
                Author:<asp:Label ID="lblBookAuthor5" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;
                <br />
                Publisher:<asp:Label ID="lblBookPublisher5" runat="server" Text="Label"></asp:Label>
                <br />
                Page:<asp:Label ID="lblBookPage5" runat="server" Text="Label"></asp:Label>
                <br />
            
                <p>
                    <asp:Button ID="btnDelete5" runat="server" OnClick="btnDelete5_Click" Text="Delete Product" Width="102px" />
                </p></h3>
                 </div>
                <asp:Image ID="imgProduct5" runat="server" Height="400px" Width="400px" />
                 <br />
		          </asp:Panel>
				 <br />
				 <br />
				
				 <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="Default.aspx">Return to Main Page</a> 
            </asp:Panel>
                  </h3>
		</div>
    </form>
</body>
</html>
