namespace wfaMUSIK
{
    partial class frmGestionInstrument
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
            this.dvgInstrument = new System.Windows.Forms.DataGridView();
            this.btnAddInstru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInstrument)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgInstrument
            // 
            this.dvgInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInstrument.Location = new System.Drawing.Point(90, 12);
            this.dvgInstrument.Name = "dvgInstrument";
            this.dvgInstrument.Size = new System.Drawing.Size(426, 201);
            this.dvgInstrument.TabIndex = 1;
            // 
            // btnAddInstru
            // 
            this.btnAddInstru.Location = new System.Drawing.Point(183, 268);
            this.btnAddInstru.Name = "btnAddInstru";
            this.btnAddInstru.Size = new System.Drawing.Size(236, 82);
            this.btnAddInstru.TabIndex = 2;
            this.btnAddInstru.Text = "acceder a ajoute intru";
            this.btnAddInstru.UseVisualStyleBackColor = true;
            this.btnAddInstru.Click += new System.EventHandler(this.btnAddInstru_Click_1);
            // 
            // frmGestionInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 408);
            this.Controls.Add(this.btnAddInstru);
            this.Controls.Add(this.dvgInstrument);
            this.Name = "frmGestionInstrument";
            this.Text = "frmGestionInstrument";
            this.Load += new System.EventHandler(this.frmGestionInstrument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInstrument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgInstrument;
        private System.Windows.Forms.Button btnAddInstru;
    }
}