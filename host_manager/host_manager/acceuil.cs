using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host_manager
{
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegisterForm
            roomstatus roomstatusForm = new roomstatus();

            // Show the RegisterForm
            roomstatusForm.Show();

            // Optionally, hide the ReceptionForm if needed
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tricklbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegisterForm
            reservationmanagement reservationmanagementForm = new reservationmanagement();

            // Show the RegisterForm
            reservationmanagementForm.Show();

            // Optionally, hide the ReceptionForm if needed
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the RegisterForm
            custumrinfo custumrinfoForm = new custumrinfo();

            // Show the RegisterForm
            custumrinfoForm.Show();

            // Optionally, hide the ReceptionForm if needed
            this.Hide();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            
            roomreservation roomreservationForm = new roomreservation();

            
            roomreservationForm.Show();

            
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("deconnecter");
            
            reception receptionForm = new reception();

            
            receptionForm.Show();

            
            this.Hide();



            
        }
    }
}
