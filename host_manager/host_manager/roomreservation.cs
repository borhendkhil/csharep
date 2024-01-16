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
    public partial class roomreservation : Form
    {
        public roomreservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            reservationmanagement reservationmanagementForm = new reservationmanagement();
            reservationmanagementForm.Show();
            this.Hide();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            reservearoom reservearoomForm = new reservearoom();
            reservearoomForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil acceuilForm = new acceuil();
            acceuilForm.Show();
            this.Hide();

        }
    }
}
