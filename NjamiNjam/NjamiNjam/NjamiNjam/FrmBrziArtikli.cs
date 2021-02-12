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
    public partial class FrmBrziArtikli : Form
    {
        Klase.BrziArtikl brziArtikl = new Klase.BrziArtikl();
        public FrmBrziArtikli()
        {
            InitializeComponent();
        }

        private void FrmBrziArtikli_Load(object sender, EventArgs e)
        {
            PrikaziBrzeArtikle();
        }

        private void PrikaziBrzeArtikle()
        {
            dgvBrziArtikli.DataSource = brziArtikl.DohvatiBrziArtikl(10);
            dgvBrziArtikli.Columns[4].Visible = false;
            dgvBrziArtikli.Columns[5].Visible = false;
            dgvBrziArtikli.Columns[6].Visible = false;
            dgvBrziArtikli.Columns[7].Visible = false;
            dgvBrziArtikli.Columns[8].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajIliAžurirajBrzeArtikle frm = new FrmDodajIliAžurirajBrzeArtikle();
            frm.ShowDialog();
            PrikaziBrzeArtikle();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            Artikli artikli = dgvBrziArtikli.CurrentRow.DataBoundItem as Artikli;
            FrmDodajIliAžurirajBrzeArtikle frm = new FrmDodajIliAžurirajBrzeArtikle(artikli);
            frm.ShowDialog();
            PrikaziBrzeArtikle();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvBrziArtikli.CurrentRow != null)
            {
                Artikli odabrani = dgvBrziArtikli.CurrentRow.DataBoundItem as Artikli;
                if (odabrani != null)
                {
                    brziArtikl.ObrisiBrziArtikl(odabrani);

                }
            }
            PrikaziBrzeArtikle();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PrikaziBrzeArtikle();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            dgvBrziArtikli.DataSource = brziArtikl.SortirajBrziArtikli(10);
            dgvBrziArtikli.Columns[4].Visible = false;
            dgvBrziArtikli.Columns[5].Visible = false;
            dgvBrziArtikli.Columns[6].Visible = false;
            dgvBrziArtikli.Columns[7].Visible = false;
            dgvBrziArtikli.Columns[8].Visible = false;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            dgvBrziArtikli.DataSource = brziArtikl.PretraziBrziArtikl(10, txtPretraga.Text);
            dgvBrziArtikli.Columns[4].Visible = false;
            dgvBrziArtikli.Columns[5].Visible = false;
            dgvBrziArtikli.Columns[6].Visible = false;
            dgvBrziArtikli.Columns[7].Visible = false;
            dgvBrziArtikli.Columns[8].Visible = false;
        }

        private void FrmBrziArtikli_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmBrziArtikl.htm");

        }
    }
}
