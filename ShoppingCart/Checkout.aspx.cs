using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    Customer cust;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["UserLoggedin"] != null && (bool)Session["UserLoggedin"] == true)
        {
            Panel p1 = (Panel)(Master.FindControl("PanelLogin"));
            p1.Visible = false;
            LinkButton bt1 = (LinkButton)(Master.FindControl("btnLogOut"));
            bt1.Visible = true;
            Label lblName = (Label)(Master.FindControl("lblLoginName"));
            if (Session["email"] != null)
                lblName.Text = "Hello! " + Session["email"].ToString();

            BookStore bs = new BookStore();

            cust = bs.CustomerBillingAddress(Session["email"].ToString());
            cust.email = Session["email"].ToString();

            lblBillName.Text = cust.firstName + " " + cust.lastName;
            lblBillAddress.Text = cust.address;
            lblBillCityStateZip.Text = cust.city + " " + cust.state + " " + cust.zip;
            lblBillPhone.Text = cust.phone;
     
        }
        else
        {

            LinkButton bt1 = (LinkButton)Master.FindControl("btnLogOut");
            bt1.Visible = false;
        }

        if (!IsPostBack)
        {
            lblShipName.Text = lblBillName.Text;
            lblShipAddress.Text = lblBillAddress.Text;
            lblShipCityStateZip.Text = lblBillCityStateZip.Text;
            lblShipPhone.Text = lblBillPhone.Text;

            linkbtnEditShipAddress.Visible = false;
            Session["CustDetails"] = cust;
        }

        
            panelUpdateBillingAddress.Visible = false;
            panelNewShippingAddress.Visible = false;
        

     

    }
    protected void checkboxSameShipAddress_CheckedChanged(object sender, EventArgs e)
    {
        if (!checkboxSameShipAddress.Checked)
        {
            lblShipName.Text = lblBillName.Text;
            lblShipAddress.Text = lblBillAddress.Text;
            lblShipCityStateZip.Text = lblBillCityStateZip.Text;
            lblShipPhone.Text = lblBillPhone.Text;
            linkbtnEditShipAddress.Visible = false;
        }

        else
        {
            linkbtnEditShipAddress.Visible = true;
            //panelNewShippingAddress.Visible = true;
        }
    }
    protected void linkbtnEditShipAddress_Click(object sender, EventArgs e)
    {
        panelNewShippingAddress.Visible = true;
    }
  
    protected void linkbtnEditBillAddress_Click(object sender, EventArgs e)
    {
        panelUpdateBillingAddress.Visible = true;
    }
    protected void btnContinueCheckout_Click(object sender, EventArgs e)
    {
        cust.shippingFirstName = lblShipName.Text.Split(' ')[0];
        cust.shippingLastName = lblShipName.Text.Split(' ')[1];
        cust.shippingAddress = lblShipAddress.Text;
        cust.shippingCity = lblShipCityStateZip.Text.Split(' ')[0];
        cust.shippingState = lblShipCityStateZip.Text.Split(' ')[1];
        cust.shippingZip = lblShipCityStateZip.Text.Split(' ')[2];
        cust.shippingPhone = lblShipPhone.Text;

        Session["CustDetails"] = cust;
        Server.Transfer("ordersummary.aspx");

    }

    protected void btnUpdateBillingAddress_Click(object sender, EventArgs e)
    {
        if (Session["CustDetails"] != null)
        {
            Customer cust = (Customer)Session["CustDetails"];
            cust.address = txtUpdateBillAddress.Text;
            cust.city = txtUpdateBillCity.Text;
            cust.state = txtUpdateBillState.Text;
            cust.zip = txtUpdateBillZip.Text;
            cust.phone = txtUpdateBillPhone.Text;

            BookStore bs = new BookStore();
            bs.UpdateCustomerBillingAddress(cust);

            Session["CustDetails"] = cust;

            Server.Transfer("checkout.aspx");
        }
    }
    protected void btnNewShippingAddress_Click(object sender, EventArgs e)
    {
        lblShipName.Text = txtNewShipFirstName.Text + " " + txtNewShipLastName.Text;
        lblShipAddress.Text = txtNewShipAddress.Text;
        lblShipCityStateZip.Text = txtNewShipCity.Text + " " + txtNewShipState.Text + " " + txtNewShipZip.Text;
        lblShipPhone.Text = txtNewShipPhone.Text;
    }
}
