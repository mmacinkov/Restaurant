namespace NjamiNjam
{
    partial class FrmDodajIliAžurirajSpecijalnuPonudu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajIliAžurirajSpecijalnuPonudu));
            this.txtVrijediDo = new System.Windows.Forms.DateTimePicker();
            this.txtVrijediOd = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUredu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVrijediDo
            // 
            this.txtVrijediDo.Location = new System.Drawing.Point(139, 183);
            this.txtVrijediDo.Name = "txtVrijediDo";
            this.txtVrijediDo.Size = new System.Drawing.Size(121, 20);
            this.txtVrijediDo.TabIndex = 44;
            // 
            // txtVrijediOd
            // 
            this.txtVrijediOd.Location = new System.Drawing.Point(139, 140);
            this.txtVrijediOd.Name = "txtVrijediOd";
            this.txtVrijediOd.Size = new System.Drawing.Size(121, 20);
            this.txtVrijediOd.TabIndex = 43;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdustani.Location = new System.Drawing.Point(170, 228);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(90, 32);
            this.btnOdustani.TabIndex = 41;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUredu
            // 
            this.btnUredu.BackColor = System.Drawing.Color.Maroon;
            this.btnUredu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUredu.Location = new System.Drawing.Point(44, 228);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(83, 32);
            this.btnUredu.TabIndex = 40;
            this.btnUredu.Text = "Spremi";
            this.btnUredu.UseVisualStyleBackColor = false;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vrijedi do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Vrijedi od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cijena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Naziv:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(139, 104);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 33;
            this.txtKolicina.Leave += new System.EventHandler(this.txtKolicina_Leave);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(139, 66);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 32;
            this.txtCijena.Leave += new System.EventHandler(this.txtCijena_Leave);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(139, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 31;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // FrmDodajIliAžurirajSpecijalnuPonudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(307, 279);
            this.Controls.Add(this.txtVrijediDo);
            this.Controls.Add(this.txtVrijediOd);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodajIliAžurirajSpecijalnuPonudu";
            this.Text = "Dodaj ili ažuriraj specijalnu ponudu";
            this.Load += new System.EventHandler(this.FrmDodajIliAžurirajSpecijalnuPonudu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtVrijediDo;
        private System.Windows.Forms.DateTimePicker txtVrijediOd;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}