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
    public partial class FrmAzuriranjeRasporeda : Form
    {
        Klase.RasporedRada rasporedRada = new Klase.RasporedRada();
        Tjedni_raspored odabraniRaspored;

        public FrmAzuriranjeRasporeda(Tjedni_raspored odabir)
        {
            InitializeComponent();
            odabraniRaspored = odabir;
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

        private void gumbSpremi_Click(object sender, EventArgs e)
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
                rasporedRada.IzmjeniRaspored(odabraniRaspored,
                                             DateTime.Parse(dtpOd.Text),
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

        private void FrmAzuriranjeRasporeda_Load(object sender, EventArgs e)
        {
            if (odabraniRaspored != null)
            {
                dtpOd.Text = odabraniRaspored.Datum_od.ToString();
                dtpDo.Text = odabraniRaspored.Datum_do.ToString();
                txtPon.Text = odabraniRaspored.Pon;
                txtUto.Text = odabraniRaspored.Uto;
                txtSri.Text = odabraniRaspored.Sri;
                txtCet.Text = odabraniRaspored.Cet;
                txtPet.Text = odabraniRaspored.Pet;
                txtSub.Text = odabraniRaspored.Sub;
                txtNed.Text = odabraniRaspored.Ned;
                txtBrojSati.Text = odabraniRaspored.Broj_sati.ToString();
                cmbKorisnik.SelectedIndex = 0;
            }
        }
    }
}