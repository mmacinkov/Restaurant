using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam.Klase
{
    public class DohvacanjeRacuna
    {
        public List<Racun> listaRacuna;


        public List<Racun> DohvatiDanasnjeRacune()
        {
            using (var db = new NjamiNjamEntities())
            {
                var danasnjiDatum = DateTime.Today;
                
                var dohvaceniRacuni = from r in db.Racun
                                      where r.Status_racuna.ID == 4 && r.Vrijeme.Day == danasnjiDatum.Day && r.Vrijeme.Month == danasnjiDatum.Month
                  && r.Vrijeme.Year == danasnjiDatum.Year
                                      select r;  //PROMINI NA 4

                listaRacuna = new List<Racun>(dohvaceniRacuni.ToList());
            }

            return listaRacuna;
        }
        public List<Racun> DohvatiRacuneNaODredenDatum(DateTime odabranoVrijeme)
        {
            using (var db = new NjamiNjamEntities())
            {
                var dohvaceniRacuni = from r in db.Racun
                                      where r.Vrijeme.Day == odabranoVrijeme.Day && r.Vrijeme.Month == odabranoVrijeme.Month && r.Vrijeme.Year == odabranoVrijeme.Year
                   && r.Status_racuna.ID == 4
                                      select r;     //PROMINI NA 4
                listaRacuna = new List<Racun>(dohvaceniRacuni.ToList());

                if (listaRacuna.Count==0)
                {
                    MessageBox.Show("Na odabrani dan ne postoji niti jedan račun!", "Upozorenje" );
                }

            }

            return listaRacuna;
        }
        public void StornirajRacun(Racun odabraniRacun)
        {
            if (odabraniRacun != null)
            {
                using (var db = new NjamiNjamEntities())
                {
                    db.Racun.Attach(odabraniRacun);

                    if (odabraniRacun.Stavke_racuna.Count > 0)
                    {
                        odabraniRacun.Stavke_racuna.Clear();
                    }


                    db.Racun.Remove(odabraniRacun);
                    db.SaveChanges();


                }
            }

        }
        public void PromijeniNacinPlacanja(Racun odabraniRacun)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Racun.Attach(odabraniRacun);
                if (odabraniRacun.vk_nacin == 1)
                {
                    odabraniRacun.vk_nacin = 2;

                }
                else
                {
                    odabraniRacun.vk_nacin = 1;


                }
                db.SaveChanges();

            }

        }

    }
}
