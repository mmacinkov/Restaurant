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
    public partial class FrmPonovanIspisRacuna : Form
    {
        public Racun odabraniRacun;
        public FrmPonovanIspisRacuna(Racun racun)
        {
            InitializeComponent();
            odabraniRacun = racun;
        }

        private void FrmPonovanIspisRacuna_Load(object sender, EventArgs e)
        {

            using (var db = new NjamiNjamEntities())
            {
                var upit = from st in db.Stavke_racuna
                           join r in db.Racun on st.vk_racun equals odabraniRacun.ID
                           select new { st.Artikli.ID, st.Artikli.Naziv, st.Artikli.Cijena, st.Racun.Popust, st.Kolicina };

                dataTable1BindingSource.DataSource = upit.Distinct().ToList();

                var upit2 = from r in db.Racun
                            where r.ID == odabraniRacun.ID
                            select r;
                RacunBindingSource.DataSource = upit2.ToList();
              
            }


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
