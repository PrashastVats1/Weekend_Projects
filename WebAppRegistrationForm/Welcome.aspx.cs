using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRegistrationForm
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    string username = Session["Username"].ToString();
                    Label1.Text = "Welcome, " + username + "!";
                    Console.WriteLine();
                    string password = Session["Password"].ToString();
                    Label2.Text = "Your password is " + password + "!";
                }
                else
                {
                    // Handle the case where the session variable is not set (e.g., if the user directly navigates to the welcome page without logging in)
                    Label1.Text = "Welcome!";
                }
            }
        }

    }
}