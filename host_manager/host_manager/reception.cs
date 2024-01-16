using System;
using System.Windows.Forms;

namespace host_manager
{
    public partial class reception : Form
    {
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
            // Create an instance of the RegisterForm
            acceuil acceuilForm = new acceuil();

            // Show the RegisterForm
            acceuilForm.Show();

            // Optionally, hide the ReceptionForm if needed
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
