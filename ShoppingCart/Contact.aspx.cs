using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["UserName"] != null)
            {
                // Label lblName = (Label)(Master.FindControl("lblLoginName"));
                lblRevisitedUser.Visible = true;
                lblRevisitedUser.Text = "Hello!" + Request.Cookies["UserName"].Value;

            }
            else
                lblRevisitedUser.Visible = false;
        }


    }
    protected void btnContactSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            CustomerMessageStore cust = new CustomerMessageStore();

            cust.lastName = txtLastName.Text;
            cust.firstName = txtFirstName.Text;
            cust.email = txtEmail.Text;
            cust.subject = txtSubject.Text;
            cust.message = txtMessage.Text;

            BookStore  bl = new BookStore ();
            bl.CustomerMessage(cust);
            AddCookie();
            Server.Transfer("successpage.aspx?success=contact");
            

        }
    }
    private void AddCookie()
    {
        //TextBox tb = (TextBox)(this.FindControl("txtUserName"));
        HttpCookie userNameCookie = new HttpCookie("UserName", txtEmail.Text);
        userNameCookie.Expires = DateTime.Now.AddDays(7);
        Response.Cookies.Add(userNameCookie);


    }
}