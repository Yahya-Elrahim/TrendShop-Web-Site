using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            LabelAccount.Text = "Giriş Yap";
            string connectionString = "Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6D1AD_YahyaElrahim;User Id=DB_A6D1AD_YahyaElrahim_admin;Password=JOHNragad793";
            //string connectionString = "Data Source=JOHN-RH;Initial Catalog=Login;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataReader myReader = null;
            string query2 = "select FullName from [DB_A6D1AD_YahyaElrahim].[dbo].[signup]";
            SqlCommand myCommand = new SqlCommand(query2, connection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                LabelAccount.Text = myReader.GetString(0);
                break;
            }
            myReader.Close();
            string query = "select quantity from [DB_A6D1AD_YahyaElrahim].[dbo].[orders]";
            SqlCommand myCommand2 = new SqlCommand(query, connection);
            myReader = myCommand2.ExecuteReader();
            int c = 0;
            while (myReader.Read())
            {
                c++;
            }
            LabelItems.Text = "Sepet " + c.ToString();




            connection.Close();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

 



    protected void Unnamed_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }

    

    protected void On_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;
        if(button.ID == brand.ID)
        {
            Response.Redirect("main.aspx");
        }
        else if (button.ID == LinkButton6.ID)
        {
            Response.Redirect("main.aspx");
        }
        else if (button.ID == LinkButton4.ID)
        {
            Response.Redirect("boysPage.aspx");
        }
        else if (button.ID == LinkButton3.ID)
        {
            Response.Redirect("girlsPage.aspx");

        }
        else if (button.ID == LinkButton2.ID)
        {
            Response.Redirect("menPage.aspx");
        }
        else if (button.ID == LinkButton1.ID)
        {
            Response.Redirect("womenPage.aspx");
        }
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("cart.aspx");
    }
}
