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
    public partial class FrmHrana : Form
    {
        Klase.Hrana hrana = new Klase.Hrana();
        public FrmHrana()
        {
            InitializeComponent();
        }

        private void Popuni()
        {
            if (cmbTipHrane.SelectedIndex == 0)
            {
                dgvHrana.DataSource = hrana.DohvatiHranu(1);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 1)
            {
                dgvHrana.DataSource = hrana.DohvatiHranu(4);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 2)
            {
                dgvHrana.DataSource = hrana.DohvatiHranu(5);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }
        }

        private void cmbTipHrane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Popuni();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajIliAžurirajHranu frm = new FrmDodajIliAžurirajHranu();
            frm.ShowDialog();
            Popuni();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Artikli artikli = dgvHrana.CurrentRow.DataBoundItem as Artikli;
            FrmDodajIliAžurirajHranu frm = new FrmDodajIliAžurirajHranu(artikli);
            frm.ShowDialog();
            Popuni();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvHrana.CurrentRow != null)
            {
                Artikli odabrani = dgvHrana.CurrentRow.DataBoundItem as Artikli;
                if (odabrani != null)
                {
                    hrana.ObrisiHranu(odabrani);

                }

            }
            Popuni();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Popuni();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (cmbTipHrane.SelectedIndex == 0)
            {
                dgvHrana.DataSource = hrana.SortirajHranu(1);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 1)
            {
                dgvHrana.DataSource = hrana.SortirajHranu(4);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 2)
            {
                dgvHrana.DataSource = hrana.SortirajHranu(5);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipHrane.SelectedIndex == 0)
            {
                dgvHrana.DataSource = hrana.PretraziHranu(1, txtPretraga.Text);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 1)
            {
                dgvHrana.DataSource = hrana.PretraziHranu(4, txtPretraga.Text);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }

            else if (cmbTipHrane.SelectedIndex == 2)
            {
                dgvHrana.DataSource = hrana.PretraziHranu(1, txtPretraga.Text);
                dgvHrana.Columns[4].Visible = false;
                dgvHrana.Columns[5].Visible = false;
                dgvHrana.Columns[6].Visible = false;
                dgvHrana.Columns[7].Visible = false;
                dgvHrana.Columns[8].Visible = false;

            }
        }

        private void FrmHrana_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmHrana.htm");
        }
    }
}
