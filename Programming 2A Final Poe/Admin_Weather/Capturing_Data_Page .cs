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
    public partial class Capturing_Data_Page : Form
    {
        
        public Capturing_Data_Page()
        {
            InitializeComponent();
        }
        SqlCommand cmd;

        //this is letting the user to exit or stay
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                //stay
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            //this is the connection 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            try
            {
                //this is the query for inserting data to the database's table 
                string Query = "Insert into [Weather_Inputs] Values('" + txtCity.Text + "','" + dTPCapture.Value.ToShortDateString() + "','" + Convert.ToInt32(txtMin.Text) + "','" + Convert.ToInt32(txtMax.Text) + "','" + Convert.ToInt32(txtPrecipitation.Text) + "','" + Convert.ToInt32(txtHumidity.Text) + "','" + Convert.ToInt32(txtWind.Text) + "')";


                //when the is empty fields message will will be displayed
                if (string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtMin.Text) || string.IsNullOrEmpty(txtMax.Text) || string.IsNullOrEmpty(txtPrecipitation.Text) || string.IsNullOrEmpty(txtHumidity.Text) || string.IsNullOrEmpty(txtWind.Text))
                {
                    
                    MessageBox.Show("Oups....Field Can't be null","Please Check Your Entry",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    return;
                }

                //when the is no empty fields message the data will be captured to table 
                if (!string.IsNullOrEmpty(txtCity.Text) || !string.IsNullOrEmpty(txtMin.Text) || !string.IsNullOrEmpty(txtMax.Text) || !string.IsNullOrEmpty(txtPrecipitation.Text) || !string.IsNullOrEmpty(txtHumidity.Text) || !string.IsNullOrEmpty(txtWind.Text))
                {
                    connection.Open();

                    cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data is Being Captured", "Data is Added To Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this is clearing city field
                    txtCity.Clear();
                    //this is clearing minimum field
                    txtMin.Clear();
                    //this is clearing Maximum field
                    txtMax.Clear();
                    //this is clearing precipitation field
                    txtPrecipitation.Clear();
                    //this is clearing wind speed field
                    txtWind.Clear();
                    //this is clearing Humidity field
                    txtHumidity.Clear();

                    return;
                 
                    connection.Close();
                }
              
           
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //this hides the current form and open the new one 
            this.Hide();
            new ViewAndEdit().ShowDialog();
        }
    }
    }

