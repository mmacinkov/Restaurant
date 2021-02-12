using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam.Klase
{
    public class RasporedRada
    {       
        public List<Tjedni_raspored> DohvatiRasporedRada(int korisnickiID)
        {
            List<Tjedni_raspored> listaRaspored = new List<Tjedni_raspored>();

            using (var db = new NjamiNjamEntities())
            {
                var upit = from t in db.Tjedni_raspored
                           where t.vk_korisnik == korisnickiID
                           select t;

                listaRaspored = upit.ToList();                          
            }
            return listaRaspored;
        }

        public List<Tjedni_raspored> DohvatiRasporedRadaSve()
        {
            List<Tjedni_raspored> listaRaspored = new List<Tjedni_raspored>();

            using (var db = new NjamiNjamEntities())
            {
                var upit = from t in db.Tjedni_raspored
                           select t;

                listaRaspored = upit.ToList();
            }

            return listaRaspored;
        }

        public void ObrisiRaspored(Tjedni_raspored odabraniRaspored)
        {           
            if (odabraniRaspored != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new NjamiNjamEntities())
                    {
                        db.Tjedni_raspored.Attach(odabraniRaspored);
                        db.Tjedni_raspored.Remove(odabraniRaspored);
                        db.SaveChanges();
                    }                   
                }
            }
        }

        public void KreirajRaspored(DateTime datumOd,
                                    DateTime datumDo,
                                    string pon,
                                    string uto,
                                    string sri,
                                    string cet,
                                    string pet,
                                    string sub,
                                    string ned,
                                    int brojSati,
                                    Korisnik korisnik)
        {
            using (var db = new NjamiNjamEntities())
            {
                Tjedni_raspored raspored = new Tjedni_raspored
                {
                    Datum_od = datumOd,
                    Datum_do = datumDo,
                    Pon = pon,
                    Uto = uto,
                    Sri = sri,
                    Cet = cet,
                    Pet = pet,
                    Sub = sub,
                    Ned = ned,
                    Broj_sati = brojSati,
                    vk_korisnik = korisnik.ID
                };
                db.Tjedni_raspored.Add(raspored);
                db.SaveChanges();
            }
        }

        public void IzmjeniRaspored(Tjedni_raspored odabraniRaspored,
                                    DateTime datumOd, 
                                    DateTime datumDo,
                                    string pon,
                                    string uto,
                                    string sri,
                                    string cet,
                                    string pet,
                                    string sub,
                                    string ned,
                                    int brojSati,
                                    Korisnik korisnik)
        {
            if (odabraniRaspored != null)
            {
                using (var db = new NjamiNjamEntities())
                {
                    db.Tjedni_raspored.Attach(odabraniRaspored);
                    odabraniRaspored.Datum_od = datumOd;
                    odabraniRaspored.Datum_do = datumDo;
                    odabraniRaspored.Pon = pon;
                    odabraniRaspored.Uto = uto;
                    odabraniRaspored.Sri = sri;
                    odabraniRaspored.Cet = cet;
                    odabraniRaspored.Pet = pet;
                    odabraniRaspored.Sub = sub;
                    odabraniRaspored.Ned = ned;
                    odabraniRaspored.Broj_sati = brojSati;
                    odabraniRaspored.vk_korisnik = korisnik.ID;
                    db.SaveChanges();
                }
            }            
        }
    }
}