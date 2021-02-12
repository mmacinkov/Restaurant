using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam
{
    public partial class FrmDodajIliAžurirajZaposlenika : Form
    {
        Korisnik odabrani;
        Klase.Zaposlenik zaposlenik = new Klase.Zaposlenik();
        public FrmDodajIliAžurirajZaposlenika()
        {
            InitializeComponent();
        }

        public FrmDodajIliAžurirajZaposlenika(Korisnik korisnik)
        {
            InitializeComponent();
            odabrani = korisnik;
        }

        private void PopuniCombo()
        {
            using (var db = new NjamiNjamEntities())
            {
                var query = from u in db.Uloga
                            select u;
                foreach (var item in query.ToList())
                {
                    cmbUloga.Items.Add(item);
                }

                var query2 = from s in db.Status_korisnika
                             select s;
                foreach (var item in query2.ToList())
                {
                    cmbStatus.Items.Add(item);
                }

            }
        }

        private void FrmDodajIliAžurirajZaposlenika_Load(object sender, EventArgs e)
        {
            PopuniCombo();

            if (odabrani != null)
            {
                txtIme.Text = odabrani.Ime;
                txtPrezime.Text = odabrani.Prezime;
                txtAdresa.Text = odabrani.Adresa;
                txtBrojTelefona.Text = odabrani.Broj_telefona;
                txtEmail.Text = odabrani.Email;
                txtKorIme.Text = odabrani.Korisnicko_ime;
                txtLozinka.Text = odabrani.Lozinka;
                cmbUloga.SelectedItem = odabrani.vk_uloga;
                cmbStatus.SelectedItem = odabrani.vk_status;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            Uloga uloga = cmbUloga.SelectedItem as Uloga;
            Status_korisnika status = cmbStatus.SelectedItem as Status_korisnika;
            if (txtLozinka.Text == "" || txtAdresa.Text == "" || txtBrojTelefona.Text == "" || txtEmail.Text == "" || txtIme.Text == "" || txtKorIme.Text == "" || txtPrezime.Text == "" || status == null || uloga == null)
            {
                MessageBox.Show("Morate ispuniti svako polje!");
                this.Hide();
                FrmDodajIliAžurirajZaposlenika frm = new FrmDodajIliAžurirajZaposlenika();
                frm.ShowDialog();
            }
            else if (odabrani == null)
            {
                zaposlenik.DodajNovogZaposlenika(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtBrojTelefona.Text, txtEmail.Text, txtKorIme.Text, txtLozinka.Text, uloga.ID, status.ID);
            }
            else
            {
                zaposlenik.AzurirajZaposlenika(odabrani, txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtBrojTelefona.Text, txtEmail.Text, txtKorIme.Text, txtLozinka.Text, uloga.ID, status.ID);
            }
            Close();
        }

        private void txtKorIme_Leave(object sender, EventArgs e)
        {

            if (txtKorIme.Text == "")
            {
                txtKorIme.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (zaposlenik.ProvjeriDostupnostKorImena(txtKorIme.Text).Count() == 1)
            {
                MessageBox.Show("Korisničko ime koje pokušavate unijeti već postoji u bazi!");
                txtKorIme.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (zaposlenik.ProvjeriDostupnostKorImena(txtKorIme.Text).Count() == 0)
            {
                txtKorIme.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtLozinka_Leave(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Length < 7)
            {
                txtLozinka.BackColor = Color.Red;
                MessageBox.Show("Lozinka mora imati minimalno 7 znakova!");
                btnUredu.Enabled = false;
            }
            else
            {
                txtLozinka.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (zaposlenik.ProvjeraEmaila(txtEmail.Text) == false)
            {
                MessageBox.Show("Unesite ispravan e-mail!");
                txtEmail.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else
            {
                var mail = new System.Net.Mail.MailAddress(txtEmail.Text);
                txtEmail.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            if (txtIme.Text == "")
            {
                txtIme.BackColor = Color.Red;
            }
            else if (txtIme.Text != "" && Char.IsUpper(txtIme.Text, 0) == false)
            {
                MessageBox.Show("Ime mora imati prvo slovo veliko!");
                txtIme.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else
            {
                txtIme.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            if (txtPrezime.Text == "")
            {
                txtPrezime.BackColor = Color.Red;
            }
            else if (txtPrezime.Text != "" && zaposlenik.ProvjeriVelikoPocetnoSlovo(txtPrezime.Text, 0) == false)
            {
                MessageBox.Show("Prezime mora imati prvo slovo veliko!");
                txtPrezime.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else
            {
                txtPrezime.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }
    }
}
