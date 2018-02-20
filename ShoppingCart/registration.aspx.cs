using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registration1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {       

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            Customer cust = new Customer();
            cust.email = txtEmail.Text;
            cust.password = txtPassword.Text;
            cust.lastName = txtLastName.Text;
            cust.firstName = txtFirstName.Text;
            cust.address = txtAddress.Text;
            cust.city = txtCity.Text;
            cust.state = txtState.Text;
            cust.zip = txtZip.Text;
            cust.secretQuestion = txtSecretQn.Text;
            cust.secretAnswer = txtAns.Text;
            cust.phone = txtPhone.Text;
            BookStore bs = new BookStore();
            string msg = bs.CustomerRegistration(cust);

            if (msg == "Success")
            {
                Server.Transfer("successpage.aspx?success=signup");
            }
            else
            {
                lblRegistrationMsg.Text = msg;
                lblRegistrationMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Server.Transfer("default.aspx");
    }
}
