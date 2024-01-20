
namespace host_manager
{
    partial class acceuil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hostDataSet = new host_manager.hostDataSet();
            this.signout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.room_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tricklbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roomstatus_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostDataSet
            // 
            this.hostDataSet.DataSetName = "hostDataSet";
            this.hostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // signout
            // 
            this.signout.BackColor = System.Drawing.Color.SteelBlue;
            this.signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout.ForeColor = System.Drawing.Color.White;
            this.signout.Location = new System.Drawing.Point(636, 53);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(136, 31);
            this.signout.TabIndex = 31;
            this.signout.Text = "Deconnecter";
            this.signout.UseVisualStyleBackColor = false;
            this.signout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.signout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 138);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(80, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Customer Information";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "voulez vous :";
            // 
            // room_btn
            // 
            this.room_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_btn.ForeColor = System.Drawing.Color.White;
            this.room_btn.Location = new System.Drawing.Point(435, 212);
            this.room_btn.Name = "room_btn";
            this.room_btn.Size = new System.Drawing.Size(119, 29);
            this.room_btn.TabIndex = 27;
            this.room_btn.Text = "Select";
            this.room_btn.UseVisualStyleBackColor = false;
            this.room_btn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.Color.White;
            this.customer_btn.Location = new System.Drawing.Point(435, 282);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(119, 29);
            this.customer_btn.TabIndex = 28;
            this.customer_btn.Text = "Select";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(80, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Room reservation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tricklbl
            // 
            this.tricklbl.AutoSize = true;
            this.tricklbl.BackColor = System.Drawing.Color.White;
            this.tricklbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tricklbl.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.tricklbl.Location = new System.Drawing.Point(31, 483);
            this.tricklbl.Name = "tricklbl";
            this.tricklbl.Size = new System.Drawing.Size(0, 25);
            this.tricklbl.TabIndex = 20;
            this.tricklbl.Click += new System.EventHandler(this.tricklbl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(80, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Room Status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // roomstatus_btn
            // 
            this.roomstatus_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.roomstatus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomstatus_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomstatus_btn.ForeColor = System.Drawing.Color.White;
            this.roomstatus_btn.Location = new System.Drawing.Point(435, 357);
            this.roomstatus_btn.Name = "roomstatus_btn";
            this.roomstatus_btn.Size = new System.Drawing.Size(119, 29);
            this.roomstatus_btn.TabIndex = 30;
            this.roomstatus_btn.Text = "Select";
            this.roomstatus_btn.UseVisualStyleBackColor = false;
            this.roomstatus_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomstatus_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tricklbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.room_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "acceuil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hostDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private hostDataSet hostDataSet;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button room_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tricklbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button roomstatus_btn;
    }
}