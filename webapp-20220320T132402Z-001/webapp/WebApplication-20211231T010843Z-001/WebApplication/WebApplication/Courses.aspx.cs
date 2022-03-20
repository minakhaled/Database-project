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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int supid = (int)Session["user"];

            SqlCommand viewsup = new SqlCommand("ViewCoursesGrades", conn);
            viewsup.CommandType = CommandType.StoredProcedure;
            viewsup.Parameters.Add(new SqlParameter("@studentID", supid));

            conn.Open();
            SqlDataAdapter students = new SqlDataAdapter(viewsup);
            DataTable table = new DataTable();
            students.Fill(table);
            CoursesTB.DataSource = table;
            CoursesTB.DataBind();

        }
        
    }
}