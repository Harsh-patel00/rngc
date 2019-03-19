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
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["a_uname"] = TextBox1.Text;
            Application["a_pass"] = TextBox2.Text;

            if (TextBox1.Text == Session["uname"].ToString() && TextBox2.Text == Session["pass"].ToString())
            {
                Response.Redirect("index.aspx");
            }
            else if ((Application["a_uname"].ToString() == "harsh" && Application["a_pass"].ToString() == "admin") || (Application["a_uname"].ToString() == "kush" && Application["a_pass"].ToString() == "admin"))
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "User does not exists !";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup_page.aspx");
        }

        public static bool check(string username)
        { 
            bool status = false;
            string constr = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("check", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username.Trim());
                    conn.Open();
                    status = Convert.ToBoolean(cmd.ExecuteScalar());
                    conn.Close();
                }
            }
            return status;


        }
    }
}