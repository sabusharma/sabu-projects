using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        Customer cust = new Customer();
        cust.email = tbSignInEmail.Text;        
        cust.password = tbSignInPassword.Text;

        BookStore bs = new BookStore();
        if (bs.ValidateCustomer(cust))
        {
            Session["UserLoggedin"] = true;
            Session["email"] = cust.email;
            Response.Redirect("checkout.aspx");
            AddCookie();
        }

        else
        {
            lblInvalidLogin.Text = "Invalid Login";
        }

    }
    private void AddCookie()
    {
        HttpCookie userNameCookie = new HttpCookie("UserName", tbSignInEmail.Text);
        userNameCookie.Expires = DateTime.Now.AddDays(7);
        Response.Cookies.Add(userNameCookie);

        //HttpCookie creditCardNameCookie = new HttpCookie("CreditCardName", txtCreditCardName.Text);

        //creditCardNameCookie.Expires = DateTime.Now.AddDays(7);
        //Response.Cookies.Add(creditCardNameCookie);
    }
}
