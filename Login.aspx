<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
     <div style="position:absolute; left:500px; top:140px;">
    </div>
        
      <asp:Panel ID="Panel1" runat="server" BackColor="#99FF99" Height="91px" Width="266px">
            <h3>  <asp:Label ID="lblFirstN" runat="server" Text="First Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastN" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
        <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Font-Size="Medium" ForeColor="Black" Width="75px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h3>
        </asp:Panel>
        
    </form>
</body>
</html>
