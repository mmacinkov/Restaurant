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
    public partial class FrmSpecijalnaPonuda : Form
    {
        Klase.SpecijalnaPonuda specijalna = new Klase.SpecijalnaPonuda();
        public FrmSpecijalnaPonuda()
        {
            InitializeComponent();
        }

        private void FrmSpecijalnaPonuda_Load(object sender, EventArgs e)
        {
            PrikaziSpecijalnuPonudu();
        }

        private void PrikaziSpecijalnuPonudu()
        {
            dgvSpecijalna.DataSource = specijalna.DohvatiSpecijalnuPonudu(6);
            dgvSpecijalna.Columns[6].Visible = false;
            dgvSpecijalna.Columns[7].Visible = false;
            dgvSpecijalna.Columns[8].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajIliAžurirajSpecijalnuPonudu frm = new FrmDodajIliAžurirajSpecijalnuPonudu();
            frm.ShowDialog();
            PrikaziSpecijalnuPonudu();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Artikli artikli = dgvSpecijalna.CurrentRow.DataBoundItem as Artikli;
            FrmDodajIliAžurirajSpecijalnuPonudu frm = new FrmDodajIliAžurirajSpecijalnuPonudu(artikli);
            frm.ShowDialog();
            PrikaziSpecijalnuPonudu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSpecijalna.CurrentRow != null)
            {
                Artikli odabrani = dgvSpecijalna.CurrentRow.DataBoundItem as Artikli;
                if (odabrani != null)
                {
                    specijalna.ObrisiSpecijalnuPonudu(odabrani);

                }
            }
            PrikaziSpecijalnuPonudu();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziSpecijalnuPonudu();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            dgvSpecijalna.DataSource = specijalna.SortirajSpecijalnuPonudu(6);
            dgvSpecijalna.Columns[6].Visible = false;
            dgvSpecijalna.Columns[7].Visible = false;
            dgvSpecijalna.Columns[8].Visible = false;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            dgvSpecijalna.DataSource = specijalna.PretraziSpecijalnuPonudu(6, txtPretraga.Text);
            dgvSpecijalna.Columns[6].Visible = false;
            dgvSpecijalna.Columns[7].Visible = false;
            dgvSpecijalna.Columns[8].Visible = false;
        }

        private void FrmSpecijalnaPonuda_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmSpecijalnaPonuda.htm");
        }
    }
}
