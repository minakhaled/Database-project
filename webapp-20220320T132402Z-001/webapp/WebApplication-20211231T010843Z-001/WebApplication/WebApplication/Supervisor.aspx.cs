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
    public partial class Supervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int supid = (int) Session["user"];

            SqlCommand viewsup = new SqlCommand("ViewSupStudentsYears", conn);
            viewsup.CommandType = CommandType.StoredProcedure;
            viewsup.Parameters.Add(new SqlParameter("@supervisorID", supid));

            conn.Open();
            SqlDataAdapter students = new SqlDataAdapter(viewsup);
            DataTable table = new DataTable();
            students.Fill(table);
            StudentSupervised.DataSource = table;
            StudentSupervised.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int supid = Int32.Parse(studentid.Text);

            if (supid == 0)
            {
                Response.Write("Process was incomplete, please fill in all the following");
            }
            else
            {


                SqlCommand viewpub = new SqlCommand("ViewAStudentPublications", conn);
                viewpub.CommandType = CommandType.StoredProcedure;
                viewpub.Parameters.Add(new SqlParameter("@StudentID", supid));

                conn.Open();
                SqlDataAdapter students = new SqlDataAdapter(viewpub);
                DataTable table = new DataTable();
                students.Fill(table);
                StudentPublication.DataSource = table;
                StudentPublication.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Gucian
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int thesis = Int32.Parse(thesisserial.Text);
            String date = defensedate.Text;
            String place = defenselocation.Text;

            if (thesis == 0 || date == "" || place == "")
            {
                Response.Write("Process was incomplete, please fill in all the following");

            }
            else
            {



                SqlCommand adddefgucian = new SqlCommand("AddDefenseGucian", conn);
                adddefgucian.CommandType = CommandType.StoredProcedure;
                adddefgucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesis));
                adddefgucian.Parameters.Add(new SqlParameter("@DefenseDate", date));
                adddefgucian.Parameters.Add(new SqlParameter("@DefenseLocation", place));

                conn.Open();
                adddefgucian.ExecuteNonQuery();
                conn.Close();
                Response.Write("Defense Added Successfully!!");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Non-Gucian
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int thesis = Int32.Parse(thesisserial.Text);
            String date = defensedate.Text;
            String place = defenselocation.Text;

            if (thesis == 0 || date == "" || place == "")
            {
                Response.Write("Process was incomplete, please fill in all the following");

            }

            else
            {


                SqlCommand adddefgucian = new SqlCommand("AddDefenseNonGucian", conn);
                adddefgucian.CommandType = CommandType.StoredProcedure;
                adddefgucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesis));
                adddefgucian.Parameters.Add(new SqlParameter("@DefenseDate", date));
                adddefgucian.Parameters.Add(new SqlParameter("@DefenseLocation", place));

                conn.Open();
                adddefgucian.ExecuteNonQuery();
                conn.Close();
                Response.Write("Defense Added Successfully!!");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int thesis = Int32.Parse(thesis2.Text);
            String date = defensedate2.Text;
            String name = examinername.Text;
            String pass = password.Text;
            String field = fieldofwork.Text;
            String nat = nationality.Text;
            int s = 3;

            if(nat == "National")
            {
                s = 1;
            }else if(nat == "International"){
                s = 0;
            }


            if ((s == 1 || s == 0) && (thesis != 0 || date != "" || name != "" || pass != "" || field!="" || nat!=""))
            {
                SqlCommand adddefgucian = new SqlCommand("AddExaminer", conn);
                adddefgucian.CommandType = CommandType.StoredProcedure;
                adddefgucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesis));
                adddefgucian.Parameters.Add(new SqlParameter("@DefenseDate", date));
                adddefgucian.Parameters.Add(new SqlParameter("@ExaminerName", name));
                adddefgucian.Parameters.Add(new SqlParameter("@Password", pass));
                adddefgucian.Parameters.Add(new SqlParameter("@fieldOfWork", field));
                adddefgucian.Parameters.Add(new SqlParameter("@National", s));


                conn.Open();
                adddefgucian.ExecuteNonQuery();
                conn.Close();
                Response.Write("Examiner Added Successfully!!");
            }
            else
            {
                Response.Write("Please in the nationality field write either National or International and fill all the following!!!");

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Evaluate
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int thesis = Int32.Parse(thesis3.Text);
            String prog = progress.Text;
            int eval = Int32.Parse(Eval.Text);
            int supid = (int)Session["user"];

            if ((0<=eval && eval<=3) && (thesis!=0 || prog!="" || supid!=0)) {
                SqlCommand adddefgucian = new SqlCommand("EvaluateProgressReport", conn);
                adddefgucian.CommandType = CommandType.StoredProcedure;
                adddefgucian.Parameters.Add(new SqlParameter("@supervisorID", supid));
                adddefgucian.Parameters.Add(new SqlParameter("@thesisSerialNo", thesis));
                adddefgucian.Parameters.Add(new SqlParameter("@progressReportNo", prog));
                adddefgucian.Parameters.Add(new SqlParameter("@evaluation", eval));

                conn.Open();
                adddefgucian.ExecuteNonQuery();
                conn.Close();
                Response.Write("Progress Report Evaluated Successfully!!");
            }
            else
            {
                Response.Write("Please Enter Evaluation Value within the range 0 to 3");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Cancel Thesis
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int thesis = Int32.Parse(thesiscancel.Text);
            if (thesis == 0)
            {

                Response.Write("Process was incomplete, please fill in all the following");


            }
            else
            {


                SqlCommand adddefgucian = new SqlCommand("CancelThesis", conn);
                adddefgucian.CommandType = CommandType.StoredProcedure;
                adddefgucian.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesis));
                conn.Open();
                adddefgucian.ExecuteNonQuery();
                conn.Close();
                Response.Write("Thesis was canceled Successfully!!");
                Response.AppendHeader("Refresh", "2");
            }

        }
    }
    
}