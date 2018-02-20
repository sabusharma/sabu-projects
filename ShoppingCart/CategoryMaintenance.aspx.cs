using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CategoryMaintenance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsertCategory_Click(object sender, EventArgs e)
    {
        Category c = new Category();
       
        
        c.categoryName = txtBoxCategoryName.Text;
        c.categoryDesc = txtBoxCategoryDescription.Text;
        try
        {

            bool result = c.InsertCategory(c);
        
        if (result)
        {
            lblResult.Visible = true;
            lblResult.Text = " Data inserted !";

        }
        else
        {
            lblResult.Visible = true;
            lblResult.Text = " Error occured!";
        }

        GridView1.DataBind();

       txtBoxCategoryDescription.Text="";
        txtBoxCategoryName.Text="";
        }
        catch (Exception ex)
        {
            Session["Exception"] = ex;
            Response.Redirect("ErrorPage.aspx");
        }

    
    }
}