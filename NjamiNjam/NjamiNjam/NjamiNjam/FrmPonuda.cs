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
    public partial class FrmPonuda : Form
    {
        public FrmPonuda()
        {
            InitializeComponent();
        }

        private void btnHrana_Click(object sender, EventArgs e)
        {
            FrmHrana frm = new FrmHrana();
            frm.ShowDialog();
        }

        private void btnPice_Click(object sender, EventArgs e)
        {
            FrmPice frm = new FrmPice();
            frm.ShowDialog();
        }

        private void btnBrziArtikli_Click(object sender, EventArgs e)
        {
            FrmBrziArtikli frm = new FrmBrziArtikli();
            frm.ShowDialog();
        }

        private void btnSpecijalnaPonuda_Click(object sender, EventArgs e)
        {
            FrmSpecijalnaPonuda frm = new FrmSpecijalnaPonuda();
            frm.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPonuda_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmPonuda.htm");
        }
    }
}
