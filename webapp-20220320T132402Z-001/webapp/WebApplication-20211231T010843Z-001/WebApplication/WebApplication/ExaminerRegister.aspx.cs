using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ExaminerRegister : System.Web.UI.Page
    {
       public int x = 3;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mail = email.Text;
            String pass = password.Text;
            String fname = name.Text;
            String faculty = field.Text;

            if (mail == "" || pass == "" || fname == "" || faculty == "" || x == 3)
            {
                Response.Write("Registration was incomplete, please fill in all the following");

            }

            else
            {



                SqlCommand registerproc = new SqlCommand("ExaminerRegister", conn);
                registerproc.CommandType = CommandType.StoredProcedure;
                registerproc.Parameters.Add(new SqlParameter("@name", fname));
                registerproc.Parameters.Add(new SqlParameter("@password", pass));
                registerproc.Parameters.Add(new SqlParameter("@fieldofwork", faculty));
                registerproc.Parameters.Add(new SqlParameter("@email", mail));
                registerproc.Parameters.Add(new SqlParameter("@nationality", x));






                conn.Open();
                registerproc.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("Login.aspx");
            }
        }

        protected void Yes_CheckedChanged(object sender, EventArgs e)
        {
            //National
            x = 0;
        }

        protected void No_CheckedChanged(object sender, EventArgs e)
        {
            //International
            x = 1;
        }
    }
}