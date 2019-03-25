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
            if (!(Application["login_username"].ToString() == "admin"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Id from RnGC_signup where Username=('" + Application["login_username"] + "')", con);
                DataSet ds0 = new DataSet();
                da.Fill(ds0, "RnGC_signup");
                DataTable dt0 = ds0.Tables[0];
                con.Close();
                TextBox5.Text = dt0.Rows[0]["Id"].ToString();
                TextBox5.ReadOnly.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if(!FileUpload1.HasFile)
            {
            }
            else
            {
                //int length = FileUpload1.PostedFile.ContentLength;
                //byte[] pic = new byte[length];
                //FileUpload1.PostedFile.InputStream.Read(pic, 0, length);
                SqlCommand cmd = new SqlCommand("insert into Road values('" + FileUpload1 + "','" + TextBox5.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            Response.Redirect("confirm.aspx");
        }


    }
}