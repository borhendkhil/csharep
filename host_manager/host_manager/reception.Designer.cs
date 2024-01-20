
namespace host_manager
{
    partial class reception
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reception));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.registerr_btn = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerr_btn
            // 
            this.registerr_btn.BackColor = System.Drawing.Color.White;
            this.registerr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerr_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerr_btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.registerr_btn.Location = new System.Drawing.Point(470, 349);
            this.registerr_btn.Name = "registerr_btn";
            this.registerr_btn.Size = new System.Drawing.Size(130, 29);
            this.registerr_btn.TabIndex = 22;
            this.registerr_btn.Text = "Espace admin";
            this.registerr_btn.UseVisualStyleBackColor = false;
            this.registerr_btn.Click += new System.EventHandler(this.registerr_btn_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passwordbox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.passwordbox.Location = new System.Drawing.Point(76, 8);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(297, 27);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.UseSystemPasswordChar = true;
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, -10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.passwordbox);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(281, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 37);
            this.panel5.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.Location = new System.Drawing.Point(76, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(281, 227);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 37);
            this.panel6.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(314, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Connectez-vous à votre compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "dans ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host Management";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(318, 349);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(124, 29);
            this.login_btn.TabIndex = 23;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(3, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 538);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 516);
            this.Controls.Add(this.registerr_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel1);
            this.Name = "reception";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.reception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button registerr_btn;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel panel1;
    }
}

