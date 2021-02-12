namespace NjamiNjam
{
    partial class FrmPonovanIspisRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonovanIspisRacuna));
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRacunIzvjestaj = new NjamiNjam.Properties.DataSources.DSRacunIzvjestaj();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new NjamiNjam.Properties.DataSources.DSRacunIzvjestajTableAdapters.DataTable1TableAdapter();
            this.RacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRacunIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RacunBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSRacun";
            reportDataSource1.Value = this.RacunBindingSource;
            reportDataSource2.Name = "DSRacunIzvjestaj";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NjamiNjam.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(848, 820);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // RacunBindingSource
            // 
            this.RacunBindingSource.DataSource = typeof(NjamiNjam.Racun);
            // 
            // FrmPonovanIspisRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 820);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPonovanIspisRacuna";
            this.Text = "Ponovan ispis racuna";
            this.Load += new System.EventHandler(this.FrmPonovanIspisRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRacunIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RacunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RacunBindingSource;
        private Properties.DataSources.DSRacunIzvjestaj dSRacunIzvjestaj;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Properties.DataSources.DSRacunIzvjestajTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}