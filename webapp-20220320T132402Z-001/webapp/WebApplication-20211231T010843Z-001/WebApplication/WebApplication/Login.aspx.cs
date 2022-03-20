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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mail = email.Text;
            String pass = password.Text;

            SqlCommand loginreturn = new SqlCommand("returnID", conn);
            loginreturn.CommandType = CommandType.StoredProcedure;
            loginreturn.Parameters.Add(new SqlParameter("@email", mail));

            SqlParameter id1 = loginreturn.Parameters.Add("@id", SqlDbType.Int);


            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@email", mail));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
            SqlParameter id = loginproc.Parameters.Add("@id", SqlDbType.Int);


            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            id.Direction = ParameterDirection.Output;
            id1.Direction = ParameterDirection.Output;


            conn.Open();
            loginproc.ExecuteNonQuery();
            loginreturn.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "1")
            {
                if (type.Value.ToString() == "0" || type.Value.ToString() == "4")
                {

                    Session["user"] = id1.Value;
                    Session["Student"] = type.Value;
                     Response.Redirect("PhoneEnquiry.aspx");
                    Response.Write(Session["Student"]);
                    Response.Write(Session["user"]);
                }

                if (type.Value.ToString() == "1")
                {
                    Session["user"] = id1.Value;
                    Response.Redirect("Admin.aspx");
                }


                if (type.Value.ToString() == "2")
                {
                    Session["user"] = id1.Value;
                    Response.Redirect("Supervisor.aspx");
                }

                if (type.Value.ToString() == "3")
                {
                    Session["user"] = id1.Value;
                    Response.Redirect("Examiner.aspx");
                }
            }
            else
            {
                Response.Write("Email or Password were incorrect!");
            }
            

        }

        protected void Register(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("StudentRegistration.aspx");
        }

        protected void Register2(object sender, EventArgs e)
        {

            Response.Redirect("SupervisorRegistration.aspx");


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExaminerRegister.aspx");
        }
    }
}