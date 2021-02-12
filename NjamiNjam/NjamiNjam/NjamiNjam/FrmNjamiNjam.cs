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
    public partial class FrmNjamiNjam : Form
    {
        public FrmNjamiNjam()
        {
            InitializeComponent();                      
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FrmRezervacije rez = new FrmRezervacije();
            rez.ShowDialog();
        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.Uloga == 1)
            {               
                FrmRasporedRadaKorisnik formaKor = new FrmRasporedRadaKorisnik();
                formaKor.ShowDialog();
            }
            else if (PrijavljeniKorisnik.Uloga == 2)
            {
                FrmRasporedRadaAdmin formaAd = new FrmRasporedRadaAdmin();
                formaAd.ShowDialog();
            }         
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            FrmRačuni rac = new FrmRačuni();
            rac.ShowDialog();
        }

        private void btnPonuda_Click(object sender, EventArgs e)
        {
            FrmPonuda ponud = new FrmPonuda();
            ponud.ShowDialog();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeZaposlenicima zap = new FrmUpravljanjeZaposlenicima();
            zap.ShowDialog();
        }

        private void btnAktvinaNarudzba_Click(object sender, EventArgs e)
        {
            FrmPopisStolova aktivneNarudzbe = new FrmPopisStolova();
            aktivneNarudzbe.ShowDialog();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            PrijavljeniKorisnik.KorisnickoIme = null;
            this.Hide();
            FrmPrijava prijava =new FrmPrijava();
            prijava.ShowDialog();
        }

        private void FrmNjamiNjam_Load(object sender, EventArgs e)
        {
            OmogućiUpravljanjeZaposlenika();
            OmogućiUpravljanjePonudom();

            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void OmogućiUpravljanjeZaposlenika()
        {
            if (PrijavljeniKorisnik.Uloga == 1)
            {
                btnZaposlenici.Enabled = false;                
            }
        }

        private void OmogućiUpravljanjePonudom()
        {
            if (PrijavljeniKorisnik.Uloga == 1)
            {
                btnPonuda.Enabled = false;
            }
        }

        private void FrmNjamiNjam_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmGlavniIzbornik.htm");
        }
    }
}