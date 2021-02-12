using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam
{
    public partial class FrmKreiranjeNovogRasporeda : Form
    {
        Klase.RasporedRada rasporedRada = new Klase.RasporedRada();

        public FrmKreiranjeNovogRasporeda()
        {
            InitializeComponent();
            PopuniComboBox();
        }

        private void PopuniComboBox()
        {
            using (var db = new NjamiNjamEntities())
            {
                var upit = from k in db.Korisnik
                           select k;

                foreach (var item in upit.Distinct().ToList())
                {
                    cmbKorisnik.Items.Add(item);
                }
            }
        }
    
        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbPotvrdi_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(dtpOd.Text) >= DateTime.Parse(dtpDo.Text))
            {
                MessageBox.Show("Unesite ispravne datume!", "Pogreška", MessageBoxButtons.OK);
            }
            else if (txtPon.Text == "" || txtUto.Text == "" ||
                     txtSri.Text == "" || txtCet.Text == "" ||
                     txtPet.Text == "" || txtSub.Text == "" ||
                     txtNed.Text == "")
            {
                MessageBox.Show("Popunite polja za unos!", "Pogreška", MessageBoxButtons.OK);
            }
            else if (Regex.IsMatch(txtBrojSati.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Unesite ispravnu vrijednostu polje broj sati!", "Pogreška", MessageBoxButtons.OK);
            }
            else if (int.Parse(txtBrojSati.Text) < 0)
            {
                MessageBox.Show("Unesite broj veći od 0!", "Pogreška", MessageBoxButtons.OK);
            }
            else
            {
                Korisnik korisnik = cmbKorisnik.SelectedItem as Korisnik;
                rasporedRada.KreirajRaspored(DateTime.Parse(dtpOd.Text),
                                             DateTime.Parse(dtpDo.Text),
                                             txtPon.Text,
                                             txtUto.Text,
                                             txtSri.Text,
                                             txtCet.Text,
                                             txtPet.Text,
                                             txtSub.Text,
                                             txtNed.Text,
                                             int.Parse(txtBrojSati.Text),
                                             korisnik);
                Close();
            }           
        }

        private void FrmKreiranjeNovogRasporeda_Load(object sender, EventArgs e)
        {
            txtBrojSati.Text = 0.ToString();
            cmbKorisnik.SelectedIndex = 0;
        }
    }
}