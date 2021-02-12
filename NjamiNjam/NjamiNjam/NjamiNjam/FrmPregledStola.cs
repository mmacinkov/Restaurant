using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam
{
    public partial class FrmPregledStola : Form
    {
        Klase.AktivneNarudzbe aktivneNarudzbe = new Klase.AktivneNarudzbe();
        int brojStola;

        public FrmPregledStola(int broj)
        {
            InitializeComponent();
            brojStola = broj;
        }

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPregledStola_Load(object sender, EventArgs e)
        { 
            this.dataTable1TableAdapter3.Fill(this.dsAktivneNarudzbeDohvatiNazivArtikla.DataTable1);
            this.dataTable1TableAdapter2.Fill(this.dsAktvineNarudzbeDohvatiStatus.DataTable1);         
            this.dataTable1TableAdapter1.Fill(this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataTable1);           
            this.dataTable1TableAdapter.Fill(this.dsAktivneNarudzbeDohvatiKorisnika.DataTable1);
            dgvRacun.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

            dgvRacun.Columns[8].Visible = false;
            dgvRacun.Columns[9].Visible = false;
            dgvRacun.Columns[10].Visible = false;
            dgvRacun.Columns[11].Visible = false;

            if (dgvRacun.RowCount == 0)
            {
                MessageBox.Show("Za odabranim stolom ne postoji račun za pregled!", "Obavijes", MessageBoxButtons.OK);
                Close();
            }
        }

        private void dgvRacun_SelectionChanged(object sender, EventArgs e)
        {
            Racun odabraniRacun = dgvRacun.CurrentRow.DataBoundItem as Racun;
            dgvPopisArtikala.DataSource = aktivneNarudzbe.PopuniStavke(odabraniRacun);

            dgvPopisArtikala.Columns[3].Visible = false;
            dgvPopisArtikala.Columns[4].Visible = false;
        }
    }
}