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
        if (Request.QueryString["success"] == "placeorder")
        {
            string orderid = Request.QueryString["orderid"];
            lblSuccessful.Text = "Your Order has been placed successfully. The item will be shipped soon. Thank you for your purchase.";
            lblShowOrderID.Text = "Your Order Number is: " + orderid;
            Session["cartItem"] = null;
            Session["CustDetails"] = null;

        }
        else if (Request.QueryString["success"] == "signup")
        {
            lblSuccessful.Text = " Your account has been created successfully.";
            
        }


        else if (Request.QueryString["success"] == "contact")
        {
            lblSuccessful.Text = "Your message has been sent succeccfully. Thank you for mailing us.";
        }
    }
    protected void btnSignupContinue_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx");
    }
}
