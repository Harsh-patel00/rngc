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
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\RnGC.mdf");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into admin_table values('" + Session["Id"] + "','" + Session["uname"] + "','" + Session["s_city"] + "','" + Session["s_area"] + "', '" + Session["s_complaint"] + "')", con);
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from admin_table where Id = ('"+ TextBox1.Text +"')",con);
            cmd = new SqlCommand("delete from Rngc_login where Id = ('" + TextBox1.Text + "')", con);
            cmd = new SqlCommand("delete from Road where Id = ('" + TextBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select image from Road where Id = ('" + TextBox1.Text + "')",con);
            cmd.ExecuteScalar();
            //string strBase64 = Convert.ToBase64String(bytes);
            con.Close();
        }
    }
}