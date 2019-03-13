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
    public partial class login_page : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
         AttachDbFilename = |DataDirectory|\RnGC.mdf;
         Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RnGC_login values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}