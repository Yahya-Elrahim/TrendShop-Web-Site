using System;
using System.Web.UI.WebControls;

public partial class MenPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;

        if (button.ID == LinkButton1.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "00");
        }
        else if (button.ID == LinkButton2.ID) {
            Response.Redirect("singleShop.aspx?parameter=" + "01");
        }
        else if (button.ID == LinkButton3.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "02");
        }
        else if (button.ID == LinkButton4.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "03");
        }
        else if (button.ID == LinkButton5.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "04");
        }
        else if (button.ID == LinkButton6.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "05");
        }
        else if (button.ID == LinkButton7.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "06");
        }
        else if (button.ID == LinkButton8.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "07");
        }
        else if (button.ID == LinkButton9.ID)
        {
            Response.Redirect("singleShop.aspx?parameter=" + "08");
        }
    }
}