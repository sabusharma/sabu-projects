<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error500.aspx.cs" Inherits="error500" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
    <br />
    <br />
     <table style="margin-left:auto; margin-right:auto">
    <tr>
    <td>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/error500.jpg" />
        </td>
    </tr>
    <tr>
    <td>
     We are sorry....but something went wrong  resulting to server configuration error.
     
    Please try again later or go to <a href="default.aspx"> Main Page </a> or you can <a href="Contact.aspx"> email</a> us mentioning about the error.
    Thank you! </td></tr>
    </table>
    </div>
    </form>
</body>
</html>
