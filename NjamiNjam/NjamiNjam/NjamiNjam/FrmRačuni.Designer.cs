namespace NjamiNjam
{
    partial class FrmRačuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRačuni));
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popustDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDohvatiRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDohvatiRacun = new NjamiNjam.Properties.DataSources.DSDohvatiRacun();
            this.vknacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStorno = new System.Windows.Forms.Button();
            this.btnPonovanIspis = new System.Windows.Forms.Button();
            this.btnPromijenaNacinaPlacanja = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dateTimePickerRacuni = new System.Windows.Forms.DateTimePicker();
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.DSDohvatiRacunTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDohvatiRacunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDohvatiRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoGenerateColumns = false;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvRacuni.DataSource = this.racunBindingSource;
            this.dgvRacuni.Location = new System.Drawing.Point(19, 73);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(535, 222);
            this.dgvRacuni.TabIndex = 0;
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
            this.brojstolaDataGridViewTextBoxColumn.HeaderText = "Broj_stola";
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
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSDohvatiRacunBindingSource;
            // 
            // dSDohvatiRacunBindingSource
            // 
            this.dSDohvatiRacunBindingSource.DataSource = this.dSDohvatiRacun;
            this.dSDohvatiRacunBindingSource.Position = 0;
            // 
            // dSDohvatiRacun
            // 
            this.dSDohvatiRacun.DataSetName = "DSDohvatiRacun";
            this.dSDohvatiRacun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dSDohvatiRacunBindingSource;
            // 
            // vkstatusDataGridViewTextBoxColumn
            // 
            this.vkstatusDataGridViewTextBoxColumn.DataPropertyName = "vk_status";
            this.vkstatusDataGridViewTextBoxColumn.DataSource = this.dataTable1BindingSource2;
            this.vkstatusDataGridViewTextBoxColumn.DisplayMember = "Naziv1";
            this.vkstatusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vkstatusDataGridViewTextBoxColumn.HeaderText = "Status računa";
            this.vkstatusDataGridViewTextBoxColumn.Name = "vkstatusDataGridViewTextBoxColumn";
            this.vkstatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vkstatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vkstatusDataGridViewTextBoxColumn.ValueMember = "vk_status";
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dSDohvatiRacunBindingSource;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            // 
            // nacinplacanjaDataGridViewTextBoxColumn
            // 
            this.nacinplacanjaDataGridViewTextBoxColumn.DataPropertyName = "Nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.HeaderText = "Nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.Name = "nacinplacanjaDataGridViewTextBoxColumn";
            // 
            // statusracunaDataGridViewTextBoxColumn
            // 
            this.statusracunaDataGridViewTextBoxColumn.DataPropertyName = "Status_racuna";
            this.statusracunaDataGridViewTextBoxColumn.HeaderText = "Status_racuna";
            this.statusracunaDataGridViewTextBoxColumn.Name = "statusracunaDataGridViewTextBoxColumn";
            // 
            // stavkeracunaDataGridViewTextBoxColumn
            // 
            this.stavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn.HeaderText = "Stavke_racuna";
            this.stavkeracunaDataGridViewTextBoxColumn.Name = "stavkeracunaDataGridViewTextBoxColumn";
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(NjamiNjam.Racun);
            // 
            // btnStorno
            // 
            this.btnStorno.BackColor = System.Drawing.Color.Maroon;
            this.btnStorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStorno.Location = new System.Drawing.Point(19, 318);
            this.btnStorno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(118, 34);
            this.btnStorno.TabIndex = 1;
            this.btnStorno.Text = "Storniraj račun";
            this.btnStorno.UseVisualStyleBackColor = false;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // btnPonovanIspis
            // 
            this.btnPonovanIspis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPonovanIspis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPonovanIspis.Location = new System.Drawing.Point(152, 318);
            this.btnPonovanIspis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPonovanIspis.Name = "btnPonovanIspis";
            this.btnPonovanIspis.Size = new System.Drawing.Size(138, 34);
            this.btnPonovanIspis.TabIndex = 2;
            this.btnPonovanIspis.Text = "Ponovno ispiši račun";
            this.btnPonovanIspis.UseVisualStyleBackColor = false;
            this.btnPonovanIspis.Click += new System.EventHandler(this.btnPonovanIspis_Click);
            // 
            // btnPromijenaNacinaPlacanja
            // 
            this.btnPromijenaNacinaPlacanja.BackColor = System.Drawing.Color.Brown;
            this.btnPromijenaNacinaPlacanja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPromijenaNacinaPlacanja.Location = new System.Drawing.Point(314, 318);
            this.btnPromijenaNacinaPlacanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPromijenaNacinaPlacanja.Name = "btnPromijenaNacinaPlacanja";
            this.btnPromijenaNacinaPlacanja.Size = new System.Drawing.Size(146, 34);
            this.btnPromijenaNacinaPlacanja.TabIndex = 3;
            this.btnPromijenaNacinaPlacanja.Text = "Promijeni način plaćanja";
            this.btnPromijenaNacinaPlacanja.UseVisualStyleBackColor = false;
            this.btnPromijenaNacinaPlacanja.Click += new System.EventHandler(this.btnPromijenaNacinaPlacanja_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZatvori.Location = new System.Drawing.Point(481, 318);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(73, 34);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dateTimePickerRacuni
            // 
            this.dateTimePickerRacuni.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePickerRacuni.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePickerRacuni.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePickerRacuni.Location = new System.Drawing.Point(19, 30);
            this.dateTimePickerRacuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerRacuni.Name = "dateTimePickerRacuni";
            this.dateTimePickerRacuni.Size = new System.Drawing.Size(128, 20);
            this.dateTimePickerRacuni.TabIndex = 5;
            this.dateTimePickerRacuni.ValueChanged += new System.EventHandler(this.dateTimePickerRacuni_ValueChanged);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmRačuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(576, 390);
            this.Controls.Add(this.dateTimePickerRacuni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPromijenaNacinaPlacanja);
            this.Controls.Add(this.btnPonovanIspis);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.dgvRacuni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRačuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FrmRačuni_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRačuni_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDohvatiRacunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDohvatiRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnStorno;
        private System.Windows.Forms.Button btnPonovanIspis;
        private System.Windows.Forms.Button btnPromijenaNacinaPlacanja;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DateTimePicker dateTimePickerRacuni;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private Properties.DataSources.DSDohvatiRacun dSDohvatiRacun;
        private System.Windows.Forms.BindingSource dSDohvatiRacunBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.DSDohvatiRacunTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popustDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vknacinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeracunaDataGridViewTextBoxColumn;
    }
}