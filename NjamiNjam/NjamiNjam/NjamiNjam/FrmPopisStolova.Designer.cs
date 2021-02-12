namespace NjamiNjam
{
    partial class FrmPopisStolova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisStolova));
            this.gumbOdaberi = new System.Windows.Forms.Button();
            this.cmbStol = new System.Windows.Forms.ComboBox();
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumbOdaberi
            // 
            this.gumbOdaberi.BackColor = System.Drawing.Color.Maroon;
            this.gumbOdaberi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbOdaberi.Location = new System.Drawing.Point(16, 76);
            this.gumbOdaberi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gumbOdaberi.Name = "gumbOdaberi";
            this.gumbOdaberi.Size = new System.Drawing.Size(104, 39);
            this.gumbOdaberi.TabIndex = 4;
            this.gumbOdaberi.Text = "Odaberi";
            this.gumbOdaberi.UseVisualStyleBackColor = false;
            this.gumbOdaberi.Click += new System.EventHandler(this.gumbOdaberi_Click);
            // 
            // cmbStol
            // 
            this.cmbStol.FormattingEnabled = true;
            this.cmbStol.Items.AddRange(new object[] {
            "Stol 1",
            "Stol 2",
            "Stol 3",
            "Stol 4",
            "Stol 5",
            "Stol 6",
            "Stol 7",
            "Stol 8",
            "Stol 9",
            "Stol 10",
            "Stol 11",
            "Stol 12",
            "Stol 13",
            "Stol 14",
            "Stol 15",
            "Stol 16",
            "Stol 17",
            "Stol 18",
            "Stol 19",
            "Stol 20"});
            this.cmbStol.Location = new System.Drawing.Point(16, 15);
            this.cmbStol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStol.Name = "cmbStol";
            this.cmbStol.Size = new System.Drawing.Size(271, 24);
            this.cmbStol.TabIndex = 3;
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbIzlaz.Location = new System.Drawing.Point(180, 76);
            this.gumbIzlaz.Margin = new System.Windows.Forms.Padding(4);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(108, 39);
            this.gumbIzlaz.TabIndex = 5;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // FrmPopisStolova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(323, 142);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.gumbOdaberi);
            this.Controls.Add(this.cmbStol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPopisStolova";
            this.Text = "Popis stolova";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPopisStolova_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gumbOdaberi;
        private System.Windows.Forms.ComboBox cmbStol;
        private System.Windows.Forms.Button gumbIzlaz;
    }
}