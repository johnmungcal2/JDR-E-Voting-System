using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int voterID = Form1.loggedInVoterID;  // Access the logged-in voter ID from Form1

            if (voterID > 0)
            {
                // Database connection string
                string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
                MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);

                try
                {
                    mysqlConnection.Open();

                    // Query to fetch the user's details using the voterID
                    string query = "SELECT fname, lname, age, sex, address, password FROM voters WHERE voterID = @voterID";
                    MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                    cmd.Parameters.AddWithValue("@voterID", voterID);

                    // Execute the query and read the data
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Retrieve user's details
                        string firstName = reader["fname"].ToString();
                        string lastName = reader["lname"].ToString();
                        string age = reader["age"].ToString();
                        string sex = reader["sex"].ToString();
                        string address = reader["address"].ToString();
                        string password = reader["password"].ToString();

                        // Update labels with user's details

                        firstNameLabel.Text = firstName;
                        lastNameLabel.Text = lastName;
                        welcomeLabel.Text = firstName;
                        ageLabel.Text = age;
                        sexLabel.Text = sex;
                        addressLabel.Text = address;
                        passwordLabel.Text = password;
                    }
                    else
                    {
                        MessageBox.Show("User details not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mysqlConnection.Close();
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            // You can add functionality to edit profile here if needed
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
