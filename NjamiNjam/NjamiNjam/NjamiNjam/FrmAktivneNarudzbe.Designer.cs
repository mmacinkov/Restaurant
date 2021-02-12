namespace NjamiNjam
{
    partial class FrmAktivneNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAktivneNarudzbe));
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.lblStol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IspisRacuna = new System.Windows.Forms.Button();
            this.gumbDodavanjeRacuna = new System.Windows.Forms.Button();
            this.gumbPregled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gumbIzlaz.Location = new System.Drawing.Point(426, 62);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(84, 32);
            this.gumbIzlaz.TabIndex = 11;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // lblStol
            // 
            this.lblStol.AutoSize = true;
            this.lblStol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStol.Location = new System.Drawing.Point(119, 9);
            this.lblStol.Name = "lblStol";
            this.lblStol.Size = new System.Drawing.Size(33, 16);
            this.lblStol.TabIndex = 10;
            this.lblStol.Text = "stol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odabrani stol:";
            // 
            // IspisRacuna
            // 
            this.IspisRacuna.BackColor = System.Drawing.Color.Brown;
            this.IspisRacuna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IspisRacuna.Location = new System.Drawing.Point(309, 62);
            this.IspisRacuna.Name = "IspisRacuna";
            this.IspisRacuna.Size = new System.Drawing.Size(92, 32);
            this.IspisRacuna.TabIndex = 8;
            this.IspisRacuna.Text = "Ispis računa";
            this.IspisRacuna.UseVisualStyleBackColor = false;
            this.IspisRacuna.Click += new System.EventHandler(this.IspisRacuna_Click);
            // 
            // gumbDodavanjeRacuna
            // 
            this.gumbDodavanjeRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbDodavanjeRacuna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbDodavanjeRacuna.Location = new System.Drawing.Point(122, 62);
            this.gumbDodavanjeRacuna.Name = "gumbDodavanjeRacuna";
            this.gumbDodavanjeRacuna.Size = new System.Drawing.Size(160, 32);
            this.gumbDodavanjeRacuna.TabIndex = 7;
            this.gumbDodavanjeRacuna.Text = "Dodavanje računa";
            this.gumbDodavanjeRacuna.UseVisualStyleBackColor = false;
            this.gumbDodavanjeRacuna.Click += new System.EventHandler(this.gumbDodavanjeRacuna_Click);
            // 
            // gumbPregled
            // 
            this.gumbPregled.BackColor = System.Drawing.Color.Maroon;
            this.gumbPregled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbPregled.Location = new System.Drawing.Point(15, 62);
            this.gumbPregled.Name = "gumbPregled";
            this.gumbPregled.Size = new System.Drawing.Size(89, 32);
            this.gumbPregled.TabIndex = 6;
            this.gumbPregled.Text = "Pregled";
            this.gumbPregled.UseVisualStyleBackColor = false;
            this.gumbPregled.Click += new System.EventHandler(this.gumbPregled_Click);
            // 
            // FrmAktivneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(531, 105);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.lblStol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IspisRacuna);
            this.Controls.Add(this.gumbDodavanjeRacuna);
            this.Controls.Add(this.gumbPregled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAktivneNarudzbe";
            this.Text = "Aktivne narudžbe";
            this.Load += new System.EventHandler(this.FrmAktivneNarudzbe_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmAktivneNarudzbe_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbIzlaz;
        private System.Windows.Forms.Label lblStol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IspisRacuna;
        private System.Windows.Forms.Button gumbDodavanjeRacuna;
        private System.Windows.Forms.Button gumbPregled;
    }
}