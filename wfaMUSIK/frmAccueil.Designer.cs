namespace wfaMUSIK
{
    partial class frmAccueil
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
            this.boutonInstrument = new System.Windows.Forms.Button();
            this.dvgCoursCollectif = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgCoursIndividuel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCoursCollectif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCoursIndividuel)).BeginInit();
            this.SuspendLayout();
            // 
            // boutonInstrument
            // 
            this.boutonInstrument.Location = new System.Drawing.Point(59, 305);
            this.boutonInstrument.Name = "boutonInstrument";
            this.boutonInstrument.Size = new System.Drawing.Size(189, 89);
            this.boutonInstrument.TabIndex = 0;
            this.boutonInstrument.Text = "Instrument";
            this.boutonInstrument.UseVisualStyleBackColor = true;
            this.boutonInstrument.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgCoursCollectif
            // 
            this.dvgCoursCollectif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCoursCollectif.Location = new System.Drawing.Point(44, 39);
            this.dvgCoursCollectif.Name = "dvgCoursCollectif";
            this.dvgCoursCollectif.Size = new System.Drawing.Size(204, 184);
            this.dvgCoursCollectif.TabIndex = 1;
            this.dvgCoursCollectif.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dvgCoursIndividuel
            // 
            this.dvgCoursIndividuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCoursIndividuel.Location = new System.Drawing.Point(293, 49);
            this.dvgCoursIndividuel.Name = "dvgCoursIndividuel";
            this.dvgCoursIndividuel.Size = new System.Drawing.Size(213, 173);
            this.dvgCoursIndividuel.TabIndex = 3;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 440);
            this.Controls.Add(this.dvgCoursIndividuel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvgCoursCollectif);
            this.Controls.Add(this.boutonInstrument);
            this.Name = "frmAccueil";
            this.Text = "frmAccueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCoursCollectif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCoursIndividuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boutonInstrument;
        private System.Windows.Forms.DataGridView dvgCoursCollectif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgCoursIndividuel;
    }
}