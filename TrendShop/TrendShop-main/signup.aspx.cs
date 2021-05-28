using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI.WebControls;

public partial class signup2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        if(TextPassword.Text != TextConPassword.Text)
        {
            LabelState.Text = "Şifreler eşlesmiyor !";
            return;
        }


         try
         {
            
            string connectionString = "Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6D1AD_YahyaElrahim;User Id=DB_A6D1AD_YahyaElrahim_admin;Password=JOHNragad793";
           // Test etmek için local veri taban bağlantısı
            // string connectionString = "Data Source=JOHN-RH;Initial Catalog=Login;Integrated Security=True";
             SqlConnection connection = new SqlConnection(connectionString);
             connection.Open();

             string query = "SELECT * FROM [DB_A6D1AD_YahyaElrahim].[dbo].[signup] where email='" + TextEmail.Text + "'";

             SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

             DataTable dt = new DataTable();
             adapter.Fill(dt);
             if (dt.Rows.Count > 0)
             {
                 LabelState.Text = "E-posta adresiniz kayıtlı! başka e-posta kullanın veya şifreyi yenileyein.";

             }
             else
             {
            
                 string Query = "insert into [dbo].[signup] (FullName,email,password) values('" + this.TextName.Text + "','" + this.TextEmail.Text + "','" + this.TextPassword.Text + "');";
                 try
                 {
                     SqlCommand cmd = new SqlCommand(Query, connection);
                     cmd.ExecuteNonQuery();
                     connection.Close();
                      Response.Redirect("main.aspx");


                 }
                 catch (Exception ex)
                 {
                    LabelState.Text = ex.Message;
                 }
             }

             connection.Close();
         }
         catch (Exception ex)
         {
            LabelState.Text = ex.Message;
         }
    }
}
       