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
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewProfile = new SqlCommand("viewMyProfile", conn);
            int id = (int)Session["user"];
            viewProfile.CommandType = CommandType.StoredProcedure;
            viewProfile.Parameters.Add(new SqlParameter("@studentId", id));

            conn.Open();

            SqlDataReader rdr = viewProfile.ExecuteReader(CommandBehavior.CloseConnection);

            if (Session["Student"].ToString() == "0")
            {


                while (rdr.Read())
                {
                    String fname = rdr.GetString(rdr.GetOrdinal("firstName"));
                    Label fnamel = new Label();
                    fnamel.Text = fname + "\n";
                    form1.Controls.Add(fnamel);


                    String lname = rdr.GetString(rdr.GetOrdinal("lastName"));
                    Label lnamel = new Label();
                    lnamel.Text = lname + "\n";
                    form1.Controls.Add(lnamel);

                    if (!(rdr.IsDBNull(rdr.GetOrdinal("type"))))
                    {
                        String type = rdr.GetString(rdr.GetOrdinal("type"));
                        Label typel = new Label();
                        typel.Text = type + "\n";
                        form1.Controls.Add(typel);
                    }
                

                    String faculty = rdr.GetString(rdr.GetOrdinal("faculty"));
                    Label facultyl = new Label();
                    facultyl.Text = faculty + "\n";
                    form1.Controls.Add(facultyl);
                   

                    String address = rdr.GetString(rdr.GetOrdinal("address"));
                    Label addressl = new Label();
                    addressl.Text = address + "\n";
                    form1.Controls.Add(addressl);

                    if (!(rdr.IsDBNull(rdr.GetOrdinal("gpa")))){
                        int gpa = rdr.GetInt32(rdr.GetOrdinal("gpa"));
                        Label gpal = new Label();
                        gpal.Text = gpa.ToString() + "\n";
                        form1.Controls.Add(gpal);
                    }
                    if (!(rdr.IsDBNull(rdr.GetOrdinal("undergradID"))))
                    {
                        int undergrad = rdr.GetInt32(rdr.GetOrdinal("undergradID"));
                        Label undergradl = new Label();
                        undergradl.Text = undergrad.ToString() + "\n";
                        form1.Controls.Add(undergradl);
                    }
                }
            }
            else
            {
                while (rdr.Read())
                {
                    String fname = rdr.GetString(rdr.GetOrdinal("firstName"));
                    Label fnamel = new Label();
                    fnamel.Text = fname + "\n";
                    form1.Controls.Add(fnamel);
                    

                    String lname = rdr.GetString(rdr.GetOrdinal("lastName"));
                    Label lnamel = new Label();
                    lnamel.Text = lname + "\n";
                    form1.Controls.Add(lnamel);

                    if (!(rdr.IsDBNull(rdr.GetOrdinal("type"))))
                    {
                         String type = rdr.GetString(rdr.GetOrdinal("type"));
                         Label typel = new Label();
                         typel.Text = type + "\n";
                         form1.Controls.Add(typel);

                    }
                        String faculty = rdr.GetString(rdr.GetOrdinal("faculty"));
                    Label facultyl = new Label();
                    facultyl.Text = faculty + "\n";
                    form1.Controls.Add(facultyl);
                    

                    String address = rdr.GetString(rdr.GetOrdinal("address"));
                    Label addressl = new Label();
                    addressl.Text = address + "\n";
                    form1.Controls.Add(addressl);

                    if (!(rdr.IsDBNull(rdr.GetOrdinal("gpa"))))
                    {
                        int gpa = rdr.GetInt32(rdr.GetOrdinal("gpa"));
                        Label gpal = new Label();
                        gpal.Text = gpa.ToString() + "\n";
                        form1.Controls.Add(gpal);
                    }
                }
                

               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Thesis.aspx");
        }

        protected void Gotocourses(object sender, EventArgs e)
        {
            Response.Redirect("Courses.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["Student"].ToString() == "4") {
                Response.Redirect("Courses.aspx");
                    }
            else
            {
                Response.Write("You are Gucian!");
            }
        }
    }
}