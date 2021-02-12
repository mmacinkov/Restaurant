namespace NjamiNjam
{
    partial class FrmIspisRacuna
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIspisRacuna));
            this.RacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRacunIzvjestaj = new NjamiNjam.Properties.DataSources.DSRacunIzvjestaj();
            this.dgvPopisRacuna = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.gumbIspis = new System.Windows.Forms.Button();
            this.rpvRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.DSRacunIzvjestajTableAdapters.DataTable1TableAdapter();
            this.dsAktivneNarudzbeDohvatiKorisnika = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnika();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter1 = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnikaTableAdapters.DataTable1TableAdapter();
            this.dsAktivneNarudzbeDohvatiNacinPlacanja = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter2 = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanjaTableAdapters.DataTable1TableAdapter();
            this.dsAktvineNarudzbeDohvatiStatus = new NjamiNjam.Properties.DataSources.dsAktvineNarudzbeDohvatiStatus();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter3 = new NjamiNjam.Properties.DataSources.dsAktvineNarudzbeDohvatiStatusTableAdapters.DataTable1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vknacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRacunIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktvineNarudzbeDohvatiStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // RacunBindingSource
            // 
            this.RacunBindingSource.DataSource = typeof(NjamiNjam.Racun);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSRacunIzvjestaj;
            // 
            // dSRacunIzvjestaj
            // 
            this.dSRacunIzvjestaj.DataSetName = "DSRacunIzvjestaj";
            this.dSRacunIzvjestaj.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPopisRacuna
            // 
            this.dgvPopisRacuna.AutoGenerateColumns = false;
            this.dgvPopisRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.brojstolaDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.popustDataGridViewTextBoxColumn,
            this.vkkorisnikDataGridViewTextBoxColumn,
            this.vknacinDataGridViewTextBoxColumn,
            this.vkstatusDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.nacinplacanjaDataGridViewTextBoxColumn,
            this.statusracunaDataGridViewTextBoxColumn,
            this.stavkeracunaDataGridViewTextBoxColumn});
            this.dgvPopisRacuna.DataSource = this.RacunBindingSource;
            this.dgvPopisRacuna.Location = new System.Drawing.Point(12, 28);
            this.dgvPopisRacuna.Name = "dgvPopisRacuna";
            this.dgvPopisRacuna.Size = new System.Drawing.Size(776, 160);
            this.dgvPopisRacuna.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis računa";
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gumbIzlaz.Location = new System.Drawing.Point(703, 194);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(86, 32);
            this.gumbIzlaz.TabIndex = 2;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // gumbIspis
            // 
            this.gumbIspis.BackColor = System.Drawing.Color.Maroon;
            this.gumbIspis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbIspis.Location = new System.Drawing.Point(612, 194);
            this.gumbIspis.Name = "gumbIspis";
            this.gumbIspis.Size = new System.Drawing.Size(85, 32);
            this.gumbIspis.TabIndex = 3;
            this.gumbIspis.Text = "Ispiši račun";
            this.gumbIspis.UseVisualStyleBackColor = false;
            this.gumbIspis.Click += new System.EventHandler(this.gumbIspis_Click);
            // 
            // rpvRacun
            // 
            reportDataSource1.Name = "DSRacun";
            reportDataSource1.Value = this.RacunBindingSource;
            reportDataSource2.Name = "DSRacunIzvjestaj";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.rpvRacun.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRacun.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvRacun.LocalReport.ReportEmbeddedResource = "NjamiNjam.Report1.rdlc";
            this.rpvRacun.Location = new System.Drawing.Point(12, 232);
            this.rpvRacun.Name = "rpvRacun";
            this.rpvRacun.ServerReport.BearerToken = null;
            this.rpvRacun.Size = new System.Drawing.Size(776, 375);
            this.rpvRacun.TabIndex = 4;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dsAktivneNarudzbeDohvatiKorisnika
            // 
            this.dsAktivneNarudzbeDohvatiKorisnika.DataSetName = "dsAktivneNarudzbeDohvatiKorisnika";
            this.dsAktivneNarudzbeDohvatiKorisnika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dsAktivneNarudzbeDohvatiKorisnika;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // dsAktivneNarudzbeDohvatiNacinPlacanja
            // 
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataSetName = "dsAktivneNarudzbeDohvatiNacinPlacanja";
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dsAktivneNarudzbeDohvatiNacinPlacanja;
            // 
            // dataTable1TableAdapter2
            // 
            this.dataTable1TableAdapter2.ClearBeforeFill = true;
            // 
            // dsAktvineNarudzbeDohvatiStatus
            // 
            this.dsAktvineNarudzbeDohvatiStatus.DataSetName = "dsAktvineNarudzbeDohvatiStatus";
            this.dsAktvineNarudzbeDohvatiStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dsAktvineNarudzbeDohvatiStatus;
            // 
            // dataTable1TableAdapter3
            // 
            this.dataTable1TableAdapter3.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // brojstolaDataGridViewTextBoxColumn
            // 
            this.brojstolaDataGridViewTextBoxColumn.DataPropertyName = "Broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.HeaderText = "Broj stola";
            this.brojstolaDataGridViewTextBoxColumn.Name = "brojstolaDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // popustDataGridViewTextBoxColumn
            // 
            this.popustDataGridViewTextBoxColumn.DataPropertyName = "Popust";
            this.popustDataGridViewTextBoxColumn.HeaderText = "Popust";
            this.popustDataGridViewTextBoxColumn.Name = "popustDataGridViewTextBoxColumn";
            // 
            // vkkorisnikDataGridViewTextBoxColumn
            // 
            this.vkkorisnikDataGridViewTextBoxColumn.DataPropertyName = "vk_korisnik";
            this.vkkorisnikDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource1;
            this.vkkorisnikDataGridViewTextBoxColumn.DisplayMember = "Korisnicko_ime";
            this.vkkorisnikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vkkorisnikDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.vkkorisnikDataGridViewTextBoxColumn.Name = "vkkorisnikDataGridViewTextBoxColumn";
            this.vkkorisnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vkkorisnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vkkorisnikDataGridViewTextBoxColumn.ValueMember = "vk_korisnik";
            // 
            // vknacinDataGridViewTextBoxColumn
            // 
            this.vknacinDataGridViewTextBoxColumn.DataPropertyName = "vk_nacin";
            this.vknacinDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource2;
            this.vknacinDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vknacinDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vknacinDataGridViewTextBoxColumn.HeaderText = "Način plaćanja";
            this.vknacinDataGridViewTextBoxColumn.Name = "vknacinDataGridViewTextBoxColumn";
            this.vknacinDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vknacinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vknacinDataGridViewTextBoxColumn.ValueMember = "vk_nacin";
            this.vknacinDataGridViewTextBoxColumn.Width = 120;
            // 
            // vkstatusDataGridViewTextBoxColumn
            // 
            this.vkstatusDataGridViewTextBoxColumn.DataPropertyName = "vk_status";
            this.vkstatusDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource3;
            this.vkstatusDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vkstatusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vkstatusDataGridViewTextBoxColumn.HeaderText = "Status računa";
            this.vkstatusDataGridViewTextBoxColumn.Name = "vkstatusDataGridViewTextBoxColumn";
            this.vkstatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vkstatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vkstatusDataGridViewTextBoxColumn.ValueMember = "vk_status";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // nacinplacanjaDataGridViewTextBoxColumn
            // 
            this.nacinplacanjaDataGridViewTextBoxColumn.DataPropertyName = "Nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.HeaderText = "Nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.Name = "nacinplacanjaDataGridViewTextBoxColumn";
            this.nacinplacanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusracunaDataGridViewTextBoxColumn
            // 
            this.statusracunaDataGridViewTextBoxColumn.DataPropertyName = "Status_racuna";
            this.statusracunaDataGridViewTextBoxColumn.HeaderText = "Status_racuna";
            this.statusracunaDataGridViewTextBoxColumn.Name = "statusracunaDataGridViewTextBoxColumn";
            this.statusracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeracunaDataGridViewTextBoxColumn
            // 
            this.stavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn.HeaderText = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn.Name = "stavkeracunaDataGridViewTextBoxColumn";
            this.stavkeracunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmIspisRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(798, 619);
            this.Controls.Add(this.rpvRacun);
            this.Controls.Add(this.gumbIspis);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisRacuna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIspisRacuna";
            this.Text = "Ispis računa";
            this.Load += new System.EventHandler(this.FrmIspisRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRacunIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktvineNarudzbeDohvatiStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbIzlaz;
        private System.Windows.Forms.Button gumbIspis;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRacun;
        private System.Windows.Forms.BindingSource RacunBindingSource;
        private Properties.DataSources.DSRacunIzvjestaj dSRacunIzvjestaj;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.DSRacunIzvjestajTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnika dsAktivneNarudzbeDohvatiKorisnika;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnikaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja dsAktivneNarudzbeDohvatiNacinPlacanja;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanjaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private Properties.DataSources.dsAktvineNarudzbeDohvatiStatus dsAktvineNarudzbeDohvatiStatus;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private Properties.DataSources.dsAktvineNarudzbeDohvatiStatusTableAdapters.DataTable1TableAdapter dataTable1TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vknacinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeracunaDataGridViewTextBoxColumn;
    }
}