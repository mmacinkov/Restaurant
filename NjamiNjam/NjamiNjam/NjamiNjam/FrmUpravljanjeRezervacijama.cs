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
    public partial class FrmUpravljanjeRezervacijama : Form
    {
        
        private Rezervacija odabranaRezervacija;

        public FrmUpravljanjeRezervacijama()
        {
            InitializeComponent();
            
            
        }
        public FrmUpravljanjeRezervacijama(Rezervacija r)
        {
            InitializeComponent();
            odabranaRezervacija = r;

          
        }
       

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Klase.UpravljanjeRezervacijom rezervacije = new Klase.UpravljanjeRezervacijom();
            if (tbBrojGostiju.Text=="" || tbBrojStola.Text=="" || tbOpis.Text=="" || dateTimePicker1.Text=="")
            {
                MessageBox.Show("Sva polja moraju biti puna", "Upozorenje");
            }
            else
            {
                if (odabranaRezervacija == null)
                {
                    rezervacije.DodajRezervaciju(tbOpis.Text, int.Parse(tbBrojGostiju.Text), int.Parse(tbBrojStola.Text), DateTime.Parse(dateTimePicker1.Text), PrijavljeniKorisnik.IDKorisnik);
                }
                else
                {
                    rezervacije.AzurirajRezervaciju(odabranaRezervacija, tbOpis.Text, int.Parse(tbBrojGostiju.Text), int.Parse(tbBrojStola.Text), DateTime.Parse(dateTimePicker1.Text), PrijavljeniKorisnik.IDKorisnik);
                }
                Close();
            }
        }

        private void FrmUpravljanjeRezervacijama_Load(object sender, EventArgs e)
        {
            if (odabranaRezervacija!=null)
            {
                tbBrojGostiju.Text = odabranaRezervacija.Broj_gostiju.ToString();
                tbBrojStola.Text = odabranaRezervacija.Broj_stola.ToString();
                tbOpis.Text = odabranaRezervacija.Opis;
                dateTimePicker1.Text = odabranaRezervacija.Datum.ToString();
            }
        }
    }
}
