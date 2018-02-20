using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
            if (Request.Cookies["UserName"] != null)
            {
                Label lblName = (Label)(Master.FindControl("lblLoginName"));
                lblName.Text = "Hello!" + Request.Cookies["UserName"].Value;
                LinkButton bt1 = (LinkButton)(Master.FindControl("btnLogOut"));
                bt1.Visible = true;
                Panel p1 = (Panel)(Master.FindControl("PanelLogin"));
                p1.Visible = false;
            }
        }

    }
    protected void LinkBtnViewAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("Products.aspx");
    }
    protected void LinkBtnMoreASP_Click(object sender, EventArgs e)
    {
        Session["CategoryID"] = "1001";
        Response.Redirect("Products.aspx");

    }
    protected void LinkBtnMoreDBMS_Click(object sender, EventArgs e)
    {
        Session["CategoryID"] = "1002";
        Response.Redirect("Products.aspx");
    }
    protected void LinkBtnMoreProgramming_Click(object sender, EventArgs e)
    {
        Session["CategoryID"] = "1003";
        Response.Redirect("Products.aspx");
    }
    protected void ImgBtnASP_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProductDetail.aspx?ProductID=3002");
    }
    protected void ImgBtnDBMS_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProductDetail.aspx?ProductID=3003");
    }
    protected void ImgBtnProgramming_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ProductDetail.aspx?ProductID=3006");
    }
}