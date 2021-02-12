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
    public partial class FrmRezervacije : Form
    {
        Klase.UpravljanjeRezervacijom rezervacije = new Klase.UpravljanjeRezervacijom();
        public FrmRezervacije()
        {
            InitializeComponent();
            NapuniDgvRezervacije();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
        }
        public void NapuniDgvRezervacije()
        {
            dSRezervacijaBindingSource.DataSource = rezervacije.DohvatiRezervacije();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            FrmUpravljanjeRezervacijama upravljanje = new FrmUpravljanjeRezervacijama();
            upravljanje.ShowDialog();

            NapuniDgvRezervacije();
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            Rezervacija odabranaRezervacija = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
            FrmUpravljanjeRezervacijama upravljanje = new FrmUpravljanjeRezervacijama(odabranaRezervacija);
            upravljanje.ShowDialog();
            NapuniDgvRezervacije();
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvRezervacije.CurrentRow!=null)
            {
                Rezervacija rezervacijaZaBrisanje = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
                if (rezervacijaZaBrisanje!=null)
                {
                    if (MessageBox.Show("Jeste li sigurni?","Upozorenje", MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
                    {
                        rezervacije.ObrisiRezervaciju(rezervacijaZaBrisanje);
                        NapuniDgvRezervacije();
                    }
                }
            }
        }

        private void btnPosebanPrikaz_Click(object sender, EventArgs e)
        {
            DateTime odabranoVrijeme = DateTime.Parse(dateTimePicker1.Text);
            dSRezervacijaBindingSource.DataSource = rezervacije.DohvatiRezervacijeNaOdredenDan(odabranoVrijeme);

        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDohvatRezervacijeKorisnik.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dsDohvatRezervacijeKorisnik.DataTable1);
            // TODO: This line of code loads data into the 'dSRezervacija.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dSRezervacija.DataTable1);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRezervacije_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmRezervacije.htm");
        }
    }
}
