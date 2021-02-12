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
    public partial class FrmUpravljanjeZaposlenicima : Form
    {
        Klase.Zaposlenik zaposlenik = new Klase.Zaposlenik();
        public FrmUpravljanjeZaposlenicima()
        {
            InitializeComponent();
        }

        private void PrikaziZaposlenike()
        {
            korisnikBindingSource.DataSource = zaposlenik.DohvatiSveZaposlenike();
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
            dgvZaposlenici.Columns[12].Visible = false;
            dgvZaposlenici.Columns[13].Visible = false;
            dgvZaposlenici.Columns[14].Visible = false;
            dgvZaposlenici.Columns[9].HeaderText = "Status";
            dgvZaposlenici.Columns[8].HeaderText = "Uloga";
            dgvZaposlenici.Columns[4].HeaderText = "Broj telefona";
            dgvZaposlenici.Columns[6].HeaderText = "Korisničko ime";

        }

        private void FrmUpravljanjeZaposlenicima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDohvatStatusa.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dsDohvatStatusa.DataTable1);
            // TODO: This line of code loads data into the 'dsDohvatUloge.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dsDohvatUloge.DataTable1);
            PrikaziZaposlenike();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajIliAžurirajZaposlenika frm = new FrmDodajIliAžurirajZaposlenika();
            frm.ShowDialog();
            PrikaziZaposlenike();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow != null)
            {

                Korisnik odabraniZaBrisanje = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
                if (odabraniZaBrisanje != null)
                {
                    zaposlenik.ObrisiZaposlenika(odabraniZaBrisanje);

                }
            }

            PrikaziZaposlenike();
                
            

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            Korisnik odabrani = dgvZaposlenici.CurrentRow.DataBoundItem as Korisnik;
            FrmDodajIliAžurirajZaposlenika frm = new FrmDodajIliAžurirajZaposlenika(odabrani);
            frm.ShowDialog();
            PrikaziZaposlenike();

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            korisnikBindingSource.DataSource = zaposlenik.SortirajZaposlenike();
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
            dgvZaposlenici.Columns[12].Visible = false;
            dgvZaposlenici.Columns[13].Visible = false;
            dgvZaposlenici.Columns[14].Visible = false;
            dgvZaposlenici.Columns[9].HeaderText = "Status";
            dgvZaposlenici.Columns[8].HeaderText = "Uloga";
            dgvZaposlenici.Columns[4].HeaderText = "Broj telefona";
            dgvZaposlenici.Columns[6].HeaderText = "Korisničko ime";
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            korisnikBindingSource.DataSource = zaposlenik.PretraziKorisnike(txtPretraga.Text);
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
            dgvZaposlenici.Columns[12].Visible = false;
            dgvZaposlenici.Columns[13].Visible = false;
            dgvZaposlenici.Columns[14].Visible = false;
            dgvZaposlenici.Columns[9].HeaderText = "Status";
            dgvZaposlenici.Columns[8].HeaderText = "Uloga";
            dgvZaposlenici.Columns[4].HeaderText = "Broj telefona";
            dgvZaposlenici.Columns[6].HeaderText = "Korisničko ime";

        }

        private void FrmUpravljanjeZaposlenicima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmZaposlenik.htm");
        }
    }
}
