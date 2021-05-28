using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class singleShop : System.Web.UI.Page
{
    string imageURL, name, price;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        string [] names ={"Erkek Siyah Şişme Mont", "Erkek Beyaz Good Vibes", "Erkek T-shirti",
            "Erkek Sweatshirt Kırık", "Erkek Siyah Eşofman","Erkek Pantolon"," Erkek Jeans",
            "Erkek Koton Sort", "Erkek Deniz Şortu",
            "Kadın Pijama Takımı", "Kadın Gri Baskılı Pijama Takımı", "Kadın Siyah Elbise",
            "Kadın Fitilli Uzun Kol", "armonika Kadın Siyah Elbise", "Kadın Füme Yakas Elbise",
        "Kadın Siyah Omuzlu Elbise", "Kadın Siyah Tay Elbise", "Kadın Ekru Kazak",
        "Kadın-Siyah Gri Triko Kazak", "Erkek Çocuk Sweatshirt",
        "Erkek Çocuk Ekru S-Shirt", "Erkek Cocuk Pijama Takımı","Erkek Çocuk Kısa Kollu T-shirt",
        "Çocuk Sneaker", "Erkek Çocuk Şort","Uzun Kollu Poplin Gömlek"," Erkek Çocuk Gri Baskılı Sweatshirt",
        "Kız Çocuk Snoopy Lisanslı Pijama Takımı","Kız Çocuk Kırmızı Fiyonklu Elbise","Mor Prenses Kız Çocuk Elbise",
        "Kız Çocuk Pembe Pijama Takımı","Kız Çocuk Kısa Kollu T-shirt"," Kız Çocuk Desenli Tayt",
        "Kız Çocuk Ms. Beauty 4lü Elbise"," Kız Çocuk Özel Gün Elbise"};

        string[] prices = { "209.99TL", "119.99TL", "59.99TL","107.99TL","56.99TL",
            "129.99TL", "69.99TL","39.99TL","41.99TL",
            "119.99TL", "109.99TL", "69.99TL","49.99TL", "38.99TL", "52,99TL",
            "32.99TL", "89.99TL", "119.99","109", "44.99TL",
            "129.99TL","101.99TL", "16.99TL", "79.99TL","27.99TL","53.99TL","59.99TL",
            "64.99TL","104.99TL","156.99TL","47.99TL","28.99TL","69.99TL","189.99TL","195.99TL"};

        string[] shortDes = {"Erkek Siyah Şişme Mont", "Erkek Beyaz Good Vibes", "Erkek Beyaz Pis Yaka T-shirta",
            "Lufian Todillo Sweatshirt Kırık Beyaz 112030039",
            "Jessyamor Erkek Siyah Beli Lastikli Eşofman Altı 90020",
            "Pierre Cardin Erkek Pantolon G021GL078.000.1216759",
            "TRENDYOL MAN Gri Erkek Tırmık Yıpratmalı Skinny Jeans TMNAW20JE0253",
            "Koton Çift Cep Iki Farkli Kumastan Sort 1KAM01248NW",
            "Defacto Erkek Beyaz Çizgili Çapa Baskılı Deniz Şortu S6550AZ20HS",
            "US Polo Assn Kadın Elbise G082SZ075.000.10868", 
            "armoni kaKadın Gri Baskılı Pijama Takımı",
            "armonika Kadın Fitilli Uzun Kol", "Erkek Beyaz Good Vibes",
            "armonika Kadın Siyah Geometrik Desenli Balon Kol Elbise ARM-20K001099", 
            "armonika Kadın Füme Yakası Ve Altı Fırfırlı Desenli Elbise ARM-21K001041",
            "Cool & Sexy Kadın Siyah Omuzları Puantiyeli Tül Bluz EY1098",
            "Cool & sexy nice fit Kadın Siyah Tül Detaylı Tayt NF-1020-1",
            "Kadin Ekru Omuz Detaylı Triko Kazak TWOAW20XS0015", 
            "Cool & sexy Kadın-Siyah Gri Triko Kazak",
            "Defacto Erkek Çocuk Kapüşonlu Sweatshirt S0748A620WN",
            "Nebbati Erkek Çocuk Ekru S-Shirt 20FW0NB3413",
            "Marks & Spencer Gri Çocuk Desenli Pijama Takımı T86003704E",
            "Defacto Basic Kısa Kollu T-shirt K1687A6.20SP.RD227",
            "Kinetix Koyu Gri Unisex Çocuk Sneaker RIVERO",
            "Defacto Erkek Çocuk Regular Fit Bermuda Şort R2017A6.20SP.KH171",
            "Defacto Kız Çocuk Snoopy Lisanslı Pijama Takımı S8553A620WN",
            "Denokids Dream Big Kız Eşofman Takım CFF-20K1-003",
            "Minik Dolap Kız Çocuk Kırmızı Fiyonklu Siyah Beyaz Çizgili Elbise BNCIZ49",
            "Riccotarz Mor Güpürlü Prenses Kız Çocuk Elbise 2049481",
            "ASEL PİJAMALARI Kız Çocuk Pembe Mickey Desenli Pijama Takımı 701",
            "Defacto Kral Şakir Lisanslı Kısa Kollu T-shirt N8236A6.20SP.BK27",
            "Tyess Kız Çocuk Desenli Tayt 20fw0tj4213 20FW0TJ4213",
            "eliz kids Kız Çocuk Özel Gün Elbise 11582555"};

        string query = Request.QueryString["parameter"].ToString();

        name = names[Int32.Parse(query)];
        price = prices[Int32.Parse(query)];
        ProductName.Text = name;
        ProductName2.Text = names[Int32.Parse(query)];
        ProductPrice.Text = price;
        ProductDescreption.Text = shortDes[Int32.Parse(query)];

        imageURL = "~/demos/featured_" + query + ".jpg";
        ImagePreview.ImageUrl = imageURL;
    }


    protected void AddOrder_Click(object sender, EventArgs e)
    {

        try
        {
            string connectionString = "Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6D1AD_YahyaElrahim;User Id=DB_A6D1AD_YahyaElrahim_admin;Password=JOHNragad793";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string Query = "insert into [DB_A6D1AD_YahyaElrahim].[dbo].[orders] (name,price,path,quantity) values('" + name + "','" +price + "','" + imageURL + "', '" + TextBox.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            int cart = Convert.ToInt32(((Label)Master.FindControl("LabelItems")).Text);
            ((Label)Master.FindControl("LabelItems")).Text = (cart + 1).ToString();
            
        }
        catch (Exception)
        {
           
        }
    }
    protected void ButtonM_Click(object sender, EventArgs e)
    {
        
        int textDt = Int32.Parse(TextBox.Text.ToString());
        if (textDt > 0) {
            int temp = textDt - 1;
            TextBox.Text = temp.ToString();
        }
    }

    protected void ButtonPlus_Click(object sender, EventArgs e)
    {
        int textDt = Int32.Parse(TextBox.Text.ToString());
        int temp = textDt + 1;
        TextBox.Text = temp.ToString();
    }

    
}