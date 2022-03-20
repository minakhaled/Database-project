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
    public partial class Thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int supid = (int)Session["user"];

            SqlCommand viewsup = new SqlCommand("viewMyThesis", conn);
            viewsup.CommandType = CommandType.StoredProcedure;
            viewsup.Parameters.Add(new SqlParameter("@studentId", supid));

            conn.Open();
            SqlDataAdapter students = new SqlDataAdapter(viewsup);
            DataTable table = new DataTable();
            students.Fill(table);
            ThesisDisplay.DataSource = table;
            ThesisDisplay.DataBind();

            String s;
            int j = 0;
            while ( j<ThesisDisplay.Rows.Count)
            {
                s = ThesisDisplay.Rows[j].Cells[0].Text;

                LinkButton link = new LinkButton();
                link.ID = s;
                link.Text = s;
                link.Command += new CommandEventHandler(Data);
                ThesisDisplay.Rows[j].Cells[0].Controls.Add(link);

                j++;
            }
        }
        

        protected void Data (object sender, EventArgs e)
        {
            LinkButton q = (LinkButton)sender;
            Session["Thesis"] = q.ID;
            Response.Redirect("ProgressReport.aspx");
        }
    }
}