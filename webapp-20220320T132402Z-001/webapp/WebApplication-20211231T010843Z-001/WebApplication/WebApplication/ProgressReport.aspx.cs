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
    public partial class ProgressReport : System.Web.UI.Page
    {
        //string korty = new string();
        protected void Page_Load(object sender, EventArgs e)
        {
            ;
        }



        protected void submitbutton_Click(object sender, EventArgs e)
        {
            if (descripttext.Text.ToCharArray().Count() > 200)
            {
                Response.Write("Description exceeded 200 characters!");
            }
            else
            {
                String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                int id = (int)Session["user"];
                int serial = Int32.Parse(Session["Thesis"].ToString());

                SqlCommand fill = new SqlCommand("FillProgressReport", conn);
                string desc = descripttext.Text;
                int no = Int16.Parse(notext.Text);
                int state = Int16.Parse(statetext.Text);
                fill.CommandType = CommandType.StoredProcedure;

                if (desc == "" || no == 0 || statetext.Text == "")
                {

                    Response.Write("Process was incomplete, please fill in all the following");


                }
                else
                {


                    fill.Parameters.Add(new SqlParameter("@studentId", id));
                    fill.Parameters.Add(new SqlParameter("@description", desc));
                    fill.Parameters.Add(new SqlParameter("@progressReportNo", no));
                    fill.Parameters.Add(new SqlParameter("@state", state));
                    fill.Parameters.Add(new SqlParameter("@thesisSerialNo", serial));
                    conn.Open();
                    fill.ExecuteNonQuery();
                    conn.Close();


                    Response.Write("Progress report filled successfully!!");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int id = (int)Session["user"];
            int serial = Int32.Parse(Session["Thesis"].ToString());

            SqlCommand fill = new SqlCommand("AddProgressReport", conn);

            int no = Int16.Parse(progressrepno.Text);
            string desc = progressrepdate.Text;

            if (no == 0 || desc == "")
            {

                Response.Write("Process was incomplete, please fill in all the following");


            }
            else
            {



                fill.CommandType = CommandType.StoredProcedure;
                fill.Parameters.Add(new SqlParameter("@studentId", id));
                fill.Parameters.Add(new SqlParameter("@progressReportDate", desc));
                fill.Parameters.Add(new SqlParameter("@progressReportNo", no));
                fill.Parameters.Add(new SqlParameter("@thesisSerialNo", serial));

                conn.Open();
                fill.ExecuteNonQuery();
                conn.Close();


                Response.Write("Progress report added successfully!!");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand fill = new SqlCommand("addPublication", conn);

            string Title = title.Text;
            string pub = pubdate.Text;
            string hos = host.Text;
            string Pl = place.Text;


            int x = 0;

            if (Title == "" || pub == "" || hos == "" || Pl == "")
            {

                Response.Write("Process was incomplete, please fill in all the following");


            }

            else
            {


                fill.CommandType = CommandType.StoredProcedure;
                fill.Parameters.Add(new SqlParameter("@title", Title));
                fill.Parameters.Add(new SqlParameter("@pubDate", pub));
                fill.Parameters.Add(new SqlParameter("@host", hos));
                fill.Parameters.Add(new SqlParameter("@place", Pl));
                fill.Parameters.Add(new SqlParameter("@accepted", x));

                conn.Open();
                fill.ExecuteNonQuery();
                conn.Close();


                Response.Write("Publication added successfully!!");
            }
        }
    }
}