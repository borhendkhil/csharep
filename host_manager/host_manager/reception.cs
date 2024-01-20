using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace host_manager
{
    public partial class reception : Form
    {
        private const string connectionString = "Data Source=BORHEN;Initial Catalog=host;Integrated Security=True;Encrypt=False";
        public reception()
        {
            InitializeComponent();
        }

        private void reception_Load(object sender, EventArgs e)
        {

        }


        private void registerr_btn_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegisterForm
            register registerForm = new register();

            // Show the RegisterForm
            registerForm.Show();

            // Optionally, hide the ReceptionForm if needed
            this.Hide();
        }
        private void login_btn_Click(object sender, EventArgs e)

        {
            string username = textBox1.Text;
            string password = passwordbox.Text;
        

            if (AuthenticateUser(username, password))
            {
                // If authentication is successful, navigate to the next interface
                MessageBox.Show("Login successful!");
                // Add code here to navigate to the next interface
                // Create an instance of the RegisterForm
                acceuil acceuilForm = new acceuil();

                // Show the RegisterForm
                acceuilForm.Show();

                // Optionally, hide the ReceptionForm if needed
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT count(*) FROM [Users]  WHERE   [Password] = @Password ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            
                            int count = (int)command.ExecuteScalar();
                            
                            return count > 0;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"An error occurred during authentication: {ex.Message}");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during authentication: {ex.Message}");
                return false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
