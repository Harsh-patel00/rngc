using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Road_Garbage_Complain_System
{
    public partial class road_com : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\RnGC.mdf");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if(!FileUpload1.HasFile)
            {
            }
            else
            {
                int length = FileUpload1.PostedFile.ContentLength;
                byte[] pic = new byte[length];
                FileUpload1.PostedFile.InputStream.Read(pic, 0, length);
                SqlCommand cmd = new SqlCommand("insert into Road values('"+TextBox5.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+ "','" + FileUpload1 + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

            Response.Redirect("confirm.aspx");
        }


    }
}