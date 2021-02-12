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
    public partial class FrmRačuni : Form
    {
        Klase.DohvacanjeRacuna racuni = new Klase.DohvacanjeRacuna();
        public FrmRačuni()
        {
            InitializeComponent();
            PrikaziRacune();
        }
        public void PrikaziRacune()
        {
            racunBindingSource.DataSource = racuni.DohvatiDanasnjeRacune();

            dgvRacuni.Columns[8].Visible = false;
               dgvRacuni.Columns[9].Visible = false;
                dgvRacuni.Columns[10].Visible = false;
                dgvRacuni.Columns[11].Visible = false;

            
        }

        private void dateTimePickerRacuni_ValueChanged(object sender, EventArgs e)
        {

            DateTime odabranoVrijeme = DateTime.Parse(dateTimePickerRacuni.Text);

            racunBindingSource.DataSource = racuni.DohvatiRacuneNaODredenDatum(odabranoVrijeme);


            dgvRacuni.Columns[8].Visible = false;
            dgvRacuni.Columns[9].Visible = false;
            dgvRacuni.Columns[10].Visible = false;
            dgvRacuni.Columns[11].Visible = false;               
                        
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            DateTime odabranoVrijeme = DateTime.Parse(dateTimePickerRacuni.Text);

            if (dgvRacuni.CurrentRow != null)
            {
                Racun racunZaBrisanje = dgvRacuni.CurrentRow.DataBoundItem as Racun;

                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    racuni.StornirajRacun(racunZaBrisanje);
                }
            }
            racunBindingSource.DataSource = racuni.DohvatiRacuneNaODredenDatum(odabranoVrijeme);
        }

        private void btnPonovanIspis_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
            FrmPonovanIspisRacuna ponovanIspis= new FrmPonovanIspisRacuna(odabraniRacun);

            ponovanIspis.ShowDialog();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPromijenaNacinaPlacanja_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
            DateTime odabranoVrijeme = DateTime.Parse(dateTimePickerRacuni.Text);

            racuni.PromijeniNacinPlacanja(odabraniRacun);
            racunBindingSource.DataSource = racuni.DohvatiRacuneNaODredenDatum(odabranoVrijeme);

        }

        private void FrmRačuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSDohvatiRacun.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dSDohvatiRacun.DataTable1);
            if (PrijavljeniKorisnik.Uloga!=2)
            {
                btnPonovanIspis.Enabled = false;
                btnStorno.Enabled = false;
            }
        }

        private void FrmRačuni_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmRacun.htm");
        }
    }
}
