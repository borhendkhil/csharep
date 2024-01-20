using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace host_manager
{
    public partial class reservearoom : Form
    {
        private const string connectionString = "Data Source=BORHEN;Initial Catalog=host;Integrated Security=True;Encrypt=False";

        public reservearoom()
        {
            InitializeComponent();
        }

        private void reservearoom_Load(object sender, EventArgs e)
        {
            // Assuming you have DateTimePicker controls named dateDateTimePicker and datefinDateTimePicker
            date.Value = DateTime.Now.Date;
            datefin.Value = DateTime.Now.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomreservation roomreservationForm = new roomreservation();
            roomreservationForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            roomreservation roomreservationForm = new roomreservation();
            roomreservationForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = this.date.Text;
            string datefin = this.datefin.Text;
            string nom = this.nombtn.Text;
            string prenom = this.prenombtn.Text;
            string room = this.roombtn.Text;

            if (AddRoom(date, datefin, nom, prenom, room))
            {
                MessageBox.Show("Room Reserved");
            }
            else
            {
                MessageBox.Show("Room Not Reserved");
            }
        }

        private bool AddRoom(string date, string datefin, string nom, string prenom, string room)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the room number already exists
                    string checkRoomQuery = "SELECT COUNT(*) FROM client WHERE chambrenum = @chambrenum";
                    using (SqlCommand command = new SqlCommand(checkRoomQuery, connection))
                    {
                        command.Parameters.AddWithValue("@chambrenum", roombtn.Text);
                        int existingRoomCount = Convert.ToInt32(command.ExecuteScalar());

                        if (existingRoomCount > 0)
                        {
                            MessageBox.Show("Room already reserved. Please choose another room number.");
                            return false;
                        }
                    }


                   

                    // Insert into the 'client' table
                    string insertClientQuery = "INSERT INTO client (nom, prenom, cin, age, chambrenum, date, datefin) " +
                                               "VALUES (@nom, @prenom, @CIN, @age, @chambrenum, @date, @datefin)";
                    using (SqlCommand clientCommand = new SqlCommand(insertClientQuery, connection))
                    {
                        // Assuming you get data from the UI
                        clientCommand.Parameters.AddWithValue("@nom", nombtn.Text);
                        clientCommand.Parameters.AddWithValue("@prenom", prenombtn.Text);
                        clientCommand.Parameters.AddWithValue("@CIN", cinbtn.Text);
                        clientCommand.Parameters.AddWithValue("@age", Convert.ToInt32(agebtn.Text));
                        clientCommand.Parameters.AddWithValue("@chambrenum", room);
                        clientCommand.Parameters.AddWithValue("@date", date);
                        clientCommand.Parameters.AddWithValue("@datefin", datefin);
                        clientCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");
                    return true;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

    }
}
