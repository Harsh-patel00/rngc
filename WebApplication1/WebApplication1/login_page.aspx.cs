using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class login_page : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\RnGC.mdf");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup_page.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Session["a_user"] = "admin";
            Session["a_pass"] = "admin1";

            if ((TextBox1.Text != null) && (TextBox2.Text!=null))
            {
                Application["login_username"] = TextBox1.Text;
                Response.Redirect("index.aspx");
            }
            else if (TextBox1.Text == Session["a_user"].ToString() && TextBox2.Text == Session["a_pass"].ToString())
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "User does not exists !";
            }
            //Application["login_username"] = TextBox1.Text;
            //Response.Redirect("index.aspx");
        }
    }
}