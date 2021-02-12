namespace NjamiNjam
{
    partial class FrmRasporedRadaKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRasporedRadaKorisnik));
            this.gumbIzlaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRasporedRada = new System.Windows.Forms.DataGridView();
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
            this.vkkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tjednirasporedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporedRada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjednirasporedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbIzlaz
            // 
            this.gumbIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gumbIzlaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbIzlaz.Location = new System.Drawing.Point(773, 209);
            this.gumbIzlaz.Name = "gumbIzlaz";
            this.gumbIzlaz.Size = new System.Drawing.Size(81, 32);
            this.gumbIzlaz.TabIndex = 5;
            this.gumbIzlaz.Text = "Izlaz";
            this.gumbIzlaz.UseVisualStyleBackColor = false;
            this.gumbIzlaz.Click += new System.EventHandler(this.gumbIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raspored rada:";
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
            this.dgvRasporedRada.Size = new System.Drawing.Size(842, 160);
            this.dgvRasporedRada.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
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
            this.vkkorisnikDataGridViewTextBoxColumn.HeaderText = "vk_korisnik";
            this.vkkorisnikDataGridViewTextBoxColumn.Name = "vkkorisnikDataGridViewTextBoxColumn";
            this.vkkorisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // tjednirasporedBindingSource
            // 
            this.tjednirasporedBindingSource.DataSource = typeof(NjamiNjam.Tjedni_raspored);
            // 
            // FrmRasporedRadaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(871, 252);
            this.Controls.Add(this.gumbIzlaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRasporedRada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRasporedRadaKorisnik";
            this.Text = "Raspored rada";
            this.Load += new System.EventHandler(this.FrmRasporedRadaKorisnik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRasporedRadaKorisnik_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRasporedRada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjednirasporedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRasporedRada;
        private System.Windows.Forms.BindingSource tjednirasporedBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn vkkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
    }
}