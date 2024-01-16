
namespace host_manager
{
    partial class roomreservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_btn = new System.Windows.Forms.Button();
            this.room_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 100);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room Reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(60, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "Reserve a room";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.Color.White;
            this.customer_btn.Location = new System.Drawing.Point(413, 280);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(119, 29);
            this.customer_btn.TabIndex = 46;
            this.customer_btn.Text = "Select";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // room_btn
            // 
            this.room_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_btn.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_btn.ForeColor = System.Drawing.Color.White;
            this.room_btn.Location = new System.Drawing.Point(413, 224);
            this.room_btn.Name = "room_btn";
            this.room_btn.Size = new System.Drawing.Size(119, 29);
            this.room_btn.TabIndex = 45;
            this.room_btn.Text = "Select";
            this.room_btn.UseVisualStyleBackColor = false;
            this.room_btn.Click += new System.EventHandler(this.room_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(60, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Room management";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(581, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roomreservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.room_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "roomreservation";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button room_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}