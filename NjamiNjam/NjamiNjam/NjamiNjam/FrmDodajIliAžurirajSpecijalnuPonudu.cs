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
    public partial class FrmDodajIliAžurirajSpecijalnuPonudu : Form
    {
        Artikli odabrani;
        Klase.SpecijalnaPonuda specijalna = new Klase.SpecijalnaPonuda();
        public FrmDodajIliAžurirajSpecijalnuPonudu()
        {
            InitializeComponent();
        }

        public FrmDodajIliAžurirajSpecijalnuPonudu(Artikli artikli)
        {
            InitializeComponent();
            odabrani = artikli;
        }

        private void FrmDodajIliAžurirajSpecijalnuPonudu_Load(object sender, EventArgs e)
        {
            
            if (odabrani != null)
            {
                txtCijena.Focus();
                txtNaziv.Text = odabrani.Naziv;
                txtCijena.Text = odabrani.Cijena.ToString();
                txtKolicina.Text = odabrani.Kolicina.ToString();
                txtVrijediOd.Text = odabrani.Vrijedi_od.ToString();
                txtVrijediDo.Text = odabrani.Vrijedi_do.ToString();
                
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtCijena.Text == "" || txtKolicina.Text == "")
            {
                MessageBox.Show("Morate ispuniti svako polje!");
                this.Hide();
                FrmDodajIliAžurirajSpecijalnuPonudu frm = new FrmDodajIliAžurirajSpecijalnuPonudu();
                frm.ShowDialog();
            }
            
            else if (odabrani == null)
            {
                specijalna.DodajSpecijalnuPonudu(txtNaziv.Text, decimal.Parse(txtCijena.Text), int.Parse(txtKolicina.Text), DateTime.Parse(txtVrijediOd.Text), DateTime.Parse(txtVrijediDo.Text), 6);

            }
            else
            {
                specijalna.AzurirajSpecijalnuPonudu(odabrani, txtNaziv.Text, decimal.Parse(txtCijena.Text), int.Parse(txtKolicina.Text), DateTime.Parse(txtVrijediOd.Text), DateTime.Parse(txtVrijediDo.Text));
            }

            Close();
        }

        

        private void txtCijena_Leave(object sender, EventArgs e)
        {
            if (txtCijena.Text == "")
            {
                txtCijena.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (Regex.IsMatch(txtCijena.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Cijena mora biti decimalni broj!");
                txtCijena.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (decimal.Parse(txtCijena.Text) <= 0)
            {
                MessageBox.Show("Cijena ne smije biti negativna ili jednaka 0!");
                txtCijena.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (decimal.Parse(txtCijena.Text) > 0)
            {
                txtCijena.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtKolicina_Leave(object sender, EventArgs e)
        {
            if (txtKolicina.Text == "")
            {
                txtKolicina.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (Regex.IsMatch(txtKolicina.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Količina mora biti cijeli broj!");
                txtKolicina.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (int.Parse(txtKolicina.Text) < 0)
            {
                MessageBox.Show("Količina ne smije biti manja od 0!");
                txtKolicina.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else if (int.Parse(txtKolicina.Text) > 0)
            {
                txtKolicina.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                txtNaziv.BackColor = Color.Red;
            }
            else if (txtNaziv.Text != "" && Char.IsUpper(txtNaziv.Text, 0) == false)
            {
                MessageBox.Show("Naziv mora imati prvo slovo veliko!");
                txtNaziv.BackColor = Color.Red;
                btnUredu.Enabled = false;
            }
            else
            {
                txtNaziv.BackColor = Color.Green;
                btnUredu.Enabled = true;
            }
        }
    }
}
