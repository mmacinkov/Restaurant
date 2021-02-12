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
    public partial class FrmKreirajRacun : Form
    {
        Klase.AktivneNarudzbe aktivneNarudzbe = new Klase.AktivneNarudzbe();
        int brojStola;

        public FrmKreirajRacun(int broj)
        {
            InitializeComponent();
            brojStola = broj;
            PopuniComboBox();
        }
        
        private void PopuniComboBox()
        {
            using (var db = new NjamiNjamEntities())
            {
                var upit = from n in db.Nacin_placanja
                           select n;

                foreach (var item in upit.Distinct().ToList())
                {
                    cmbNacinPlacanja.Items.Add(item);
                }
            }
        }
        
        private void gumbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbKreiraj_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPopust.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Unesite ispravnu vrijednost u polje popust!", "Pogreška", MessageBoxButtons.OK);
            }
            else if (int.Parse(txtPopust.Text) < 0 || int.Parse(txtPopust.Text) > 100)
            {
                MessageBox.Show("Vrijednost popusta mora biti između 0 i 100!", "Pogreška", MessageBoxButtons.OK);
            }
            else
            {
                Nacin_placanja odabraniNacin = cmbNacinPlacanja.SelectedItem as Nacin_placanja;
                aktivneNarudzbe.KreirajRacun(brojStola, odabraniNacin, int.Parse(txtPopust.Text));
                Close();
            }
            
        }

        private void FrmKreirajRacun_Load(object sender, EventArgs e)
        {
            cmbNacinPlacanja.SelectedIndex = 0;
            txtPopust.Text = 0.ToString();
        }
    }
}