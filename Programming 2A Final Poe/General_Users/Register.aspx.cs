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
    public partial class Register : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Register_Click(object sender, EventArgs e)
        {
            //this is the connection for accessing databases
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            try
            {
                //this is checkin if textboxes they are not empty if they are, is throwing error
                if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Confirm.Text))
                {
                    MessageBox.Show("Oups.....username can't be empty or Check Your password and also confirm it", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //this else statment is allowing user to register if the is no null fields 
                else if (txt_Password.Text == txt_Confirm.Text)
                {
                    //this is the query for inserting to the tables
                    string Query = "Insert into [Login_Details] Values('" + txt_Username.Text + "','" + txt_Password.Text + "','" + txt_Confirm.Text + "')";
                    connection.Open();
                    cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Your Information is being captured", "Information is being Added to Our System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //this is the error showing the password is not matching 
                    MessageBox.Show("Information Provided Doesnt Match", "Registration Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btn_Continue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

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
    }
}