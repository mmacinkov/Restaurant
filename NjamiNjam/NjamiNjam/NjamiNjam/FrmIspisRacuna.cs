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
    public partial class FrmIspisRacuna : Form
    {
        Klase.AktivneNarudzbe aktivneNarudzbe = new Klase.AktivneNarudzbe();
        int brojStola;

        public FrmIspisRacuna(int broj)
        {
            InitializeComponent();
            brojStola = broj;
        }

        private void PrikaziRacun()
        {
            Racun odabraniRacun = dgvPopisRacuna.CurrentRow.DataBoundItem as Racun;

            using (var db = new NjamiNjamEntities())
            {              
                var upit = from st in db.Stavke_racuna
                           join r in db.Racun on st.vk_racun equals odabraniRacun.ID
                           select new { st.Artikli.ID, st.Artikli.Naziv, st.Artikli.Cijena, st.Racun.Popust, st.Kolicina };

                dataTable1BindingSource.DataSource = upit.Distinct().ToList();
                
                var upit2 = from r in db.Racun
                            where r.ID == odabraniRacun.ID
                            select r;

                RacunBindingSource.DataSource = upit2.ToList();
            }

            rpvRacun.RefreshReport();
        }

        private void FrmIspisRacuna_Load(object sender, EventArgs e)
        {           
            this.dataTable1TableAdapter3.Fill(this.dsAktvineNarudzbeDohvatiStatus.DataTable1);           
            this.dataTable1TableAdapter2.Fill(this.dsAktivneNarudzbeDohvatiNacinPlacanja.DataTable1);            
            this.dataTable1TableAdapter1.Fill(this.dsAktivneNarudzbeDohvatiKorisnika.DataTable1);
            dgvPopisRacuna.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

            dgvPopisRacuna.Columns[8].Visible = false;
            dgvPopisRacuna.Columns[9].Visible = false;
            dgvPopisRacuna.Columns[10].Visible = false;
            dgvPopisRacuna.Columns[11].Visible = false;

            if (dgvPopisRacuna.RowCount == 0)
            {
                MessageBox.Show("Za odabranim stolom ne postoji račun za ispis!", "Obavijest", MessageBoxButtons.OK);
                Close();
            }
        }

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbIspis_Click(object sender, EventArgs e)
        {
            Racun odabraniRacun = dgvPopisRacuna.CurrentRow.DataBoundItem as Racun;

            PrikaziRacun();

            aktivneNarudzbe.PromijeniStatus(odabraniRacun);

            dgvPopisRacuna.DataSource = aktivneNarudzbe.PopuniRacune(brojStola);

            dgvPopisRacuna.Columns[8].Visible = false;
            dgvPopisRacuna.Columns[9].Visible = false;
            dgvPopisRacuna.Columns[10].Visible = false;
            dgvPopisRacuna.Columns[11].Visible = false;
        }
    }
}