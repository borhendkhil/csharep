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
    public partial class roomstatus : Form
    {
        private const string connectionString = "Data Source=BORHEN;Initial Catalog=host;Integrated Security=True;Encrypt=False";
        public roomstatus()
        {
            InitializeComponent();
        }

        private void roomstatus_Load(object sender, EventArgs e)
        {

                        
            LoadCounts();
            

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            acceuil acceuilForm = new acceuil();
            acceuilForm.Show();
            this.Hide();
        }
        private void LoadCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Count the total number of rooms
                    string countRoomsQuery = "SELECT COUNT(*) FROM room";
                    using (SqlCommand command = new SqlCommand(countRoomsQuery, connection))
                    {
                        int totalRooms = Convert.ToInt32(command.ExecuteScalar());
                        nbtotal.Text = totalRooms.ToString();
                    }

                    // Count the number of clients
                    string countClientsQuery = "SELECT COUNT(*) FROM client";
                    using (SqlCommand command = new SqlCommand(countClientsQuery, connection))
                    {
                        int totalClients = Convert.ToInt32(command.ExecuteScalar());
                        nbreser.Text = totalClients.ToString();
                    }

                    // Calculate and set nbtransportprimtxt
                    int nbTotalRooms = int.Parse(nbtotal.Text);
                    int nbReservedClients = int.Parse(nbreser.Text);
                    int nbTransportPrim = nbTotalRooms - nbReservedClients;
                    nbtransportprimtxt.Text = nbTransportPrim.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

