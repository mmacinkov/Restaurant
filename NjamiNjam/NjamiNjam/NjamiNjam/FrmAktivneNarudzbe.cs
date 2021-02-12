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
    public partial class FrmAktivneNarudzbe : Form
    {
        int brojStola;
        string imeStola;

        public FrmAktivneNarudzbe(int broj, string ime)
        {
            InitializeComponent();
            brojStola = broj;
            imeStola = ime;
        }

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbPregled_Click(object sender, EventArgs e)
        {
            FrmPregledStola forma = new FrmPregledStola(brojStola);
            forma.ShowDialog();
        }

        private void FrmAktivneNarudzbe_Load(object sender, EventArgs e)
        {
            lblStol.Text = imeStola.ToString();
        }

        private void gumbDodavanjeRacuna_Click(object sender, EventArgs e)
        {
            FrmDodavanjeRacuna forma = new FrmDodavanjeRacuna(brojStola);
            forma.ShowDialog();
        }

        private void IspisRacuna_Click(object sender, EventArgs e)
        {
            FrmIspisRacuna forma = new FrmIspisRacuna(brojStola);
            forma.ShowDialog();
        }

        private void FrmAktivneNarudzbe_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmRadSAktivnim.htm");
        }
    }
}