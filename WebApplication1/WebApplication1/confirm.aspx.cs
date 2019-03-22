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

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Road where id='" + TextBox1.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"Road");
            DataTable dt = ds.Tables[0];
            con.Close();
            TextBox1.Text = dt.Rows[0]["id"].ToString();
            TextBox2.Text = dt.Rows[0]["city"].ToString();
            TextBox3.Text = dt.Rows[0]["location"].ToString();
            TextBox4.Text = dt.Rows[0]["complaint"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Road where Id=('"+TextBox1.Text+"')" ,con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("confirm.aspx");
        }
    }
}