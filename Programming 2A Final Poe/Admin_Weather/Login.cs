using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin_Weather
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
        }

        //this is declaring sqlcommand for actions 
        SqlCommand cmd;
        //this is declaring sql reader for reading 
        SqlDataReader reader;
        private void button2_Click(object sender, EventArgs e)
        {
            //this is existing the application 
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                //stay
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is the connection for the database
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);


            try
            {
                //accessing the connestion 
                connection.Open();

                //declaring a query to be Executed
                string Query = "Select* from [Login_Details]";
                //passing the query for actions
                cmd = new SqlCommand(Query, connection);
                //this reads through the taBLE
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //THIS IS CHECKING null
                    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtpassword.Text))
                    {

                     MessageBox.Show("Oups....Field Can't be null", "Please Check Your Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    //this is allowing the Admin to login
                    if(!reader["Username"].ToString().Equals(txtUsername.Text) || !reader["Password"].ToString().Equals(txtpassword.Text))
                    {
                        //this loop is checking is admin is logging in 
                       

                            MessageBox.Show("Access Denied", "Oups......Double Check Your Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                           //this is clearing fields 
                            txtUsername.Clear();
                            txtpassword.Clear();
                       
                        
                       
                    }

                    //this is checking if conditions are met 
                    if (reader["Username"].ToString().Equals(txtUsername.Text) && reader["Password"].ToString().Equals(txtpassword.Text))
                    {
                        
                        if (txtUsername.Text.Equals("Admin") && txtpassword.Text.Equals("12345"))
                        {

                            MessageBox.Show("Access Granted To Weather Forecaster", "Welcome Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new Capturing_Data_Page().ShowDialog();

                            return;
                        }
                    }
                }
                connection.Close();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
    }
}
