<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultError.aspx.cs" Inherits="DefaultError" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" 
            Height="86px" Width="100%" />
    <br />

    <h2>Oh no!</h2>
    <br />
    <br />

    Something unexcepted happened, which caused us to drop what we were doing and come here. We are sorry for the inconvenient.<br />
    
    <br />
    <br />
    <asp:Button ID="btnReturn" runat="server" Text="Return to Main Page" PostBackUrl="~/default.aspx" />
    <br />
    <br />

    Or, you can <a href="Contact.aspx"> email</a> us mentioning about the error.
    Thank you!
    </div>
    </form>
</body>
</html>
