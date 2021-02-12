namespace NjamiNjam
{
    partial class FrmKreirajRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreirajRacun));
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.gumbKreiraj = new System.Windows.Forms.Button();
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.dsAktivneNarudzbeDohvatiNacinPlacanja = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(119, 9);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popust:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Način plaćanja:";
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(119, 50);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cmbNacinPlacanja.TabIndex = 3;
            // 
            // gumbKreiraj
            // 
            this.gumbKreiraj.BackColor = System.Drawing.Color.Maroon;
            this.gumbKreiraj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbKreiraj.Location = new System.Drawing.Point(38, 89);
            this.gumbKreiraj.Name = "gumbKreiraj";
            this.gumbKreiraj.Size = new System.Drawing.Size(78, 32);
            this.gumbKreiraj.TabIndex = 4;
            this.gumbKreiraj.Text = "Kreiraj";
            this.gumbKreiraj.UseVisualStyleBackColor = false;
            this.gumbKreiraj.Click += new System.EventHandler(this.gumbKreiraj_Click);
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbIzlaz.Location = new System.Drawing.Point(154, 89);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(86, 32);
            this.gumbIzlaz.TabIndex = 5;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // dsAktivneNarudzbeDohvatiNacinPlacanja
            // 
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataSetName = "dsAktivneNarudzbeDohvatiNacinPlacanja";
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmKreirajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(264, 133);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.gumbKreiraj);
            this.Controls.Add(this.cmbNacinPlacanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopust);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKreirajRacun";
            this.Text = "Kreiraj račun";
            this.Load += new System.EventHandler(this.FrmKreirajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.Button gumbKreiraj;
        private System.Windows.Forms.Button gumbIzlaz;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja dsAktivneNarudzbeDohvatiNacinPlacanja;
    }
}