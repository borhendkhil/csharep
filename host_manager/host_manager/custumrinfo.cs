﻿using System;
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
    public partial class custumrinfo : Form
    {
        public custumrinfo()
        {
            InitializeComponent();
        }

        private void custumrinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostDataSet14.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.hostDataSet14.client);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            acceuil acceuilForm = new acceuil();
            acceuilForm.Show();
            this.Hide();
        }
    }
}
