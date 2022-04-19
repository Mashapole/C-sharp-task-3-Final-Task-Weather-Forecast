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
    public partial class ViewAndEdit : Form
    {
        public ViewAndEdit()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader reader;
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Capturing_Data_Page().ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to LogOut?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new frm_LogIn().ShowDialog();

            }
            else
            {
                //stay
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //this bind all data to datagrid
            dataGridView1.DataSource = GetData();
        }
        //this method is retriving the data and returning the found values
        private DataTable GetData()
        {
            //this is the connection to access the database 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            //this is the constructor to store data
            DataTable Poe = new DataTable();

            try
            {
                //this is the query that select all data from table 
                string Query = "Select* from [Weather_Inputs]";
                connection.Open();
                cmd = new SqlCommand(Query, connection);
                reader = cmd.ExecuteReader();

                //this load the table 
                Poe.Load(reader);

                connection.Dispose();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return Poe;

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //this regreshes the datagrid 
            dataGridView1.DataSource = GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //this clears the datagrid 
            dataGridView1.DataSource = " ";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //this clears the text field
            txt_Position.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //this is the connection to access the database 

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            try
            {
                //this is a querry that select everything from table
                string Query = "Select* from [Weather_Inputs]";

                connection.Open();
                cmd = new SqlCommand(Query, connection);
                reader = cmd.ExecuteReader();

                MessageBox.Show("Data is being retrived", "You can now edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (reader.Read())
                {
                    //this is displaying all the data to their textboxes
                    txtCity.Text = reader.GetValue(1).ToString();
                    txtMin.Text = reader.GetValue(3).ToString();
                    txtMax.Text = reader.GetValue(4).ToString();
                    txtPrecipitation.Text = reader.GetValue(5).ToString();
                    txtHumidity.Text = reader.GetValue(6).ToString();
                    txtWind.Text = reader.GetValue(7).ToString();
                }

                connection.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnViewEdited_Click(object sender, EventArgs e)
        {
            //this is clearing the text fields 
            txtCity.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtPrecipitation.Clear();
            txtHumidity.Clear();
            txtWind.Clear();
         
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            //this is the connection to access the tables 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);


            try
            {
                //this is checking empty field and throw an message
                if (string.IsNullOrEmpty(txtCity.Text) || string.IsNullOrEmpty(txtMin.Text) || string.IsNullOrEmpty(txtMax.Text) || string.IsNullOrEmpty(txtPrecipitation.Text) || string.IsNullOrEmpty(txtHumidity.Text) || string.IsNullOrEmpty(txtWind.Text))
                {

                    MessageBox.Show("Oups....Field Can't be null", "Please Check Your Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                //if there is no empty field, data is being edited
                if (!string.IsNullOrEmpty(txtCity.Text) || !string.IsNullOrEmpty(txtMin.Text) || !string.IsNullOrEmpty(txtMax.Text) || !string.IsNullOrEmpty(txtPrecipitation.Text) || !string.IsNullOrEmpty(txtHumidity.Text) || !string.IsNullOrEmpty(txtWind.Text))
                {
                    connection.Open();

                    //this is the query for inserting to the table 
                    string Query = "Update [Weather_Inputs] set [City]='" + txtCity.Text + "', [Date]='" + dtpDate.Value.ToShortDateString() + "', [Minimum_Temperature]='" + Convert.ToInt32(txtMin.Text) + "',[Maximum_Temperature]='" + Convert.ToInt32(txtMax.Text) + "',[Precipitation]='" + Convert.ToInt32(txtPrecipitation.Text) + "',[Humidity]='" + Convert.ToInt32(txtHumidity.Text) + "',[Wind_speed]='" + Convert.ToInt32(txtWind.Text) + "' where [Input_ID]='" + Convert.ToInt32(txt_Position.Text) + "'";
                    //this is passing query to the actions
                    cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data is being Updated", "Everythiong went well", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void ViewAndEdit_Load(object sender, EventArgs e)
        {

        }
    }
    }
   