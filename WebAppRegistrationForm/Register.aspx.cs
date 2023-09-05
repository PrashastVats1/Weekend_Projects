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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label2.Visible = false;

            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                Label2.Visible = true;
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H3OMMTNN\SQLEXPRESS;Initial Catalog=AccountsDb;Integrated Security=true"))
                {
                    SqlCommand cmd = new SqlCommand("signup", con);

                    cmd.Parameters.AddWithValue("@uName", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@city", TextBox5.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    Label2.Text = "Registration success!!!";
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "Error: " + ex.Message;
            }
        }

    }
}