using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class boysPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;

        if (button.ID == LinkButton1.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "19");
        }
        else if (button.ID == LinkButton2.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "20");
        }
        else if (button.ID == LinkButton3.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "21");
        }
        else if (button.ID == LinkButton4.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "22");
        }
        else if (button.ID == LinkButton5.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "23");
        }
        else if (button.ID == LinkButton6.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "24");
        }
        else if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "55");
        }
        else if (button.ID == LinkButton8.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "26");
        }
       
    }
}