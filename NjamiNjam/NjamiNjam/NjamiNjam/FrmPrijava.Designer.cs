namespace NjamiNjam
{
    partial class FrmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijava));
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.checkBoxLozinka = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(89, 98);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(226, 22);
            this.tbKorisnickoIme.TabIndex = 1;
            this.tbKorisnickoIme.TextChanged += new System.EventHandler(this.tbKorisnickoIme_TextChanged);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(89, 162);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(226, 22);
            this.tbLozinka.TabIndex = 2;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrijava.Location = new System.Drawing.Point(89, 216);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(110, 38);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOdustani.Location = new System.Drawing.Point(211, 216);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(104, 38);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Izlaz";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelKorisnickoIme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(150, 69);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.labelKorisnickoIme.TabIndex = 7;
            this.labelKorisnickoIme.Text = "Korisničko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelLozinka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLozinka.Location = new System.Drawing.Point(166, 142);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(57, 17);
            this.labelLozinka.TabIndex = 8;
            this.labelLozinka.Text = "Lozinka";
            // 
            // checkBoxLozinka
            // 
            this.checkBoxLozinka.AutoSize = true;
            this.checkBoxLozinka.Location = new System.Drawing.Point(141, 190);
            this.checkBoxLozinka.Name = "checkBoxLozinka";
            this.checkBoxLozinka.Size = new System.Drawing.Size(120, 21);
            this.checkBoxLozinka.TabIndex = 9;
            this.checkBoxLozinka.Text = "Prikaži lozinku";
            this.checkBoxLozinka.UseVisualStyleBackColor = true;
            this.checkBoxLozinka.CheckedChanged += new System.EventHandler(this.checkBoxLozinka_CheckedChanged);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NjamiNjam.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(419, 532);
            this.Controls.Add(this.checkBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.CheckBox checkBoxLozinka;
    }
}

