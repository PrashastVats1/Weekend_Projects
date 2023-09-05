using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRegistrationForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                Label1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Visible = true;
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H3OMMTNN\SQLEXPRESS;Initial Catalog =AccountsDb;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Account where UserName=@uName and Password = @pwd", con);
                cmd.Parameters.AddWithValue("@uName", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Account");
                if (ds.Tables["Account"].Rows.Count == 0)
                {
                    Response.Write("Invalid User!!");
                }
                else
                {
                    Session["Username"] = TextBox1.Text; // Store the username in a session variable
                    Session["Password"] = TextBox2.Text;
                    Response.Redirect("Welcome.aspx");
                }
                con.Close();


            }
            catch (Exception ex)
            {
                Label1.Text = "Error" + ex.Message;
            }
            finally
            {

            }
        }
    }
}