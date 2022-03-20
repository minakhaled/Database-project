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
    public partial class SupervisorRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mail = email.Text;
            String pass = password.Text;
            String fname = firstname.Text;
            String lname = lastname.Text;
            String faculty = password.Text;


            if (mail == "" || pass == "" || fname == "" || lname == "" || faculty == "")
            {
                Response.Write("Registration was incomplete, please fill in all the following");

            }

            else
            {



                SqlCommand registerproc = new SqlCommand("supervisorRegister", conn);
                registerproc.CommandType = CommandType.StoredProcedure;
                registerproc.Parameters.Add(new SqlParameter("@first_name", fname));
                registerproc.Parameters.Add(new SqlParameter("@last_name", lname));
                registerproc.Parameters.Add(new SqlParameter("@password", pass));
                registerproc.Parameters.Add(new SqlParameter("@faculty", faculty));
                registerproc.Parameters.Add(new SqlParameter("@email", mail));





                conn.Open();
                registerproc.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("Login.aspx");
            }
        }
    }
    
}