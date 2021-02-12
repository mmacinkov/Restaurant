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
    public partial class FrmRasporedRadaKorisnik : Form
    {
        Klase.RasporedRada rasporedRada = new Klase.RasporedRada();
        int korisnikId = PrijavljeniKorisnik.IDKorisnik;

        public FrmRasporedRadaKorisnik()
        {
            InitializeComponent();
        }     

        private void FrmRasporedRadaKorisnik_Load(object sender, EventArgs e)
        {
            dgvRasporedRada.DataSource = rasporedRada.DohvatiRasporedRada(korisnikId);

            dgvRasporedRada.Columns[12].Visible = false;

            if (dgvRasporedRada.RowCount == 0)
            {
                MessageBox.Show("Trenutno ne postoji raspored rada za vas!", "Obavijest", MessageBoxButtons.OK);
                Close();
            }
        }

        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRasporedRadaKorisnik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Otvorili ste prozor za pomoć!");
            var putanja = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, "file://" + putanja + "\\Helper.chm", HelpNavigator.Topic, "FrmRasporedRada.htm");
        }
    }
}