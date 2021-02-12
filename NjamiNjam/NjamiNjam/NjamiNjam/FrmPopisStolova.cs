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
    public partial class FrmPopisStolova : Form
    {
        int brojStola;
        string imeStola;

        public FrmPopisStolova()
        {
            InitializeComponent();
        }

        private void gumbOdaberi_Click(object sender, EventArgs e)
        {
            brojStola = cmbStol.SelectedIndex;
            imeStola = cmbStol.SelectedItem.ToString();
            FrmAktivneNarudzbe forma = new FrmAktivneNarudzbe(brojStola, imeStola);
            forma.ShowDialog();
        }

        private void FrmPopisStolova_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmAktivne.htm");
        }

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}