using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string connectionString = "Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6D1AD_YahyaElrahim;User Id=DB_A6D1AD_YahyaElrahim_admin;Password=JOHNragad793";
            //string connectionString = "Data Source=JOHN-RH;Initial Catalog=Login;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select * from [DB_A6D1AD_YahyaElrahim].[dbo].[signup] where email='" + TextEmail.Text + "' and password ='" + TextPassword.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Response.Redirect("main.aspx");

            }
            else
            {
                LabelState.Text = "Giriş yapılamadı lütfen bilgilerinizi konreol ediniz";
            }
            
            connection.Close();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
}