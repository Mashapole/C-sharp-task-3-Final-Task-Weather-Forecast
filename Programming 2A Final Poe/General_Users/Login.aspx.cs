using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace General_Users
{
    public partial class Login : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Login_Click(object sender, EventArgs e)
        {
            //this is the connection for the database
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            try
            {


                connection.Open();

                //this is the query to select evrything from user's details 
                string Query = "Select* from [Login_Details]";
                cmd = new SqlCommand(Query, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //this is checking the user who is logging in
                    if (reader["Username"].ToString().Equals(txt_Username.Text) && reader["Password"].ToString().Equals(txt_Password.Text))
                    {
                        //this loop is checking if the person who is logging in is not admin
                        if (!txt_Username.Text.Equals("admin") && !txt_Password.Text.Equals("12345"))
                        {
                            Session["Username"] = reader["Username"].ToString();
                            MessageBox.Show("Welcome General User");
                            Response.Redirect("View.aspx");
                        }
                    }

                }
                connection.Dispose();
                connection.Close();
            }
            catch (Exception)
            {
                Response.Write("< script > alert('oups Something went Wrong!!!'); </ script >");
            }

        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            //this is calling the register page
            Response.Redirect("Register.aspx");
        }

        protected void btn_Exit_Click(object sender, EventArgs e)
        {
            //this is existing the application 
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else
            {
                //stay
            }
        }

        protected void txt_Password_TextChanged(object sender, EventArgs e)
        {
            //txt_Password.te = '*';
        }
    }
}