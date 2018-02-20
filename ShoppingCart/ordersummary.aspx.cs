using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ordersummary : System.Web.UI.Page
{
    ShoppingCart shopcart;
    Customer custo;
    Order neworder;
    double totalCost;

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
        }
        else
        {
            LinkButton bt1 = (LinkButton)Master.FindControl("btnLogOut");
            bt1.Visible = false;
        }

        totalCost = 0.0;

        shopcart = (ShoppingCart)Session["cartItem"];

        custo = (Customer)Session["CustDetails"];
        custo.email = Session["email"].ToString();

        if (!IsPostBack)
        {   
            GVOrderSummary.DataSource = shopcart.GetItems();
            GVOrderSummary.DataBind();

            lblBillName.Text = custo.firstName + " " + custo.lastName;
            lblBillAddress.Text = custo.address;
            lblBillCityStateZip.Text = custo.city + " " + custo.state + " " + custo.zip;
            lblBillPhone.Text = custo.phone;

            lblShipName.Text = custo.shippingFirstName + " " + custo.shippingLastName;
            lblShipAddress.Text = custo.shippingAddress;
            lblShipCityStateZip.Text = custo.shippingCity + " " + custo.shippingState + " " + custo.shippingZip;
            lblShipPhone.Text = custo.shippingPhone;
        }

        for (int i = 0; i < GVOrderSummary.Rows.Count; i++)
        {
            totalCost += Convert.ToDouble(GVOrderSummary.Rows[i].Cells[3].Text.Remove(0,1));
        }

        neworder = new Order(totalCost);
        lblTotalCost.Text = neworder.TotalCost.ToString("C");
        lblSalesTax.Text = neworder.SalesTax.ToString("C");
        lblShippingCost.Text = neworder.ShippingCost.ToString("C");
        lblNetTotal.Text = neworder.NetTotal.ToString("C");           
    }

    protected void GVOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        BookStore bs = new BookStore();
        int orderid = bs.PlaceOrder(custo, shopcart, totalCost);
        Server.Transfer("successpage.aspx?success=placeorder&orderid="+orderid.ToString());
    }
}
