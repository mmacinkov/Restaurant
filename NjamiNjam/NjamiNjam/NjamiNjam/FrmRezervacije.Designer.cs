namespace NjamiNjam
{
    partial class FrmRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervacije));
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojgostijuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vkkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDohvatRezervacijeKorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDohvatRezervacijeKorisnik = new NjamiNjam.Properties.DataSources.dsDohvatRezervacijeKorisnik();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRezervacija = new NjamiNjam.Properties.DataSources.DSRezervacija();
            this.lblRez = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnPosebanPrikaz = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.DSRezervacijaTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter1 = new NjamiNjam.Properties.DataSources.dsDohvatRezervacijeKorisnikTableAdapters.DataTable1TableAdapter();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDohvatRezervacijeKorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDohvatRezervacijeKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.brojstolaDataGridViewTextBoxColumn,
            this.brojgostijuDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.vkkorisnikDataGridViewTextBoxColumn});
            this.dgvRezervacije.DataSource = this.dataTable1BindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(12, 34);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(764, 274);
            this.dgvRezervacije.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojstolaDataGridViewTextBoxColumn
            // 
            this.brojstolaDataGridViewTextBoxColumn.DataPropertyName = "Broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.HeaderText = "Broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.Name = "brojstolaDataGridViewTextBoxColumn";
            // 
            // brojgostijuDataGridViewTextBoxColumn
            // 
            this.brojgostijuDataGridViewTextBoxColumn.DataPropertyName = "Broj_gostiju";
            this.brojgostijuDataGridViewTextBoxColumn.HeaderText = "Broj_gostiju";
            this.brojgostijuDataGridViewTextBoxColumn.Name = "brojgostijuDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
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
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dsDohvatRezervacijeKorisnikBindingSource;
            // 
            // dsDohvatRezervacijeKorisnikBindingSource
            // 
            this.dsDohvatRezervacijeKorisnikBindingSource.DataSource = this.dsDohvatRezervacijeKorisnik;
            this.dsDohvatRezervacijeKorisnikBindingSource.Position = 0;
            // 
            // dsDohvatRezervacijeKorisnik
            // 
            this.dsDohvatRezervacijeKorisnik.DataSetName = "dsDohvatRezervacijeKorisnik";
            this.dsDohvatRezervacijeKorisnik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSRezervacijaBindingSource;
            // 
            // dSRezervacijaBindingSource
            // 
            this.dSRezervacijaBindingSource.DataSource = this.dSRezervacija;
            this.dSRezervacijaBindingSource.Position = 0;
            // 
            // dSRezervacija
            // 
            this.dSRezervacija.DataSetName = "DSRezervacija";
            this.dSRezervacija.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.Location = new System.Drawing.Point(12, 9);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(82, 17);
            this.lblRez.TabIndex = 1;
            this.lblRez.Text = "Rezervacije";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Location = new System.Drawing.Point(93, 337);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(188, 30);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj rezervaciju";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAžuriraj.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAžuriraj.Location = new System.Drawing.Point(305, 337);
            this.btnAžuriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(179, 30);
            this.btnAžuriraj.TabIndex = 3;
            this.btnAžuriraj.Text = "Ažuriraj rezervaciju";
            this.btnAžuriraj.UseVisualStyleBackColor = false;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnObriši.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObriši.Location = new System.Drawing.Point(512, 337);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(157, 30);
            this.btnObriši.TabIndex = 4;
            this.btnObriši.Text = "Obriši rezervaciju";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnPosebanPrikaz
            // 
            this.btnPosebanPrikaz.BackColor = System.Drawing.Color.Brown;
            this.btnPosebanPrikaz.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPosebanPrikaz.Location = new System.Drawing.Point(395, 401);
            this.btnPosebanPrikaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosebanPrikaz.Name = "btnPosebanPrikaz";
            this.btnPosebanPrikaz.Size = new System.Drawing.Size(91, 34);
            this.btnPosebanPrikaz.TabIndex = 5;
            this.btnPosebanPrikaz.Text = "Prikaži ";
            this.btnPosebanPrikaz.UseVisualStyleBackColor = false;
            this.btnPosebanPrikaz.Click += new System.EventHandler(this.btnPosebanPrikaz_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 405);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdustani.Location = new System.Drawing.Point(685, 418);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 30);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPosebanPrikaz);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblRez);
            this.Controls.Add(this.dgvRezervacije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRezervacije_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDohvatRezervacijeKorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDohvatRezervacijeKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRezervacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Label lblRez;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnPosebanPrikaz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource dSRezervacijaBindingSource;
        private Properties.DataSources.DSRezervacija dSRezervacija;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.DSRezervacijaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Properties.DataSources.dsDohvatRezervacijeKorisnik dsDohvatRezervacijeKorisnik;
        private System.Windows.Forms.BindingSource dsDohvatRezervacijeKorisnikBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private Properties.DataSources.dsDohvatRezervacijeKorisnikTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojgostijuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vkkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOdustani;
    }
}