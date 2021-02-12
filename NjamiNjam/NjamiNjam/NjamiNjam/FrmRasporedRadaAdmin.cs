using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam
{
    public partial class FrmRasporedRadaAdmin : Form
    {
        Klase.RasporedRada rasporedRada = new Klase.RasporedRada();

        public FrmRasporedRadaAdmin()
        {
            InitializeComponent();
        }      

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRasporedRadaAdmin_Load(object sender, EventArgs e)
        {      
            this.dataTable1TableAdapter.Fill(this.dsFrmRasporedRadaDohvatiKorisnika.DataTable1);
            dgvRasporedRada.DataSource = rasporedRada.DohvatiRasporedRadaSve();

            dgvRasporedRada.Columns[12].Visible = false;
        }

        private void gumbObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRasporedRada.RowCount != 0)
            {
                Tjedni_raspored raspored = dgvRasporedRada.CurrentRow.DataBoundItem as Tjedni_raspored;
                rasporedRada.ObrisiRaspored(raspored);
                dgvRasporedRada.DataSource = rasporedRada.DohvatiRasporedRadaSve();

                dgvRasporedRada.Columns[12].Visible = false;
            }
            else
            {
                MessageBox.Show("Nema dostupnih rasporeda za brisanje!", "Obavijest", MessageBoxButtons.OK);
            }
        }

        private void gumbNapraviNoviRaspored_Click(object sender, EventArgs e)
        {
            FrmKreiranjeNovogRasporeda forma = new FrmKreiranjeNovogRasporeda();
            forma.ShowDialog();
            this.dataTable1TableAdapter.Fill(this.dsFrmRasporedRadaDohvatiKorisnika.DataTable1);
            dgvRasporedRada.DataSource = rasporedRada.DohvatiRasporedRadaSve();

            dgvRasporedRada.Columns[12].Visible = false;
        }

        private void gumbAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvRasporedRada.RowCount != 0)
            {
                Tjedni_raspored raspored = dgvRasporedRada.CurrentRow.DataBoundItem as Tjedni_raspored;
                FrmAzuriranjeRasporeda forma = new FrmAzuriranjeRasporeda(raspored);
                forma.ShowDialog();

                this.dataTable1TableAdapter.Fill(this.dsFrmRasporedRadaDohvatiKorisnika.DataTable1);
                dgvRasporedRada.DataSource = rasporedRada.DohvatiRasporedRadaSve();

                dgvRasporedRada.Columns[12].Visible = false;
            }
            else
            {
                MessageBox.Show("Nema dostupnih rasporeda za ažuriranje!", "Obavijest", MessageBoxButtons.OK);
            }
        }

        private void FrmRasporedRadaAdmin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmRasporedRada.htm");
        }
    }
}