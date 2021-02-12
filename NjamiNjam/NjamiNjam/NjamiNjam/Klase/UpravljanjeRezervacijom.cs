using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam.Klase
{
    public class UpravljanjeRezervacijom
    {
        public List<NjamiNjam.Rezervacija> listaRezervacija;

        public List<NjamiNjam.Rezervacija> DohvatiRezervacije()
        {
            using (var db = new NjamiNjamEntities())
            {
                var danasnjiDatum = DateTime.Today;
                var rezervacije = from r in db.Rezervacija
                                  where r.Datum.Month==danasnjiDatum.Month
                                  && r.Datum.Year== danasnjiDatum.Year
                                  orderby r.Datum ascending
                                  select r;
                listaRezervacija = new List<NjamiNjam.Rezervacija>(rezervacije.ToList());
            }

            
            return listaRezervacija;
        }

        public void DodajRezervaciju(string opis, int brojGostiju, int brojStola, DateTime vrijeme, int IDkorisnika)
        {
            if (brojGostiju<=0 ||brojStola<=0)
            {
                if (brojGostiju<=0)
                {
                    MessageBox.Show("Broj gostiju mora biti veći od 0");

                }
                else
                {
                    MessageBox.Show("Broj stola mora biti veći od 0");
                }
            }
            else
            {
                using (var db = new NjamiNjamEntities())
                {

                    NjamiNjam.Rezervacija novaRez = new NjamiNjam.Rezervacija
                    {
                        Opis = opis,
                        Broj_gostiju = brojGostiju,
                        Broj_stola = brojStola,
                        Datum = vrijeme,
                        vk_korisnik = IDkorisnika,

                    };
                    db.Rezervacija.Add(novaRez);
                    db.SaveChanges();

                }
            }
           


        }
        public void AzurirajRezervaciju(NjamiNjam.Rezervacija odabranaRezervacija, string opis, int brojGostiju, int brojStola, DateTime vrijeme, int IDkorisnika)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Rezervacija.Attach(odabranaRezervacija);
                odabranaRezervacija.Broj_gostiju = brojGostiju;
                odabranaRezervacija.Broj_stola = brojStola;
                odabranaRezervacija.Opis = opis;
                odabranaRezervacija.Datum = vrijeme;
                db.SaveChanges();
            }

        }

        public void ObrisiRezervaciju(NjamiNjam.Rezervacija odabranaRezervacija)
        {

            using (var db = new NjamiNjamEntities())
            {
                db.Rezervacija.Attach(odabranaRezervacija);

                db.Rezervacija.Remove(odabranaRezervacija);
                db.SaveChanges();
            }


        }
        public List<NjamiNjam.Rezervacija> DohvatiRezervacijeNaOdredenDan(DateTime odabranoVrijeme)
        {          

            using (var db = new NjamiNjamEntities())
            {
             

                var rezervacije = from r in db.Rezervacija
                                  where r.Datum.Month == odabranoVrijeme.Month 
                                  && r.Datum.Year == odabranoVrijeme.Year
                                  orderby r.Datum ascending
                                  select r;
                listaRezervacija = new List<NjamiNjam.Rezervacija>(rezervacije.ToList());
            }


            return listaRezervacija;
        }
    }
}
