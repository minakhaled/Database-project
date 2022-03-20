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
    public partial class Examiner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            String namee = name.Text;
            int numb = Int32.Parse(Session["user"].ToString());
            String fieldof = field.Text;

            if (namee == "" || numb == 0 || fieldof == "")
            {
                Response.Write("Process was incomplete, please fill in all the following");

            }
            else
            {


                SqlCommand viewsup = new SqlCommand("ExaminerEditProfile", conn);
                viewsup.CommandType = CommandType.StoredProcedure;

                viewsup.Parameters.Add(new SqlParameter("@examinerID", numb));
                viewsup.Parameters.Add(new SqlParameter("@fieldofwork", fieldof));
                viewsup.Parameters.Add(new SqlParameter("@name", namee));


                conn.Open();
                viewsup.ExecuteNonQuery();
                conn.Close();

                Response.Write("Information Edited Successfully!!!");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int supid = (int)Session["user"];

            SqlCommand viewsup = new SqlCommand("ExaminerListAllTheses", conn);
            viewsup.CommandType = CommandType.StoredProcedure;
            viewsup.Parameters.Add(new SqlParameter("@examinerID", supid));

            conn.Open();
            SqlDataAdapter students = new SqlDataAdapter(viewsup);
            DataTable table = new DataTable();
            students.Fill(table);
            theses.DataSource = table;
            theses.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            String def = dd.Text;
            int numb = Int32.Parse(th.Text);
            String com = c.Text;

            if (def == "" || numb == 0 || com == "")
            {
                Response.Write("Process was incomplete, please fill in all the following");

            }
            else
            {


                SqlCommand viewsup = new SqlCommand("AddCommentsGrade", conn);
                viewsup.CommandType = CommandType.StoredProcedure;

                viewsup.Parameters.Add(new SqlParameter("@ThesisSerialNo", numb));
                viewsup.Parameters.Add(new SqlParameter("@DefenseDate", def));
                viewsup.Parameters.Add(new SqlParameter("@comments", com));


                conn.Open();
                viewsup.ExecuteNonQuery();
                conn.Close();

                Response.Write("Comment(s) Added Successfully!!!");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            String def = TextBox1.Text;
            int numb = Int32.Parse(TextBox2.Text);
            Decimal com = Decimal.Parse(TextBox3.Text);

            if (def == "" || numb == 0 || com == 0)
            {
                Response.Write("Process was incomplete, please fill in all the following");

            }
            else
            {


                SqlCommand viewsup = new SqlCommand("AddDefenseGrade", conn);
                viewsup.CommandType = CommandType.StoredProcedure;

                viewsup.Parameters.Add(new SqlParameter("@ThesisSerialNo", numb));
                viewsup.Parameters.Add(new SqlParameter("@DefenseDate", def));
                viewsup.Parameters.Add(new SqlParameter("@grade", com));


                conn.Open();
                viewsup.ExecuteNonQuery();
                conn.Close();

                Response.Write("Grade Added Successfully!!!");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            string supid = keyword.Text;

            if (supid == "")
            {

                Response.Write("Process was incomplete, please fill in all the following");


            }
            else
            {



                SqlCommand viewsup = new SqlCommand("ExaminerSearchThesis", conn);
                viewsup.CommandType = CommandType.StoredProcedure;
                viewsup.Parameters.Add(new SqlParameter("@key", supid));

                conn.Open();
                SqlDataAdapter students = new SqlDataAdapter(viewsup);
                DataTable table = new DataTable();
                students.Fill(table);
                searchresult.DataSource = table;
                searchresult.DataBind();
            }
            
        }
    }
    
}