using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    string categoryID = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CategoryID"] != null)
            {
                categoryID = Session["CategoryID"].ToString();
            }
            if (!String.IsNullOrEmpty(categoryID))
                DDListCategory.SelectedValue = categoryID;
            Session["CategoryID"] = null;
        }
    }
    protected void DDListCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridViewProductListing_SelectedIndexChanged(object sender, EventArgs e)
    {
        string productID = GridViewProductListing.SelectedValue.ToString().Trim();
        Response.Redirect(String.Format("ProductDetail.aspx?ProductID={0}",productID));
    }
        
    
}