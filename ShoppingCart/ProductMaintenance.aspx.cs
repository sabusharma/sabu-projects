using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductMaintenance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        Product p = new Product();
      
        
        p.productName = txtboxProductName.Text;
        p.categoryName = DropDownCategoryID.SelectedValue;
        p.price = txtBoxUnitPrice.Text.Trim();

        p.thumbnail = txtBoxThImageFile.Text;
        p.shortDesc = txtBoxShortDesc.Text;
        p.detailedDesc = txtBoxLongDesc.Text;
        p.isbn = txtBoxISBN.Text;
        p.image = txtBoxLargeImageFile.Text;

        bool result = p.InsertProduct(p);
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

      
        txtBoxISBN.Text = "";
        txtBoxThImageFile.Text = "";
        txtBoxLongDesc.Text = "";
        txtBoxShortDesc.Text = "";
        txtBoxLargeImageFile.Text = "";
        txtBoxUnitPrice.Text = "";
        txtboxProductName.Text = "";

    }

}