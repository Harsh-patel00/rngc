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
    public partial class confirm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\RnGC.mdf;
                Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Road set city=('"+ TextBox2.Text + "'),location=('" + TextBox3.Text + "') where Id=('" + TextBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("confirm.aspx");
        }
    }
}