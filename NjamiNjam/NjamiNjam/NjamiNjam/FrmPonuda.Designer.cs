namespace NjamiNjam
{
    partial class FrmPonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonuda));
            this.btnSpecijalnaPonuda = new System.Windows.Forms.Button();
            this.btnBrziArtikli = new System.Windows.Forms.Button();
            this.btnPice = new System.Windows.Forms.Button();
            this.btnHrana = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpecijalnaPonuda
            // 
            this.btnSpecijalnaPonuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSpecijalnaPonuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpecijalnaPonuda.Location = new System.Drawing.Point(254, 163);
            this.btnSpecijalnaPonuda.Name = "btnSpecijalnaPonuda";
            this.btnSpecijalnaPonuda.Size = new System.Drawing.Size(112, 62);
            this.btnSpecijalnaPonuda.TabIndex = 8;
            this.btnSpecijalnaPonuda.Text = "Specijalna ponuda";
            this.btnSpecijalnaPonuda.UseVisualStyleBackColor = false;
            this.btnSpecijalnaPonuda.Click += new System.EventHandler(this.btnSpecijalnaPonuda_Click);
            // 
            // btnBrziArtikli
            // 
            this.btnBrziArtikli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrziArtikli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrziArtikli.Location = new System.Drawing.Point(69, 163);
            this.btnBrziArtikli.Name = "btnBrziArtikli";
            this.btnBrziArtikli.Size = new System.Drawing.Size(112, 62);
            this.btnBrziArtikli.TabIndex = 7;
            this.btnBrziArtikli.Text = "Brzi Artikli";
            this.btnBrziArtikli.UseVisualStyleBackColor = false;
            this.btnBrziArtikli.Click += new System.EventHandler(this.btnBrziArtikli_Click);
            // 
            // btnPice
            // 
            this.btnPice.BackColor = System.Drawing.Color.Brown;
            this.btnPice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPice.Location = new System.Drawing.Point(254, 50);
            this.btnPice.Name = "btnPice";
            this.btnPice.Size = new System.Drawing.Size(112, 62);
            this.btnPice.TabIndex = 6;
            this.btnPice.Text = "Piće";
            this.btnPice.UseVisualStyleBackColor = false;
            this.btnPice.Click += new System.EventHandler(this.btnPice_Click);
            // 
            // btnHrana
            // 
            this.btnHrana.BackColor = System.Drawing.Color.Maroon;
            this.btnHrana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHrana.Location = new System.Drawing.Point(69, 50);
            this.btnHrana.Name = "btnHrana";
            this.btnHrana.Size = new System.Drawing.Size(112, 62);
            this.btnHrana.TabIndex = 5;
            this.btnHrana.Text = "Hrana";
            this.btnHrana.UseVisualStyleBackColor = false;
            this.btnHrana.Click += new System.EventHandler(this.btnHrana_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzlaz.Location = new System.Drawing.Point(-3, -2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(57, 32);
            this.btnIzlaz.TabIndex = 9;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(423, 268);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnSpecijalnaPonuda);
            this.Controls.Add(this.btnBrziArtikli);
            this.Controls.Add(this.btnPice);
            this.Controls.Add(this.btnHrana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPonuda";
            this.Text = "Ponuda";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPonuda_HelpRequested);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpecijalnaPonuda;
        private System.Windows.Forms.Button btnBrziArtikli;
        private System.Windows.Forms.Button btnPice;
        private System.Windows.Forms.Button btnHrana;
        private System.Windows.Forms.Button btnIzlaz;
    }
}