namespace NjamiNjam
{
    partial class FrmRasporedRadaAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRasporedRadaAdmin));
            this.gumbObrisi = new System.Windows.Forms.Button();
            this.gumbAzuriraj = new System.Windows.Forms.Button();
            this.gumbNapraviNoviRaspored = new System.Windows.Forms.Button();
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.dgvRasporedRada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dsFrmRasporedRadaDohvatiKorisnika = new NjamiNjam.Properties.DataSources.dsFrmRasporedRadaDohvatiKorisnika();
            this.dsFrmRasporedRadaDohvatiKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.dsFrmRasporedRadaDohvatiKorisnikaTableAdapters.DataTable1TableAdapter();
            this.tjednirasporedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojsatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporedRada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFrmRasporedRadaDohvatiKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFrmRasporedRadaDohvatiKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjednirasporedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbObrisi
            // 
            this.gumbObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbObrisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbObrisi.Location = new System.Drawing.Point(237, 251);
            this.gumbObrisi.Name = "gumbObrisi";
            this.gumbObrisi.Size = new System.Drawing.Size(70, 35);
            this.gumbObrisi.TabIndex = 11;
            this.gumbObrisi.Text = "Obriši";
            this.gumbObrisi.UseVisualStyleBackColor = false;
            this.gumbObrisi.Click += new System.EventHandler(this.gumbObrisi_Click);
            // 
            // gumbAzuriraj
            // 
            this.gumbAzuriraj.BackColor = System.Drawing.Color.Brown;
            this.gumbAzuriraj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbAzuriraj.Location = new System.Drawing.Point(156, 251);
            this.gumbAzuriraj.Name = "gumbAzuriraj";
            this.gumbAzuriraj.Size = new System.Drawing.Size(75, 35);
            this.gumbAzuriraj.TabIndex = 10;
            this.gumbAzuriraj.Text = "Ažuriraj";
            this.gumbAzuriraj.UseVisualStyleBackColor = false;
            this.gumbAzuriraj.Click += new System.EventHandler(this.gumbAzuriraj_Click);
            // 
            // gumbNapraviNoviRaspored
            // 
            this.gumbNapraviNoviRaspored.BackColor = System.Drawing.Color.Maroon;
            this.gumbNapraviNoviRaspored.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbNapraviNoviRaspored.Location = new System.Drawing.Point(12, 251);
            this.gumbNapraviNoviRaspored.Name = "gumbNapraviNoviRaspored";
            this.gumbNapraviNoviRaspored.Size = new System.Drawing.Size(138, 35);
            this.gumbNapraviNoviRaspored.TabIndex = 9;
            this.gumbNapraviNoviRaspored.Text = "Napravi novi raspored";
            this.gumbNapraviNoviRaspored.UseVisualStyleBackColor = false;
            this.gumbNapraviNoviRaspored.Click += new System.EventHandler(this.gumbNapraviNoviRaspored_Click);
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gumbIzlaz.Location = new System.Drawing.Point(690, 251);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(96, 35);
            this.gumbIzlaz.TabIndex = 8;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // dgvRasporedRada
            // 
            this.dgvRasporedRada.AutoGenerateColumns = false;
            this.dgvRasporedRada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRasporedRada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.datumodDataGridViewTextBoxColumn,
            this.datumdoDataGridViewTextBoxColumn,
            this.ponDataGridViewTextBoxColumn,
            this.utoDataGridViewTextBoxColumn,
            this.sriDataGridViewTextBoxColumn,
            this.cetDataGridViewTextBoxColumn,
            this.petDataGridViewTextBoxColumn,
            this.subDataGridViewTextBoxColumn,
            this.nedDataGridViewTextBoxColumn,
            this.brojsatiDataGridViewTextBoxColumn,
            this.vkkorisnikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn});
            this.dgvRasporedRada.DataSource = this.tjednirasporedBindingSource;
            this.dgvRasporedRada.Location = new System.Drawing.Point(12, 28);
            this.dgvRasporedRada.Name = "dgvRasporedRada";
            this.dgvRasporedRada.Size = new System.Drawing.Size(774, 205);
            this.dgvRasporedRada.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raspored rada:";
            // 
            // dsFrmRasporedRadaDohvatiKorisnika
            // 
            this.dsFrmRasporedRadaDohvatiKorisnika.DataSetName = "dsFrmRasporedRadaDohvatiKorisnika";
            this.dsFrmRasporedRadaDohvatiKorisnika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsFrmRasporedRadaDohvatiKorisnikaBindingSource
            // 
            this.dsFrmRasporedRadaDohvatiKorisnikaBindingSource.DataSource = this.dsFrmRasporedRadaDohvatiKorisnika;
            this.dsFrmRasporedRadaDohvatiKorisnikaBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsFrmRasporedRadaDohvatiKorisnika;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tjednirasporedBindingSource
            // 
            this.tjednirasporedBindingSource.DataSource = typeof(NjamiNjam.Tjedni_raspored);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // datumodDataGridViewTextBoxColumn
            // 
            this.datumodDataGridViewTextBoxColumn.DataPropertyName = "Datum_od";
            this.datumodDataGridViewTextBoxColumn.HeaderText = "Datum od";
            this.datumodDataGridViewTextBoxColumn.Name = "datumodDataGridViewTextBoxColumn";
            // 
            // datumdoDataGridViewTextBoxColumn
            // 
            this.datumdoDataGridViewTextBoxColumn.DataPropertyName = "Datum_do";
            this.datumdoDataGridViewTextBoxColumn.HeaderText = "Datum do";
            this.datumdoDataGridViewTextBoxColumn.Name = "datumdoDataGridViewTextBoxColumn";
            // 
            // ponDataGridViewTextBoxColumn
            // 
            this.ponDataGridViewTextBoxColumn.DataPropertyName = "Pon";
            this.ponDataGridViewTextBoxColumn.HeaderText = "Ponedjeljak";
            this.ponDataGridViewTextBoxColumn.Name = "ponDataGridViewTextBoxColumn";
            // 
            // utoDataGridViewTextBoxColumn
            // 
            this.utoDataGridViewTextBoxColumn.DataPropertyName = "Uto";
            this.utoDataGridViewTextBoxColumn.HeaderText = "Utorak";
            this.utoDataGridViewTextBoxColumn.Name = "utoDataGridViewTextBoxColumn";
            // 
            // sriDataGridViewTextBoxColumn
            // 
            this.sriDataGridViewTextBoxColumn.DataPropertyName = "Sri";
            this.sriDataGridViewTextBoxColumn.HeaderText = "Srijeda";
            this.sriDataGridViewTextBoxColumn.Name = "sriDataGridViewTextBoxColumn";
            // 
            // cetDataGridViewTextBoxColumn
            // 
            this.cetDataGridViewTextBoxColumn.DataPropertyName = "Cet";
            this.cetDataGridViewTextBoxColumn.HeaderText = "Četvrtak";
            this.cetDataGridViewTextBoxColumn.Name = "cetDataGridViewTextBoxColumn";
            // 
            // petDataGridViewTextBoxColumn
            // 
            this.petDataGridViewTextBoxColumn.DataPropertyName = "Pet";
            this.petDataGridViewTextBoxColumn.HeaderText = "Petak";
            this.petDataGridViewTextBoxColumn.Name = "petDataGridViewTextBoxColumn";
            // 
            // subDataGridViewTextBoxColumn
            // 
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Subota";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            // 
            // nedDataGridViewTextBoxColumn
            // 
            this.nedDataGridViewTextBoxColumn.DataPropertyName = "Ned";
            this.nedDataGridViewTextBoxColumn.HeaderText = "Nedjelja";
            this.nedDataGridViewTextBoxColumn.Name = "nedDataGridViewTextBoxColumn";
            // 
            // brojsatiDataGridViewTextBoxColumn
            // 
            this.brojsatiDataGridViewTextBoxColumn.DataPropertyName = "Broj_sati";
            this.brojsatiDataGridViewTextBoxColumn.HeaderText = "Broj sati";
            this.brojsatiDataGridViewTextBoxColumn.Name = "brojsatiDataGridViewTextBoxColumn";
            // 
            // vkkorisnikDataGridViewTextBoxColumn
            // 
            this.vkkorisnikDataGridViewTextBoxColumn.DataPropertyName = "vk_korisnik";
            this.vkkorisnikDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource;
            this.vkkorisnikDataGridViewTextBoxColumn.DisplayMember = "Korisnicko_ime";
            this.vkkorisnikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vkkorisnikDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.vkkorisnikDataGridViewTextBoxColumn.Name = "vkkorisnikDataGridViewTextBoxColumn";
            this.vkkorisnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vkkorisnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vkkorisnikDataGridViewTextBoxColumn.ValueMember = "vk_korisnik";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmRasporedRadaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.gumbObrisi);
            this.Controls.Add(this.gumbAzuriraj);
            this.Controls.Add(this.gumbNapraviNoviRaspored);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.dgvRasporedRada);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRasporedRadaAdmin";
            this.Text = "Raspored rada";
            this.Load += new System.EventHandler(this.FrmRasporedRadaAdmin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRasporedRadaAdmin_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporedRada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFrmRasporedRadaDohvatiKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFrmRasporedRadaDohvatiKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjednirasporedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbObrisi;
        private System.Windows.Forms.Button gumbAzuriraj;
        private System.Windows.Forms.Button gumbNapraviNoviRaspored;
        private System.Windows.Forms.Button gumbIzlaz;
        private System.Windows.Forms.DataGridView dgvRasporedRada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tjednirasporedBindingSource;
        private Properties.DataSources.dsFrmRasporedRadaDohvatiKorisnika dsFrmRasporedRadaDohvatiKorisnika;
        private System.Windows.Forms.BindingSource dsFrmRasporedRadaDohvatiKorisnikaBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.dsFrmRasporedRadaDohvatiKorisnikaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
    }
}