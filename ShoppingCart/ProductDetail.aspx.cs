using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetail : System.Web.UI.Page
{
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

        if (!IsPostBack)
        {
            string ProductID = Request.QueryString["ProductID"];
            BookStore bs = new BookStore();
            DVProductDetails.DataSource = bs.ProductDetails(ProductID);
            DVProductDetails.DataBind();
        }

    }
    protected void DVProductDetails_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void btnContinueShopping_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx");
    }
    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        string productID = DVProductDetails.Rows[1].Cells[1].Text;
        string productName = DVProductDetails.Rows[2].Cells[1].Text;
        double unitPrice = Convert.ToDouble(DVProductDetails.Rows[5].Cells[1].Text.Remove(0,1));
        
        ShoppingCart cartItem;


        if (Session["cartItem"] == null)
        {
            cartItem = new ShoppingCart();
            Session["cartItem"] = cartItem;
        }

        else
        {
            cartItem = (ShoppingCart)Session["cartItem"];
        }

        cartItem.AddItems(productID, productName, unitPrice);

        Response.Redirect(String.Format("cart.aspx?ProductID={0}", productID));
        
         
    }

  

    
}
