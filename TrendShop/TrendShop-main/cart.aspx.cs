using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class cart : System.Web.UI.Page
{
    double sum = 10;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            string connectionString = "Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6D1AD_YahyaElrahim;User Id=DB_A6D1AD_YahyaElrahim_admin;Password=JOHNragad793";
            //string connectionString = "Data Source=JOHN-RH;Initial Catalog=Login;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT price, quantity FROM [DB_A6D1AD_YahyaElrahim].[dbo].[orders]";

            using (SqlCommand adapter = new SqlCommand(query, connection))
            {
                SqlDataReader reader = adapter.ExecuteReader();

                
                while (reader.Read())
                {
                    string t1 = reader.GetString(0);
                    string t2 = reader.GetString(1);
                    updateBill(t1.Replace("TL", ""), t2);
                 
                }

                Total.Text = sum.ToString();
            }

           

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    private void updateBill(string pr, string qu)
    {
        double price = Convert.ToDouble(pr);
        double quan = Convert.ToDouble(qu);

        sum += price * quan;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
}