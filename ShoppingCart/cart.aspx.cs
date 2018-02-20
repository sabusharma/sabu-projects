using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cart : System.Web.UI.Page
{
    ShoppingCart shopcart;
    
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


        if (Session["cartItem"] == null)
        {
            shopcart = new ShoppingCart();
            Session["cartItem"] = shopcart; 
        }
        else
        {
            shopcart = (ShoppingCart)Session["cartItem"];
        }
        if (shopcart.Count<1) 
        {
            
            lblEmptyCartMsg.Visible = true;
            lblEmptyCartMsg.Text = "Your Cart is Empty";
            btnCheckout.Enabled = false;
        }
        else
        {
            lblEmptyCartMsg.Visible = false;
            btnCheckout.Enabled = true;


        }

        if (!IsPostBack)
        {
            GVCart.DataSource = shopcart.GetItems();
            GVCart.DataBind();
            
        }

        
    }
    
    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {
        Server.Transfer("default.aspx");
    }
  
    protected void GVCart_RowDeleting(object sender, GridViewDeleteEventArgs e)

    {
        
        
        int s = e.RowIndex;
        shopcart.RemoveItem(e.RowIndex);
        if (shopcart.Count < 1)
        {
            btnCheckout.Enabled = false;
            lblEmptyCartMsg.Visible = true;
            lblEmptyCartMsg.Text = "Your Cart is Empty";
        }
        GVCart.DataSource = shopcart.GetItems();
        GVCart.DataBind();
        
        

        
    }
    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        if (Session["UserLoggedin"] != null && (bool)Session["UserLoggedin"] == true)
        {
            Server.Transfer("checkout.aspx");
        }
        else
        {
            Server.Transfer("loginpage.aspx");
        }
    }

    protected void GVCart_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    
   
}
