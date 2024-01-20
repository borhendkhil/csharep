using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host_manager
{
    public partial class register : Form
    {
        private const string connectionString = "Data Source=BORHEN;Initial Catalog=host;Integrated Security=True;Encrypt=False";
        public register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string firstName = nom_btn.Text;
            string lastName = prenom_btn.Text;
            string phoneNumber = telephone.Text;
            string username = identifiant.Text;
            string password = mdp_btn.Text;
            
            if (RegisterUser(firstName, lastName, phoneNumber, username, password))
            {
                MessageBox.Show("Registration successful!");
                
            }
            else
            {

                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private bool RegisterUser(string firstName, string lastName, string phoneNumber, string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Users (Nom, Prenom, Telephone, UserName, Password) " +
                                   "VALUES (@Nom, @Prenom, @Telephone, @UserName, @Password); " +
                                   "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nom", firstName);
                        command.Parameters.AddWithValue("@Prenom", lastName);
                        command.Parameters.AddWithValue("@Telephone", phoneNumber);
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int userID = Convert.ToInt32(command.ExecuteScalar());

                        return userID > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}");
                return false;
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            reception receptionFrom = new reception();
            receptionFrom.Show();
            this.Hide();
        }
    }
}
    
