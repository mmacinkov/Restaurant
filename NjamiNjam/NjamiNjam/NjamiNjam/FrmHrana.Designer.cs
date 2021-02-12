namespace NjamiNjam
{
    partial class FrmHrana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHrana));
            this.dgvHrana = new System.Windows.Forms.DataGridView();
            this.cmbTipHrane = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHrana)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHrana
            // 
            this.dgvHrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHrana.Location = new System.Drawing.Point(11, 105);
            this.dgvHrana.Name = "dgvHrana";
            this.dgvHrana.Size = new System.Drawing.Size(462, 177);
            this.dgvHrana.TabIndex = 8;
            // 
            // cmbTipHrane
            // 
            this.cmbTipHrane.FormattingEnabled = true;
            this.cmbTipHrane.Items.AddRange(new object[] {
            "Predjelo",
            "Glavno jelo",
            "Desert"});
            this.cmbTipHrane.Location = new System.Drawing.Point(181, 23);
            this.cmbTipHrane.Name = "cmbTipHrane";
            this.cmbTipHrane.Size = new System.Drawing.Size(121, 21);
            this.cmbTipHrane.TabIndex = 7;
            this.cmbTipHrane.SelectedIndexChanged += new System.EventHandler(this.cmbTipHrane_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberite tip hrane:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDodaj.Location = new System.Drawing.Point(12, 288);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(79, 30);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzmijeni.Location = new System.Drawing.Point(195, 288);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(85, 30);
            this.btnIzmijeni.TabIndex = 12;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(398, 288);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 30);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzlaz.Location = new System.Drawing.Point(-2, -2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(64, 31);
            this.btnIzlaz.TabIndex = 14;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Maroon;
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikazi.Location = new System.Drawing.Point(398, -4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(92, 33);
            this.btnPrikazi.TabIndex = 25;
            this.btnPrikazi.Text = "Prikaži sve";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pretraga:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(374, 78);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtPretraga.TabIndex = 31;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.BackColor = System.Drawing.Color.Brown;
            this.btnSortiraj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSortiraj.Location = new System.Drawing.Point(12, 73);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(79, 26);
            this.btnSortiraj.TabIndex = 30;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = false;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // FrmHrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(483, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvHrana);
            this.Controls.Add(this.cmbTipHrane);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHrana";
            this.Text = "Hrana";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmHrana_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHrana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHrana;
        private System.Windows.Forms.ComboBox cmbTipHrane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnSortiraj;
    }
}