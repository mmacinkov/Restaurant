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
    public partial class FrmPice : Form
    {
        Klase.Piće pice = new Klase.Piće();
        public FrmPice()
        {
            InitializeComponent();
        }

        private void Popuni()
        {
            if (cmbTipPica.SelectedIndex == 0)
            {
                dgvPice.DataSource = pice.DohvatiPice(7);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 1)
            {
                dgvPice.DataSource = pice.DohvatiPice(8);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 2)
            {
                dgvPice.DataSource = pice.DohvatiPice(9);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }
        }

        private void cmbTipPica_SelectedIndexChanged(object sender, EventArgs e)
        {
            Popuni();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajIliAžurirajPiće frm = new FrmDodajIliAžurirajPiće();
            frm.ShowDialog();
            Popuni();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            Artikli artikli = dgvPice.CurrentRow.DataBoundItem as Artikli;
            FrmDodajIliAžurirajPiće frm = new FrmDodajIliAžurirajPiće(artikli);
            frm.ShowDialog();
            Popuni();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgvPice.CurrentRow != null)
            {
                Artikli odabrani = dgvPice.CurrentRow.DataBoundItem as Artikli;
                if (odabrani != null)
                {
                    pice.ObrisiPice(odabrani);

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
            if (cmbTipPica.SelectedIndex == 0)
            {
                dgvPice.DataSource = pice.SortirajPice(7);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 1)
            {
                dgvPice.DataSource = pice.SortirajPice(8);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 2)
            {
                dgvPice.DataSource = pice.SortirajPice(9);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipPica.SelectedIndex == 0)
            {
                dgvPice.DataSource = pice.PretraziPice(7, txtPretraga.Text);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 1)
            {
                dgvPice.DataSource = pice.PretraziPice(8, txtPretraga.Text);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }

            else if (cmbTipPica.SelectedIndex == 2)
            {
                dgvPice.DataSource = pice.PretraziPice(9, txtPretraga.Text);
                dgvPice.Columns[4].Visible = false;
                dgvPice.Columns[5].Visible = false;
                dgvPice.Columns[6].Visible = false;
                dgvPice.Columns[7].Visible = false;
                dgvPice.Columns[8].Visible = false;
            }
        }

        private void FrmPice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmPice.htm");
        }
    }
}
