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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RnGC.mdf");
            con.Open();
            if(!FileUpload1.HasFile)
            {
            }
            else
            {
                int length = FileUpload1.PostedFile.ContentLength;
                byte[] pic = new byte[length];
                FileUpload1.PostedFile.InputStream.Read(pic, 0, length);
                SqlCommand cmd = new SqlCommand("insert into Road values('"+TextBox5.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+FileUpload1+"','"+TextBox4.Text+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

            Response.Redirect("confirm.aspx");
        }


    }
}