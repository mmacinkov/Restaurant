namespace NjamiNjam
{
    partial class FrmDodavanjeRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodavanjeRacuna));
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPretraziArtikle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gumbDodajNaRacun = new System.Windows.Forms.Button();
            this.gumbKreirajRacun = new System.Windows.Forms.Button();
            this.gumbObrisi = new System.Windows.Forms.Button();
            this.dsAktivneNarudzbeDohvatiKorisnika = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnika();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnikaTableAdapters.DataTable1TableAdapter();
            this.dsAktivneNarudzbeDohvatiNacinPlacanja = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter1 = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanjaTableAdapters.DataTable1TableAdapter();
            this.dsAktvineNarudzbeDohvatiStatus = new NjamiNjam.Properties.DataSources.dsAktvineNarudzbeDohvatiStatus();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter2 = new NjamiNjam.Properties.DataSources.dsAktvineNarudzbeDohvatiStatusTableAdapters.DataTable1TableAdapter();
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
            this.dsAktivneNarudzbeDohvatiNazivArtikla = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNazivArtikla();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter3 = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiNazivArtiklaTableAdapters.DataTable1TableAdapter();
            this.vkracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkartiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAktivneNarudzbeDohvatiTip = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiTip();
            this.dataTable1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter4 = new NjamiNjam.Properties.DataSources.dsAktivneNarudzbeDohvatiTipTableAdapters.DataTable1TableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijediodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vktipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeracunaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktvineNarudzbeDohvatiStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNazivArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AutoGenerateColumns = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vkracunDataGridViewTextBoxColumn,
            this.vkartiklDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.artikliDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn});
            this.dgvStavkeRacuna.DataSource = this.stavkeracunaBindingSource;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(12, 232);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(412, 147);
            this.dgvStavkeRacuna.TabIndex = 15;
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gumbIzlaz.Location = new System.Drawing.Point(882, 391);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.gumbIzlaz.TabIndex = 14;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stavke računa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Računi:";
            // 
            // dgvRacun
            // 
            this.dgvRacun.AutoGenerateColumns = false;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvRacun.DataSource = this.racunBindingSource;
            this.dgvRacun.Location = new System.Drawing.Point(12, 34);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(945, 123);
            this.dgvRacun.TabIndex = 11;
            this.dgvRacun.SelectionChanged += new System.EventHandler(this.dgvRacun_SelectionChanged);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoGenerateColumns = false;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.vrijediodDataGridViewTextBoxColumn,
            this.vrijedidoDataGridViewTextBoxColumn,
            this.vktipDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.stavkeracunaDataGridViewTextBoxColumn1});
            this.dgvArtikli.DataSource = this.artikliBindingSource;
            this.dgvArtikli.Location = new System.Drawing.Point(458, 232);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(499, 147);
            this.dgvArtikli.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(455, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Artikli:";
            // 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(629, 210);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaArtikla.TabIndex = 18;
            this.cmbVrstaArtikla.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaArtikla_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(545, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vrsta artikla";
            // 
            // txtPretraziArtikle
            // 
            this.txtPretraziArtikle.Location = new System.Drawing.Point(857, 210);
            this.txtPretraziArtikle.Name = "txtPretraziArtikle";
            this.txtPretraziArtikle.Size = new System.Drawing.Size(100, 20);
            this.txtPretraziArtikle.TabIndex = 20;
            this.txtPretraziArtikle.TextChanged += new System.EventHandler(this.txtPretraziArtikle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(756, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pretraži artikle:";
            // 
            // gumbDodajNaRacun
            // 
            this.gumbDodajNaRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gumbDodajNaRacun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gumbDodajNaRacun.Location = new System.Drawing.Point(749, 391);
            this.gumbDodajNaRacun.Name = "gumbDodajNaRacun";
            this.gumbDodajNaRacun.Size = new System.Drawing.Size(102, 23);
            this.gumbDodajNaRacun.TabIndex = 24;
            this.gumbDodajNaRacun.Text = "Dodaj na račun";
            this.gumbDodajNaRacun.UseVisualStyleBackColor = false;
            this.gumbDodajNaRacun.Click += new System.EventHandler(this.gumbDodajNaRacun_Click);
            // 
            // gumbKreirajRacun
            // 
            this.gumbKreirajRacun.BackColor = System.Drawing.Color.Maroon;
            this.gumbKreirajRacun.ForeColor = System.Drawing.SystemColors.Control;
            this.gumbKreirajRacun.Location = new System.Drawing.Point(872, 163);
            this.gumbKreirajRacun.Name = "gumbKreirajRacun";
            this.gumbKreirajRacun.Size = new System.Drawing.Size(86, 30);
            this.gumbKreirajRacun.TabIndex = 25;
            this.gumbKreirajRacun.Text = "Kreiraj račun";
            this.gumbKreirajRacun.UseVisualStyleBackColor = false;
            this.gumbKreirajRacun.Click += new System.EventHandler(this.gumbKreirajRacun_Click);
            // 
            // gumbObrisi
            // 
            this.gumbObrisi.BackColor = System.Drawing.Color.Brown;
            this.gumbObrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.gumbObrisi.Location = new System.Drawing.Point(322, 391);
            this.gumbObrisi.Name = "gumbObrisi";
            this.gumbObrisi.Size = new System.Drawing.Size(102, 23);
            this.gumbObrisi.TabIndex = 26;
            this.gumbObrisi.Text = "Obriši sa računa";
            this.gumbObrisi.UseVisualStyleBackColor = false;
            this.gumbObrisi.Click += new System.EventHandler(this.gumbObrisi_Click);
            // 
            // dsAktivneNarudzbeDohvatiKorisnika
            // 
            this.dsAktivneNarudzbeDohvatiKorisnika.DataSetName = "dsAktivneNarudzbeDohvatiKorisnika";
            this.dsAktivneNarudzbeDohvatiKorisnika.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataSource = typeof(NjamiNjam.Artikli);
            // 
            // stavkeracunaBindingSource
            // 
            this.stavkeracunaBindingSource.DataSource = typeof(NjamiNjam.Stavke_racuna);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(NjamiNjam.Racun);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsAktivneNarudzbeDohvatiKorisnika;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dsAktivneNarudzbeDohvatiNacinPlacanja
            // 
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataSetName = "dsAktivneNarudzbeDohvatiNacinPlacanja";
            this.dsAktivneNarudzbeDohvatiNacinPlacanja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dsAktivneNarudzbeDohvatiNacinPlacanja;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // dsAktvineNarudzbeDohvatiStatus
            // 
            this.dsAktvineNarudzbeDohvatiStatus.DataSetName = "dsAktvineNarudzbeDohvatiStatus";
            this.dsAktvineNarudzbeDohvatiStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dsAktvineNarudzbeDohvatiStatus;
            // 
            // dataTable1TableAdapter2
            // 
            this.dataTable1TableAdapter2.ClearBeforeFill = true;
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
            this.vkkorisnikDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource;
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
            this.vknacinDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource1;
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
            this.vkstatusDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource2;
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
            // dsAktivneNarudzbeDohvatiNazivArtikla
            // 
            this.dsAktivneNarudzbeDohvatiNazivArtikla.DataSetName = "dsAktivneNarudzbeDohvatiNazivArtikla";
            this.dsAktivneNarudzbeDohvatiNazivArtikla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dsAktivneNarudzbeDohvatiNazivArtikla;
            // 
            // dataTable1TableAdapter3
            // 
            this.dataTable1TableAdapter3.ClearBeforeFill = true;
            // 
            // vkracunDataGridViewTextBoxColumn
            // 
            this.vkracunDataGridViewTextBoxColumn.DataPropertyName = "vk_racun";
            this.vkracunDataGridViewTextBoxColumn.HeaderText = "ID računa";
            this.vkracunDataGridViewTextBoxColumn.Name = "vkracunDataGridViewTextBoxColumn";
            // 
            // vkartiklDataGridViewTextBoxColumn
            // 
            this.vkartiklDataGridViewTextBoxColumn.DataPropertyName = "vk_artikl";
            this.vkartiklDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource3;
            this.vkartiklDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vkartiklDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vkartiklDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.vkartiklDataGridViewTextBoxColumn.Name = "vkartiklDataGridViewTextBoxColumn";
            this.vkartiklDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vkartiklDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vkartiklDataGridViewTextBoxColumn.ValueMember = "vk_artikl";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // artikliDataGridViewTextBoxColumn
            // 
            this.artikliDataGridViewTextBoxColumn.DataPropertyName = "Artikli";
            this.artikliDataGridViewTextBoxColumn.HeaderText = "Artikli";
            this.artikliDataGridViewTextBoxColumn.Name = "artikliDataGridViewTextBoxColumn";
            this.artikliDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsAktivneNarudzbeDohvatiTip
            // 
            this.dsAktivneNarudzbeDohvatiTip.DataSetName = "dsAktivneNarudzbeDohvatiTip";
            this.dsAktivneNarudzbeDohvatiTip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource4
            // 
            this.dataTable1BindingSource4.DataMember = "DataTable1";
            this.dataTable1BindingSource4.DataSource = this.dsAktivneNarudzbeDohvatiTip;
            // 
            // dataTable1TableAdapter4
            // 
            this.dataTable1TableAdapter4.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn1
            // 
            this.cijenaDataGridViewTextBoxColumn1.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn1.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn1.Name = "cijenaDataGridViewTextBoxColumn1";
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // vrijediodDataGridViewTextBoxColumn
            // 
            this.vrijediodDataGridViewTextBoxColumn.DataPropertyName = "Vrijedi_od";
            this.vrijediodDataGridViewTextBoxColumn.HeaderText = "Vrijedi od";
            this.vrijediodDataGridViewTextBoxColumn.Name = "vrijediodDataGridViewTextBoxColumn";
            // 
            // vrijedidoDataGridViewTextBoxColumn
            // 
            this.vrijedidoDataGridViewTextBoxColumn.DataPropertyName = "Vrijedi_do";
            this.vrijedidoDataGridViewTextBoxColumn.HeaderText = "Vrijedi do";
            this.vrijedidoDataGridViewTextBoxColumn.Name = "vrijedidoDataGridViewTextBoxColumn";
            // 
            // vktipDataGridViewTextBoxColumn
            // 
            this.vktipDataGridViewTextBoxColumn.DataPropertyName = "vk_tip";
            this.vktipDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource4;
            this.vktipDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.vktipDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vktipDataGridViewTextBoxColumn.HeaderText = "Tip artikla";
            this.vktipDataGridViewTextBoxColumn.Name = "vktipDataGridViewTextBoxColumn";
            this.vktipDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vktipDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vktipDataGridViewTextBoxColumn.ValueMember = "vk_tip";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeracunaDataGridViewTextBoxColumn1
            // 
            this.stavkeracunaDataGridViewTextBoxColumn1.DataPropertyName = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn1.HeaderText = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn1.Name = "stavkeracunaDataGridViewTextBoxColumn1";
            this.stavkeracunaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // FrmDodavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(969, 426);
            this.Controls.Add(this.gumbObrisi);
            this.Controls.Add(this.gumbKreirajRacun);
            this.Controls.Add(this.gumbDodajNaRacun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPretraziArtikle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbVrstaArtikla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRacun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodavanjeRacuna";
            this.Text = "Dodavanje računa";
            this.Load += new System.EventHandler(this.FrmDodavanjeRacuna_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodavanjeRacuna_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNacinPlacanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktvineNarudzbeDohvatiStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiNazivArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAktivneNarudzbeDohvatiTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button gumbIzlaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretraziArtikle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gumbDodajNaRacun;
        private System.Windows.Forms.Button gumbKreirajRacun;
        private System.Windows.Forms.Button gumbObrisi;
        private System.Windows.Forms.BindingSource stavkeracunaBindingSource;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnika dsAktivneNarudzbeDohvatiKorisnika;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiKorisnikaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanja dsAktivneNarudzbeDohvatiNacinPlacanja;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNacinPlacanjaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private Properties.DataSources.dsAktvineNarudzbeDohvatiStatus dsAktvineNarudzbeDohvatiStatus;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private Properties.DataSources.dsAktvineNarudzbeDohvatiStatusTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
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
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNazivArtikla dsAktivneNarudzbeDohvatiNazivArtikla;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiNazivArtiklaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vkracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkartiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunDataGridViewTextBoxColumn;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiTip dsAktivneNarudzbeDohvatiTip;
        private System.Windows.Forms.BindingSource dataTable1BindingSource4;
        private Properties.DataSources.dsAktivneNarudzbeDohvatiTipTableAdapters.DataTable1TableAdapter dataTable1TableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijediodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vktipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeracunaDataGridViewTextBoxColumn1;
    }
}