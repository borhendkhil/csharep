
namespace host_manager
{
    partial class custumrinfo
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
            this.iDappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINappelantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleappelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // iDappelantDataGridViewTextBoxColumn
            // 
            this.iDappelantDataGridViewTextBoxColumn.DataPropertyName = "ID_appelant";
            this.iDappelantDataGridViewTextBoxColumn.HeaderText = "ID_appelant";
            this.iDappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDappelantDataGridViewTextBoxColumn.Name = "iDappelantDataGridViewTextBoxColumn";
            this.iDappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDappelantDataGridViewTextBoxColumn.Width = 131;
            // 
            // nomappelantDataGridViewTextBoxColumn
            // 
            this.nomappelantDataGridViewTextBoxColumn.DataPropertyName = "Nom_appelant";
            this.nomappelantDataGridViewTextBoxColumn.HeaderText = "Nom_appelant";
            this.nomappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nomappelantDataGridViewTextBoxColumn.Name = "nomappelantDataGridViewTextBoxColumn";
            this.nomappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nomappelantDataGridViewTextBoxColumn.Width = 154;
            // 
            // telephoneappelantDataGridViewTextBoxColumn
            // 
            this.telephoneappelantDataGridViewTextBoxColumn.DataPropertyName = "Telephone_appelant";
            this.telephoneappelantDataGridViewTextBoxColumn.HeaderText = "Telephone_appelant";
            this.telephoneappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.telephoneappelantDataGridViewTextBoxColumn.Name = "telephoneappelantDataGridViewTextBoxColumn";
            this.telephoneappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.telephoneappelantDataGridViewTextBoxColumn.Width = 198;
            // 
            // cINappelantDataGridViewTextBoxColumn
            // 
            this.cINappelantDataGridViewTextBoxColumn.DataPropertyName = "CIN_appelant";
            this.cINappelantDataGridViewTextBoxColumn.HeaderText = "CIN_appelant";
            this.cINappelantDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cINappelantDataGridViewTextBoxColumn.Name = "cINappelantDataGridViewTextBoxColumn";
            this.cINappelantDataGridViewTextBoxColumn.ReadOnly = true;
            this.cINappelantDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cINappelantDataGridViewTextBoxColumn.Width = 145;
            // 
            // cleappelDataGridViewTextBoxColumn
            // 
            this.cleappelDataGridViewTextBoxColumn.DataPropertyName = "cleappel";
            this.cleappelDataGridViewTextBoxColumn.HeaderText = "cleappel";
            this.cleappelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cleappelDataGridViewTextBoxColumn.Name = "cleappelDataGridViewTextBoxColumn";
            this.cleappelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleappelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cleappelDataGridViewTextBoxColumn.Width = 106;
            // 
            // custumrinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "custumrinfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.custumrinfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINappelantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleappelDataGridViewTextBoxColumn;
    }
}