﻿namespace wfaMUSIK
{
    partial class AjoutInstrument
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
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutezInstrument = new System.Windows.Forms.Button();
            this.textBoxInstru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'instrument";
            // 
            // ajoutezInstrument
            // 
            this.ajoutezInstrument.Location = new System.Drawing.Point(29, 163);
            this.ajoutezInstrument.Name = "ajoutezInstrument";
            this.ajoutezInstrument.Size = new System.Drawing.Size(241, 61);
            this.ajoutezInstrument.TabIndex = 1;
            this.ajoutezInstrument.Text = "Ajoutez un Instrument";
            this.ajoutezInstrument.UseVisualStyleBackColor = true;
            this.ajoutezInstrument.Click += new System.EventHandler(this.ajoutezInstrument_Click);
            // 
            // textBoxInstru
            // 
            this.textBoxInstru.Location = new System.Drawing.Point(117, 45);
            this.textBoxInstru.Name = "textBoxInstru";
            this.textBoxInstru.Size = new System.Drawing.Size(158, 20);
            this.textBoxInstru.TabIndex = 2;
            // 
            // AjoutInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxInstru);
            this.Controls.Add(this.ajoutezInstrument);
            this.Controls.Add(this.label1);
            this.Name = "AjoutInstrument";
            this.Text = "AjoutInstrument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajoutezInstrument;
        private System.Windows.Forms.TextBox textBoxInstru;
    }
}