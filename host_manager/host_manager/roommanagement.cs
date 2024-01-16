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
        public roommanagement()
        {
            InitializeComponent();
        }

        private void roommanagement_Load(object sender, EventArgs e)
        {

        
            // Check the condition (e.g., if 1 == 1)
            if (1 == 1)
            {
                // If the condition is true, add a button to the form
                Button dynamicButton = new Button();
                dynamicButton.Text = "Dynamic Button";
                dynamicButton.Location = new System.Drawing.Point(50, 50); // Set the button's location
                dynamicButton.Click += new System.EventHandler(this.dynamicButton_Click); // Set the button's click event handler
                this.Controls.Add(dynamicButton); // Add the button to the form
            }
        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {
            // Handle the click event of the dynamically added button
            MessageBox.Show("Dynamic Button Clicked!");
        }
    }
}

