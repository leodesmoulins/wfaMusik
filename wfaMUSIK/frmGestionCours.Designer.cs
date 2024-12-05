namespace wfaMUSIK
{
    partial class frmGestionCours
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
            this.dvgCours = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCours)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCours
            // 
            this.dvgCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCours.Location = new System.Drawing.Point(98, 48);
            this.dvgCours.Name = "dvgCours";
            this.dvgCours.Size = new System.Drawing.Size(419, 206);
            this.dvgCours.TabIndex = 0;
            this.dvgCours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmGestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 381);
            this.Controls.Add(this.dvgCours);
            this.Name = "frmGestionCours";
            this.Text = "frmGestionCours";
            this.Load += new System.EventHandler(this.frmGestionCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCours;
    }
}