namespace wfaMUSIK
{
    partial class AjoutezCours
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
            this.textBoxCours1 = new System.Windows.Forms.TextBox();
            this.textBoxCours2 = new System.Windows.Forms.TextBox();
            this.textBoxCours4 = new System.Windows.Forms.TextBox();
            this.textBoxCours3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du cours";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ajoutezInstrument
            // 
            this.ajoutezInstrument.Location = new System.Drawing.Point(190, 300);
            this.ajoutezInstrument.Name = "ajoutezInstrument";
            this.ajoutezInstrument.Size = new System.Drawing.Size(240, 56);
            this.ajoutezInstrument.TabIndex = 1;
            this.ajoutezInstrument.Text = "ajoutez un cours";
            this.ajoutezInstrument.UseVisualStyleBackColor = true;
            this.ajoutezInstrument.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCours1
            // 
            this.textBoxCours1.Location = new System.Drawing.Point(112, 36);
            this.textBoxCours1.Name = "textBoxCours1";
            this.textBoxCours1.Size = new System.Drawing.Size(151, 20);
            this.textBoxCours1.TabIndex = 2;
            // 
            // textBoxCours2
            // 
            this.textBoxCours2.Location = new System.Drawing.Point(108, 72);
            this.textBoxCours2.Name = "textBoxCours2";
            this.textBoxCours2.Size = new System.Drawing.Size(151, 20);
            this.textBoxCours2.TabIndex = 3;
            this.textBoxCours2.TextChanged += new System.EventHandler(this.textBoxCours2_TextChanged);
            // 
            // textBoxCours4
            // 
            this.textBoxCours4.Location = new System.Drawing.Point(127, 138);
            this.textBoxCours4.Name = "textBoxCours4";
            this.textBoxCours4.Size = new System.Drawing.Size(151, 20);
            this.textBoxCours4.TabIndex = 4;
            this.textBoxCours4.TextChanged += new System.EventHandler(this.textBoxCours4_TextChanged);
            // 
            // textBoxCours3
            // 
            this.textBoxCours3.Location = new System.Drawing.Point(112, 107);
            this.textBoxCours3.Name = "textBoxCours3";
            this.textBoxCours3.Size = new System.Drawing.Size(151, 20);
            this.textBoxCours3.TabIndex = 5;
            this.textBoxCours3.TextChanged += new System.EventHandler(this.textBoxCours3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age minimum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age Maximum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de place";
            // 
            // AjoutezCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCours3);
            this.Controls.Add(this.textBoxCours4);
            this.Controls.Add(this.textBoxCours2);
            this.Controls.Add(this.textBoxCours1);
            this.Controls.Add(this.ajoutezInstrument);
            this.Controls.Add(this.label1);
            this.Name = "AjoutezCours";
            this.Text = "AjoutezCours";
            this.Load += new System.EventHandler(this.AjoutezCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajoutezInstrument;
        private System.Windows.Forms.TextBox textBoxCours1;
        private System.Windows.Forms.TextBox textBoxCours2;
        private System.Windows.Forms.TextBox textBoxCours4;
        private System.Windows.Forms.TextBox textBoxCours3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}