<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookInfo.aspx.cs" Inherits="BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position:absolute; left:500px; top:150px;">
            <h2>
                <asp:Panel ID="pnlError" runat="server">
                    <asp:Label ID="lblError" runat="server" Text="Label" Font-Bold="True" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <a href="Default.aspx">Return to Main Page</a>
                </asp:Panel>
			</h2>
        </div>
        <div style="position:absolute; left:320px; top:20px;">
            <h3>
                <asp:Panel ID="pnlProduct" runat="server">
                       <asp:Label ID="lblProductId" runat="server" Text="Label"></asp:Label>
                       Information About Product<br />&nbsp;
                       <div style="position:absolute; left:402px; top:100px; width: 216px; height: 118px;">
                           Author:<asp:Label ID="lblBookAuthor" runat="server" Text="Label"></asp:Label>
                           &nbsp;
                           <br />
                           Publisher:<asp:Label ID="lblBookPublisher" runat="server" Text="Label"></asp:Label>
                           <br />
                           Page:<asp:Label ID="lblBookPage" runat="server" Text="Label"></asp:Label>
                           <br />
                           <asp:Button ID="btnAddCart" runat="server" OnClick="btnAddCart_Click" Text="Add to Cart" />
                           &nbsp;&nbsp;<asp:Label ID="lblInfoAddCart" runat="server"></asp:Label>
                           <br />
                       </div>
                       <asp:Image ID="imgProduct" runat="server" Height="400px" style="margin-left: 0px" Width="378px" />
                         <br />
                        <br />
                       <a href="Cart.aspx">Display Shopping Cart</a>
                       <br />
                        <a href="Default.aspx">Return to Main Page</a>
                </asp:Panel>
            </h3>
        </div>
    </form>
</body>
</html>
