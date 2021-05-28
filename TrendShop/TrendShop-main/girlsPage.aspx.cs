using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class girlsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;

        if (button.ID == LinkButton1.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "27");
        }
        else if (button.ID == LinkButton2.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "28");
        }
        else if (button.ID == LinkButton3.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "29");
        }
        else if (button.ID == LinkButton4.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "30");
        }
        else if (button.ID == LinkButton5.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "31");
        }
        else if (button.ID == LinkButton6.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "32");
        }
        else if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "33");
        }
        else if (button.ID == LinkButton8.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "34");
        }

    }
}