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
    public partial class AddPhones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Yes
            Response.Redirect("AddPhones.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //No
            Response.Redirect("StudentInfo.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mn = ph.Text;
            int id = (int)Session["user"];

            if (mn == "")
            {
                Response.Write("Please Enter a valid phone number");
            }

            else
            {


                SqlCommand phoneproc = new SqlCommand("addMobile", conn);
                phoneproc.CommandType = CommandType.StoredProcedure;
                phoneproc.Parameters.Add(new SqlParameter("@ID", id));
                phoneproc.Parameters.Add(new SqlParameter("@mobile_number", mn));

                conn.Open();
                phoneproc.ExecuteNonQuery();
                conn.Close();

                Response.Write("Phone Number Added Successfully!!");

            }
        }
    }
}