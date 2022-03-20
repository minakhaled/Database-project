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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand viewsup = new SqlCommand("AdminListSup", conn);
            viewsup.CommandType = CommandType.StoredProcedure;

            SqlCommand viewsup1 = new SqlCommand("AdminViewAllTheses", conn);
            viewsup1.CommandType = CommandType.StoredProcedure;

            SqlCommand viewsup2 = new SqlCommand("AdminViewOnGoingTheses", conn);
            viewsup2.CommandType = CommandType.StoredProcedure;

            SqlParameter number = viewsup2.Parameters.Add("@thesesCount", SqlDbType.Int);


            number.Direction = ParameterDirection.Output;

            conn.Open();
            viewsup2.ExecuteNonQuery();
            SqlDataAdapter students = new SqlDataAdapter(viewsup);
            DataTable table = new DataTable();
            students.Fill(table);
            supdisplay.DataSource = table;
            supdisplay.DataBind();

            

            SqlDataAdapter students1 = new SqlDataAdapter(viewsup1);
            DataTable table1 = new DataTable();
            students1.Fill(table1);
            thesisdisplay.DataSource = table1;
            thesisdisplay.DataBind();

            Label typel = new Label();
            typel.Text ="The total number of on-going theses=" + number.Value.ToString();
            form1.Controls.Add(typel);




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            int seriall = Int32.Parse(serial.Text);
            Decimal amountt = Decimal.Parse(amount.Text);
            int numb = Int32.Parse(number.Text);
            Decimal percent = Decimal.Parse(fund.Text);

            SqlCommand viewsup = new SqlCommand("AdminIssueThesisPayment", conn);
            viewsup.CommandType = CommandType.StoredProcedure;

            viewsup.Parameters.Add(new SqlParameter("@ThesisSerialNo", seriall));
            viewsup.Parameters.Add(new SqlParameter("@amount", amountt));
            viewsup.Parameters.Add(new SqlParameter("@noOfInstallments", numb));
            viewsup.Parameters.Add(new SqlParameter("@fundPercentage", percent));

            conn.Open();
            viewsup.ExecuteNonQuery();
            conn.Close();

            Response.Write("Payment was issued successfully!!!");
            Response.AppendHeader("Refresh", "2");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            int numb = Int32.Parse(payid.Text);
            String date = install.Text;

            SqlCommand viewsup = new SqlCommand("AdminIssueInstallPayment", conn);
            viewsup.CommandType = CommandType.StoredProcedure;

            viewsup.Parameters.Add(new SqlParameter("@paymentID", numb));
            viewsup.Parameters.Add(new SqlParameter("@InstallStartDate", date));


            conn.Open();
            viewsup.ExecuteNonQuery();
            conn.Close();

            Response.Write("Installments were issued successfully!!!");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["WebApplication"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            int numb = Int32.Parse(TextBox1.Text);

            SqlCommand viewsup = new SqlCommand("AdminUpdateExtension", conn);
            viewsup.CommandType = CommandType.StoredProcedure;

            viewsup.Parameters.Add(new SqlParameter("@ThesisSerialNo", numb));


            conn.Open();
            viewsup.ExecuteNonQuery();
            conn.Close();

            Response.Write("Extension was added successfully!!!");
            Response.AppendHeader("Refresh", "2");
        }
    }
}