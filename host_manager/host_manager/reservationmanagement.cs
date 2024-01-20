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
    public partial class reservationmanagement : Form
    {
        private const string connectionString = "Data Source=BORHEN;Initial Catalog=host;Integrated Security=True;Encrypt=False";
        public reservationmanagement()
        {
            InitializeComponent();
        }

        private void reservationmanagement_Load(object sender, EventArgs e)
        {
           

        }

        private void recherche_Click(object sender, EventArgs e)
        {
            string cinToSearch = rechinput.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the client record from the database
                    string selectClientQuery = "SELECT * FROM client WHERE cin = @cin";
                    using (SqlCommand command = new SqlCommand(selectClientQuery, connection))
                    {
                        command.Parameters.AddWithValue("@cin", cinToSearch);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate the textboxes with the retrieved data
                            nombtn.Text = reader["nom"].ToString();
                            prenombtn.Text = reader["prenom"].ToString();
                            roombtn.Text = reader["chambrenum"].ToString();
                            agebtn.Text = reader["age"].ToString();
                            cinbtn.Text = reader["cin"].ToString();
                             date.Text = reader["date"].ToString();
                             datafin.Text = reader["datefin"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Client not found.");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            
                // Retrieve values from textboxes
                string date = this.date.Text;
                string datefin = this.datafin.Text;
                string nom = nombtn.Text.Trim();
                string prenom = prenombtn.Text.Trim();
                string chambrenum = roombtn.Text.Trim();
                string age = agebtn.Text.Trim();
                string cin = cinbtn.Text.Trim();

                // Validate that required fields are not empty
                if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(chambrenum) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(cin))
                {
                    MessageBox.Show("Please fill in all the fields before saving.");
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Update the client record in the database
                        string updateClientQuery = "UPDATE client SET nom = @nom, prenom = @prenom, chambrenum = @chambrenum, age = @age, date = @date, datefin = @datefin WHERE cin = @cin";
                        using (SqlCommand command = new SqlCommand(updateClientQuery, connection))
                        {
                            command.Parameters.AddWithValue("@nom", nom);
                            command.Parameters.AddWithValue("@prenom", prenom);
                            command.Parameters.AddWithValue("@chambrenum", chambrenum);
                            command.Parameters.AddWithValue("@age", age);
                            command.Parameters.AddWithValue("@cin", cin);
                            command.Parameters.AddWithValue("@date", date);
                            command.Parameters.AddWithValue("@datefin", datefin);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Client information updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Client not found. No changes were made.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            

        }

        private void suppbtn_Click(object sender, EventArgs e)
        {
            // Retrieve CIN from the textbox
            string cinToDelete = cinbtn.Text.Trim();

            // Validate that CIN is not empty
            if (string.IsNullOrEmpty(cinToDelete))
            {
                MessageBox.Show("Please enter a valid CIN before deleting.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the client exists
                    string checkClientQuery = "SELECT COUNT(*) FROM client WHERE cin = @cin";
                    using (SqlCommand command = new SqlCommand(checkClientQuery, connection))
                    {
                        command.Parameters.AddWithValue("@cin", cinToDelete);

                        int existingClientCount = Convert.ToInt32(command.ExecuteScalar());

                        if (existingClientCount > 0)
                        {
                            // Delete client information from the database
                            string deleteClientQuery = "DELETE FROM client WHERE cin = @cin";
                            using (SqlCommand deleteCommand = new SqlCommand(deleteClientQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@cin", cinToDelete);
                                int rowsAffected = deleteCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Client information deleted successfully.");
                                    // Optionally, clear textboxes after deletion
                                    ClearTextboxes();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete client information.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Client not found. No changes were made.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ClearTextboxes()
        {
            // Clear values in textboxes
            nombtn.Clear();
            prenombtn.Clear();
            roombtn.Clear();
            agebtn.Clear();
            cinbtn.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil a=new acceuil();

            a.Show();
            this.Hide();
        }
    }
    }

