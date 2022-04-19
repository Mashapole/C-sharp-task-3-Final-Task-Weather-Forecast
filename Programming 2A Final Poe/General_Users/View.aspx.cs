using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace General_Users
{
    public partial class View : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlDataReader reader;
                //this is the connection  for accessing databasess
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

                try
                {
                    connection.Open();
                    //this is the query that is selecting cities from favourite 
                    string Query = "Select  Distinct city from Favorite where username='" + Session["Username"].ToString() + "'";
                    cmd = new SqlCommand(Query, connection);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //this string is storing cities before adding to list 
                        string holder = reader["City"].ToString();

                        ListBox_favorite.Items.Add(new ListItem(holder));




                    }

                    connection.Close();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                try
                {
                    //this method is filling the list boxe
                    FillList();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                try

                {
                    //this method is filling the dropdown list 
                    fillDropdown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }

        }

        //this is the method that is filling dropdown list with cities
        private void fillDropdown()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            string query = "Select Distinct city from [Weather_Inputs]";

            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable shake = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);

            dt.Fill(shake);

            foreach (DataRow x in shake.Rows)
            {
                ddl_Cities.Items.Add(x["city"].ToString());


            }
            connection.Close();


        }


        //this is the method that is filling listbox list with cities
        private void FillList()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            string query = "Select Distinct city from [Weather_Inputs]";

            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            DataTable shake = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);

            dt.Fill(shake);

            foreach (DataRow x in shake.Rows)
            {
                LstBox_Cities.Items.Add(x["city"].ToString());


            }
            connection.Close();


        }



        //this button is where user will specify cities he/she wanna view
        protected void btn_Specify_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            try
            {


                //this string is storing nformation 
                string alldata = " ";
                String query;

                //this is interacting through the listbox 
                foreach (ListItem item in LstBox_Cities.Items)

                {
                    connection.Open();
                    //this is checking the selected city
                    if (item.Selected == true)
                    {

                        //this is the query for selecting everything from table
                        query = "select* from [Weather_Inputs] Where city='" + item.Text + "'";
                        cmd = new SqlCommand(query, connection);

                        //this is reading the data found 
                        reader = cmd.ExecuteReader();

                        if (reader.Read() == true)
                        {
                            //this is storing data that is being read 
                            alldata += reader["Input_ID"].ToString() + " \t  " + reader["City"].ToString() + "  \t" + reader["Minimum_Temperature"] + "     \t" + reader["Maximum_Temperature"] + "       \t" + reader["Precipitation"] + "\t    " + reader["Humidity"] + "   \t" + reader["Wind_speed"] + "   \t" + reader["Date"].ToString() + "\n";

                        }

                        ///this is displaying data
                        txtA_Report.Value = alldata;


                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {


                foreach (ListItem item in LstBox_Cities.Items)

                {

                    if (item.Selected == true)
                    {
                        //this method is adding the cityu to the favorite table 
                        Insert_to_Favourite(item);

                    }

                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            try
            {



                foreach (ListItem item in LstBox_Cities.Items)

                {
                    if (item.Selected == true)
                    {
                        //if the city is already in the listbox wont be added 
                        if (!ListBox_favorite.Items.Contains(item))
                        {
                            //this is adding the city to the list box for temporary when selected 
                            ListBox_favorite.Items.Add(new ListItem(item.Text));

                        }
                        else
                        {
                            MessageBox.Show("City is already added");
                        }



                    }

                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //this method is adding to the favorite TABLE into the databse
        private void Insert_to_Favourite(ListItem item)
        {
            //this is opening the connection 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            //this ivariable is going to store user id as foreign key
            int user_id;
            //this ivariable is going to store Input id as foreign key
            int Input_id;

            //this is getting the user id from the login details as foreign key
            string Query = "select Max(User_ID) from Login_Details";
            //this is getting the Input id from the login details as foreign key
            string Query2 = "select Max(Input_ID) from [Weather_Inputs]";


            connection.Open();

            //this is perfoming actions 
            SqlCommand cmd0 = new SqlCommand(Query, connection);
            SqlCommand cmd00 = new SqlCommand(Query2, connection);

            //this is converting to scharlar 
            Input_id = Convert.ToInt32(cmd00.ExecuteScalar());
            user_id = Convert.ToInt32(cmd0.ExecuteScalar());



            if (!ListBox_favorite.Items.Contains(item))
            {
                //this code is adding to the favourite table 
                SqlCommand cmd1 = new SqlCommand("Insert into [Favorite](Username,City,User_ID,Input_ID) values(@Username,@City,@User_ID,@Input_ID)", connection);
                cmd1.Parameters.AddWithValue("@Username", Session["Username"]);
                cmd1.Parameters.AddWithValue("@City", item.Text);
                cmd1.Parameters.AddWithValue("@user_Id", user_id);
                cmd1.Parameters.AddWithValue("@Input_ID", Input_id);

                MessageBox.Show("Data is Added To Favorite");

                cmd1.ExecuteNonQuery();




            }


        }


        protected void btn_View_All_Click(object sender, EventArgs e)
        {
            try
            {//this method is filling the grid view 
                fillGrid();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //this is filling the grid view with data 
        private void fillGrid()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            string Query = "Select* from [Weather_Inputs]";

            connection.Open();
            cmd = new SqlCommand(Query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adapter.Fill(set);
            GdV_Data.DataSource = set;
            GdV_Data.DataBind();

            connection.Close();

        }

        protected void btn_Favorite_Click(object sender, EventArgs e)
        {
            try
            {
                //this method is filling the list box
                FavoriteFill();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //this method is filling the list box
        private void FavoriteFill()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            //this query is joining two tables
            string Querry = "select b.City,Q.Date,Q.Minimum_Temperature,Q.Maximum_Temperature,Q.Precipitation,Q.Humidity,Q.Wind_speed from Weather_Inputs Q INNER JOIN Favorite b on Q.Input_ID = b.Input_ID where b.username='" + Session["Username"] + "'";

            connection.Open();
            cmd = new SqlCommand(Querry, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adapter.Fill(set);
            GdV_Data.DataSource = set;
            GdV_Data.DataBind();

            connection.Close();
        }

        protected void btn_Selected_Click(object sender, EventArgs e)
        {
            try
            {

                //this method is getting the selected cities
                getSelecteFavoriteCities();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Oups......Something went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        string data;

        //this method is getting the selected cities
        private void getSelecteFavoriteCities()
        {
            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);

            foreach (ListItem item in ListBox_favorite.Items)

            {
                string query;
                connection.Open();
                if (item.Selected == true)
                {
                    //this query is joining two tables
                    query = "select b.City,Q.Date,Q.Minimum_Temperature,Q.Maximum_Temperature,Q.Precipitation,Q.Humidity,Q.Wind_speed from Weather_Inputs Q INNER JOIN Favorite b on Q.Input_ID = b.Input_ID Where b.city ='" + item.Text + "'";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        data += reader["City"].ToString() + "  \t" + reader["Minimum_Temperature"] + "     \t" + reader["Maximum_Temperature"] + "       \t" + reader["Precipitation"] + "\t    " + reader["Humidity"] + "   \t" + reader["Wind_speed"] + "   \t" + reader["Date"].ToString() + "\n";


                    }
                    txtA_Report.Value += data;
                }
                connection.Close();
            }
        }

        string dataholder;
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Setting);
            SqlDataReader reader;
            try
            {

                string Query = "Select* from [Weather_Inputs]";
                connection.Open();
                cmd = new SqlCommand(Query, connection);
                reader = cmd.ExecuteReader();
                foreach (ListItem item in ddl_Cities.Items)

                {

                    if (item.Selected == true)
                    {
                        string selected = item.Text;
                        while (reader.Read())
                        {
                            if (selected == reader["City"].ToString())
                            {
                                if (C_Start.SelectedDate <= Convert.ToDateTime(reader["Date"]) && C_End.SelectedDate >= Convert.ToDateTime(reader["Date"]))
                                {
                                    dataholder += reader["City"].ToString() + "  \t" + reader["Minimum_Temperature"] + "     \t" + reader["Maximum_Temperature"] + "       \t" + reader["Precipitation"] + "\t    " + reader["Humidity"] + "   \t" + reader["Wind_speed"] + "   \t" + reader["Date"].ToString() + "\n";



                                }
                                txtA_Report.Value += dataholder;
                            }

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

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}