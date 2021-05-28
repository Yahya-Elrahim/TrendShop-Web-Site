using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class womenPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;

        if (button.ID == LinkButton1.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "09");
        }
  
        else if (button.ID == LinkButton2.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "10");
        }
        else if (button.ID == LinkButton3.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "11");
        }
        else if (button.ID == LinkButton4.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "12");
        }
        else if (button.ID == LinkButton5.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "13");
        }
        else if (button.ID == LinkButton6.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "14");
        }
        else if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "15");
        }
        else if (button.ID == LinkButton8.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "16");
        }
        else if (button.ID == LinkButton9.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "17");
        }
        else if (button.ID == LinkButton10.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "18");
        }
      
    }
}
