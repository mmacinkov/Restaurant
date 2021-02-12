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
    public partial class FrmDodavanjeRacuna : Form
    {
        Klase.AktivneNarudzbe aktivneNarudzbe = new Klase.AktivneNarudzbe();
        int brojStola;

        public FrmDodavanjeRacuna(int broj)
        {
            InitializeComponent();
            brojStola = broj;
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            using (var db = new NjamiNjamEntities())
            {
                var upit = from t in db.Tip
                           select t;

                foreach (var item in upit.Distinct().ToList())
                {
                    cmbVrstaArtikla.Items.Add(item);
                }
            }
        }            
          
        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbKreirajRacun_Click(object sender, EventArgs e)
        {
            FrmKreirajRacun forma = new FrmKreirajRacun(brojStola);
            forma.ShowDialog();

            dgvRacun.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

            dgvRacun.Columns[8].Visible = false;
            dgvRacun.Columns[9].Visible = false;
            dgvRacun.Columns[10].Visible = false;
            dgvRacun.Columns[11].Visible = false;
        }

        private void FrmDodavanjeRacuna_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter4.Fill(this.dsAktivneNarudzbeDohvatiTip.DataTable1);         
            this.dataTable1TableAdapter3.Fill(this.dsAktivneNarudzbeDohvatiNazivArtikla.DataTable1);         
            this.dataTable1TableAdapter2.Fill(this.dsAktvineNarudzbeDohvatiStatus.DataTable1);
            this.dataTable1TableAdapter1.Fill(this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataTable1);
            this.dataTable1TableAdapter.Fill(this.dsAktivneNarudzbeDohvatiKorisnika.DataTable1);
            dgvRacun.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

            dgvRacun.Columns[8].Visible = false;
            dgvRacun.Columns[9].Visible = false;
            dgvRacun.Columns[10].Visible = false;
            dgvRacun.Columns[11].Visible = false;


            dgvArtikli.DataSource = aktivneNarudzbe.PopuniArtikle();

            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.Columns[8].Visible = false;
        }

        private void dgvRacun_SelectionChanged(object sender, EventArgs e)
        {
            Racun odabraniRacun = dgvRacun.CurrentRow.DataBoundItem as Racun;
            dgvStavkeRacuna.DataSource = aktivneNarudzbe.PopuniStavke(odabraniRacun);

            dgvStavkeRacuna.Columns[3].Visible = false;
            dgvStavkeRacuna.Columns[4].Visible = false;
        }

        private void txtPretraziArtikle_TextChanged(object sender, EventArgs e)
        {
            dgvArtikli.DataSource = aktivneNarudzbe.PretragaTekst(txtPretraziArtikle.Text);

            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.Columns[8].Visible = false;
        }

        private void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tip odabraniTip = cmbVrstaArtikla.SelectedItem as Tip;

            dgvArtikli.DataSource = aktivneNarudzbe.Vrsta(odabraniTip);

            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.Columns[8].Visible = false;
        }

        private void gumbDodajNaRacun_Click(object sender, EventArgs e)
        {
            if (dgvRacun.RowCount != 0)
            {
                Racun odabraniRacun = dgvRacun.CurrentRow.DataBoundItem as Racun;
                Artikli odabraniArtikl = dgvArtikli.CurrentRow.DataBoundItem as Artikli;

                aktivneNarudzbe.DodavanjeArtikalaNaRacun(odabraniRacun, odabraniArtikl);

                this.dataTable1TableAdapter4.Fill(this.dsAktivneNarudzbeDohvatiTip.DataTable1);
                this.dataTable1TableAdapter3.Fill(this.dsAktivneNarudzbeDohvatiNazivArtikla.DataTable1);
                this.dataTable1TableAdapter2.Fill(this.dsAktvineNarudzbeDohvatiStatus.DataTable1);
                this.dataTable1TableAdapter1.Fill(this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataTable1);
                this.dataTable1TableAdapter.Fill(this.dsAktivneNarudzbeDohvatiKorisnika.DataTable1);

                dgvStavkeRacuna.DataSource = aktivneNarudzbe.PopuniStavke(odabraniRacun);

                dgvStavkeRacuna.Columns[3].Visible = false;
                dgvStavkeRacuna.Columns[4].Visible = false;

                dgvRacun.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

                dgvRacun.Columns[8].Visible = false;
                dgvRacun.Columns[9].Visible = false;
                dgvRacun.Columns[10].Visible = false;
                dgvRacun.Columns[11].Visible = false;

                dgvArtikli.DataSource = aktivneNarudzbe.PopuniArtikle();

                dgvArtikli.Columns[7].Visible = false;
                dgvArtikli.Columns[8].Visible = false;
            }
            else
            {
                MessageBox.Show("Trenutno ne postoji račun na koji možete dodati artikl", "Obavijes", MessageBoxButtons.OK);
            }
        }

        private void gumbObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStavkeRacuna.RowCount != 0 && dgvRacun.RowCount != 0)
            {
                Racun odabraniRacun = dgvRacun.CurrentRow.DataBoundItem as Racun;
                Stavke_racuna odabranaStavka = dgvStavkeRacuna.CurrentRow.DataBoundItem as Stavke_racuna;

                aktivneNarudzbe.UkloniStavku(odabranaStavka, odabraniRacun);

                dgvStavkeRacuna.DataSource = aktivneNarudzbe.PopuniStavke(odabraniRacun);

                dgvStavkeRacuna.Columns[3].Visible = false;
                dgvStavkeRacuna.Columns[4].Visible = false;

                dgvRacun.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

                dgvRacun.Columns[8].Visible = false;
                dgvRacun.Columns[9].Visible = false;
                dgvRacun.Columns[10].Visible = false;
                dgvRacun.Columns[11].Visible = false;

                dgvArtikli.DataSource = aktivneNarudzbe.PopuniArtikle();

                dgvArtikli.Columns[7].Visible = false;
                dgvArtikli.Columns[8].Visible = false;
            }
            else
            {
                MessageBox.Show("Trenutno ne postoji stavka za brisanje!", "Obavijes", MessageBoxButtons.OK);
            }
        }

        private void FrmDodavanjeRacuna_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmKreirajRacun.htm");
        }
    }
}