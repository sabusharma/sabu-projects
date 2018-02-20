using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        Customer cust = new Customer();
        TextBox tb = (TextBox)(this.FindControl("txtUserName"));
        cust.email = tb.Text;

        TextBox tb2 = (TextBox)(this.FindControl("txtLoginPassword"));
        cust.password = tb2.Text;

        if (cust.email != null && cust.email != "" && cust.password != null && cust.password != "")
        {
            BookStore bs = new BookStore();
            if (bs.ValidateCustomer(cust))
            {
                Session["UserLoggedin"] = true;
                Panel p1 = (Panel)(this.FindControl("PanelLogin"));
                p1.Visible = false;
                LinkButton bt1 = (LinkButton)(this.FindControl("btnLogOut"));
                bt1.Visible = true;

                Label lblName = (Label)(this.FindControl("lblLoginName"));
                lblName.Text = "Hello! " + cust.email;
                Session["email"] = cust.email;
                AddCookie();
            }

            else
            {
                Label lbl = (Label)(this.FindControl("lblInvalidLogin"));
                lbl.Text = "Invalid Login";
            }
        }

        else
        {
            Label lbl = (Label)(this.FindControl("lblInvalidLogin"));
            lbl.Text = "Please enter email & password";
        }

    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["UserLoggedin"] = null;
        Session["email"] = null;
        DeleteCookie();
        Response.Redirect("Default.aspx");
        
    }
    private void AddCookie()

    {
        TextBox tb = (TextBox)(this.FindControl("txtUserName"));
        HttpCookie userNameCookie = new HttpCookie("UserName",tb.Text);
        userNameCookie.Expires = DateTime.Now.AddDays(7);
        Response.Cookies.Add(userNameCookie);

        
    }
    private void DeleteCookie()
    {
        HttpCookie userNameCookie = new HttpCookie("UserName");

        userNameCookie.Expires = DateTime.Now.AddSeconds(-1);
        Response.Cookies.Add(userNameCookie);
       
    }
}
