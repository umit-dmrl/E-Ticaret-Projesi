using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret_Projesi
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
                cnn.Open();
                SqlCommand kayit = new SqlCommand("select * from admin where id=1",cnn);
                SqlDataReader oku = kayit.ExecuteReader();
                while (oku.Read())
                {
                    Response.Write(oku["id"].ToString() + "<br>" + oku["username"].ToString() + oku["password"].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Hata:"+ex);
            }
        }
    }
}