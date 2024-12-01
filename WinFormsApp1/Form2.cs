using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mysqlConnection.Open();
                //MessageBox.Show("Successfully connected to MySQL database.");
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

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int age;
            bool isAgeValid = int.TryParse(ageTextBox.Text, out age);
            string address = addressTextBox.Text;
            string password = passwordTextBox.Text;
            string gender = maleRadioButton.Checked ? "Male" : femaleRadioButton.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || !isAgeValid || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string mysqlCon = "server=127.0.0.1; user=root; database=jdr; password=";
            MySqlConnection mysqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mysqlConnection.Open();
                string query = "INSERT INTO voters (fname, lname, age, sex, address, password) VALUES (@fname, @lname, @age, @sex, @address, @password)";
                MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
                cmd.Parameters.AddWithValue("@fname", firstName);
                cmd.Parameters.AddWithValue("@lname", lastName);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@password", password);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Signup Successful!");

                    // Hide Form2 and show Form1 after successful signup
                    this.Hide(); // Hide current form (Form2)
                    Form1 form1 = new Form1();
                    form1.Show(); // Show Form1 for login
                }
                else
                {
                    MessageBox.Show("Signup Failed. Try again.");
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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
