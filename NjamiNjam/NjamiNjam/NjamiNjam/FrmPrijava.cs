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
    public partial class FrmPrijava : Form
    {
        int brojPokusaja = 0;

        public FrmPrijava()
        {
            InitializeComponent();
            labelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            labelLozinka.BackColor= System.Drawing.Color.Transparent;
            checkBoxLozinka.BackColor = Color.Transparent;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            ProvjeriPostojanost();
            
        }
        public void ProvjeriPostojanost()
        {

            using (var db = new NjamiNjamEntities())
            {
                var upit = from k in db.Korisnik select k;

                Korisnik korisnik = upit.ToList().FirstOrDefault(k => k.Korisnicko_ime == tbKorisnickoIme.Text && k.Lozinka == tbLozinka.Text);
                Korisnik korisnik2 = upit.ToList().FirstOrDefault(k => k.Korisnicko_ime == tbKorisnickoIme.Text);

                if (tbKorisnickoIme.Text != "" || tbLozinka.Text != "")
                {
                    if (korisnik != null)
                    {
                        if (tbKorisnickoIme.Text == korisnik.Korisnicko_ime && tbLozinka.Text == korisnik.Lozinka && korisnik.Status_korisnika.ID != 2)
                        {
                            PrijavljeniKorisnik.IDKorisnik = korisnik.ID;
                            PrijavljeniKorisnik.KorisnickoIme = korisnik.Korisnicko_ime;
                            PrijavljeniKorisnik.Uloga = korisnik.vk_uloga;

                            Hide();
                            FrmNjamiNjam frmNjami = new FrmNjamiNjam();
                            this.Hide();
                            frmNjami.ShowDialog();

                        }

                        if (korisnik.Status_korisnika.ID == 2 || korisnik2.Status_korisnika.ID==2)
                        {
                            MessageBox.Show("Korisnik je neaktivan", "Greška", MessageBoxButtons.OK);
                        }

                    }
                    else if (korisnik2!= null)
                    {
                        if (tbKorisnickoIme.Text == korisnik2.Korisnicko_ime && tbLozinka.Text != korisnik2.Lozinka)
                        {

                            MessageBox.Show("Kombinacija korisničkog imena i lozinke je neispravna! Pokušajte ponovno! Imate još " + (3 - brojPokusaja) + " pokušaja", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            brojPokusaja++;
                            db.Korisnik.Attach(korisnik2);
                            tbLozinka.Text = "";
                            if (brojPokusaja > 3)
                            {
                                MessageBox.Show("Nemate više pravo na prijavu!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                korisnik = korisnik2;

                                korisnik.vk_status = 2;
                                db.SaveChanges();
                                btnPrijava.Enabled = false;

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Kombinacija korisničkog imena i lozinke je neispravna!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                
                }
                else
                {

                    MessageBox.Show("Niste unijeli korisničko ime i lozinku!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tbKorisnickoIme.Text = "";
                    tbLozinka.Text = "";
                }



            }
           



        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tbKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            if (btnPrijava.Enabled==false)
            {
                btnPrijava.Enabled = true;

            }
        }

        private void checkBoxLozinka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLozinka.Checked)
            {
                tbLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbLozinka.UseSystemPasswordChar = true;
            }
        }
    }
}
