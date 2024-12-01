using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private int selectedCandidateID = 0; // To store the selected candidate's ID

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Connection string to MySQL
            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                // Open the connection
                mysqlConnection.Open();

                // Query to get the first two candidates' names
                string query = "SELECT candidateID, fname FROM candidates LIMIT 2";
                MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Read the first two candidates and set their names to the radio buttons
                if (reader.Read())
                {
                    candidate1RadioButton.Text = reader["fname"].ToString(); // Set candidate 1's name
                }

                if (reader.Read())
                {
                    candidate2RadioButton.Text = reader["fname"].ToString(); // Set candidate 2's name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mysqlConnection.Close();
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void candidate1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (candidate1RadioButton.Checked)
            {
                selectedCandidateID = 1; // Store the ID of candidate 1
            }
        }

        private void candidate2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (candidate2RadioButton.Checked)
            {
                selectedCandidateID = 2; // Store the ID of candidate 2
            }
        }

        private void submitVoteButton_Click(object sender, EventArgs e)
        {
            if (selectedCandidateID == 0)
            {
                MessageBox.Show("Please select a candidate before submitting your vote.");
                return;
            }

            // Call the function to update the vote count for the selected candidate
            UpdateVoteCount(selectedCandidateID);
        }

        private void UpdateVoteCount(int candidateID)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mysqlConnection.Open();
                string query = "UPDATE candidates SET voteCount = voteCount + 1 WHERE candidateID = @candidateID";
                MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                cmd.Parameters.AddWithValue("@candidateID", candidateID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Vote successfully cast!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mysqlConnection.Close();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
