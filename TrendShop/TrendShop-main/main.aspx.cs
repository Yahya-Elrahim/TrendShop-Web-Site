using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        


    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;


         if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "16");
        }

        else if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "17");
        }
        else if (button.ID == LinkButton9.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "18");
        }
        else if (button.ID == LinkButton10.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "09");
        }
        else if (button.ID == LinkButton11.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "12");
        }
        else if (button.ID == LinkButton12.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "10");
        }
        else if (button.ID == LinkButton13.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "14");
        }
        else if (button.ID == LinkButton14.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "15");
        }
    }

    protected void Women_Click(object sender, EventArgs e)
    {
        Response.Redirect("womenPage.aspx");
    }

    protected void Men_Click(object sender, EventArgs e)
    {
        Response.Redirect("menPage.aspx");
    }
    protected void Boys_Click(object sender, EventArgs e)
    {
        Response.Redirect("boysPage.aspx");
    }
    protected void Girls_Click(object sender, EventArgs e)
    {
        Response.Redirect("girlsPage.aspx");
    }
}