using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quizzz
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-0BNMRNL\\SQLEXPRESS;Initial Catalog=QuizApp;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        // Replace with your SQL connection string

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a connection to the SQL database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the user exists in the database
                    string selectQuery = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Passwd = '{password}'";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            txtUsername.Text = string.Empty;
                            txtPassword.Text = string.Empty;

                            // Perform login authentication
                            bool isAuthenticated = true;

                            if (isAuthenticated)
                            {



                                // Open the dashboard form
                                DashboardForm dashboardForm = new DashboardForm();
                                dashboardForm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during login: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid username and password.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a connection to the SQL database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the username already exists in the database
                    string selectQuery = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}'";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert the new user into the database
                    string selectMaxIdQuery = "SELECT MAX(UserID) FROM Users";

                    using (connection)
                    {
                        using (SqlCommand command = new SqlCommand(selectMaxIdQuery, connection))
                        {

                            int maxId = command.ExecuteScalar() as int? ?? 0;
                            int newUserId = maxId + 1;

                            string insertQuery = "INSERT INTO Users (UserId, Username, Passwd) VALUES (@userId, @username, @password)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userId", newUserId);
                                insertCommand.Parameters.AddWithValue("@username", username);
                                insertCommand.Parameters.AddWithValue("@password", password);

                                insertCommand.ExecuteNonQuery();
                                connection.Close();
                            }

                            MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the input fields
                            txtUsername.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during registration: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
