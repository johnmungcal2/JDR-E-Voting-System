using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Add this static variable to store the logged-in voter ID
        public static int loggedInVoterID = 0;

        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mysqlConnection.Open();
                MessageBox.Show("Successfully connected to MySQL database.");
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string password = passwordTextBox.Text;

            // Check if any field is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mysqlConnection.Open();
                string query = "SELECT voterID FROM voters WHERE fname = @fname AND lname = @lname AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                cmd.Parameters.AddWithValue("@fname", firstName);
                cmd.Parameters.AddWithValue("@lname", lastName);
                cmd.Parameters.AddWithValue("@password", password);

                // Execute query and get the voter ID if the user exists
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Store the voter ID in the static variable
                    loggedInVoterID = Convert.ToInt32(result);

                    MessageBox.Show("Login Successful!");

                    // Hide Form1 and show Form3 after successful login
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials. Please try again.");
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
