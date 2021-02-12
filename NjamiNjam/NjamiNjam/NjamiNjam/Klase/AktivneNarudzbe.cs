using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjamiNjam.Klase
{
   public class AktivneNarudzbe
    {
        public List<Racun> PopuniRacune(int brojStola)
        {
            List<Racun> listaRacuna = new List<Racun>();
            int stol = brojStola + 1;

            using (var db = new NjamiNjamEntities())
            {
                var upit = from r in db.Racun
                           where r.Broj_stola == stol && r.vk_status == 1
                           select r;

                listaRacuna = upit.ToList();
            }

            return listaRacuna;
        }

        public List<Stavke_racuna> PopuniStavke(Racun odabraniRacun)
        {
            List<Stavke_racuna> listaStavki = new List<Stavke_racuna>();

            if (odabraniRacun != null)
            {
                using (var db = new NjamiNjamEntities())
                {
                    var upit = from s in db.Stavke_racuna
                               where s.vk_racun == odabraniRacun.ID
                               select s;

                    listaStavki = upit.ToList();
                }              
            }

            return listaStavki;
        }

        public List<Artikli> PopuniArtikle()
        {
            List<Artikli> listaArtikala = new List<Artikli>();

            using (var db = new NjamiNjamEntities())
            {
                var upit = from a in db.Artikli
                           select a;

                listaArtikala = upit.ToList();
            }

            return listaArtikala;
        }

        public void PromijeniStatus(Racun odabraniRacun)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Racun.Attach(odabraniRacun);
                odabraniRacun.vk_status = 4;
                db.SaveChanges();
            }
        }

        public List<Artikli> PretragaTekst(string tekst)
        {
            List<Artikli> listaArtikala = new List<Artikli>();

            using (var db = new NjamiNjamEntities())
            {
                var upit = from a in db.Artikli
                           where a.Naziv.Contains(tekst)
                           select a;

                listaArtikala = upit.ToList();
            }

            return listaArtikala;
        }

        public List<Artikli> Vrsta(Tip odabraniTip)
        {
            List<Artikli> listaArtikala = new List<Artikli>();

            using (var db = new NjamiNjamEntities())
            {
                var upit = from a in db.Artikli
                           where a.vk_tip == odabraniTip.ID
                           select a;

                listaArtikala = upit.ToList();
            }

            return listaArtikala;         
        }

        public void DodavanjeArtikalaNaRacun(Racun odabraniRacun, Artikli odabraniArtikl)
        {
            using (var db = new NjamiNjamEntities())
            {
                var upit = from s in db.Stavke_racuna
                           where odabraniRacun.ID == s.vk_racun
                           select s;

                foreach (var item in upit.Distinct().ToList())
                {
                    if (item.vk_artikl == odabraniArtikl.ID)
                    {
                        db.Stavke_racuna.Attach(item);
                        item.Kolicina++;
                        db.SaveChanges();

                        db.Artikli.Attach(odabraniArtikl);
                        odabraniArtikl.Kolicina--;
                        db.SaveChanges();
                        AzuriranjeRacuna(odabraniRacun, odabraniArtikl);
                        return;
                    }
                }

                Stavke_racuna stavke = new Stavke_racuna
                {
                    vk_racun = odabraniRacun.ID,
                    vk_artikl = odabraniArtikl.ID,
                    Kolicina = 1
                };

                db.Stavke_racuna.Add(stavke);
                db.SaveChanges();

                db.Artikli.Attach(odabraniArtikl);
                odabraniArtikl.Kolicina--;
                db.SaveChanges();
                AzuriranjeRacuna(odabraniRacun, odabraniArtikl);
            }
        }

        private void AzuriranjeRacuna(Racun odabraniRacun, Artikli odabraniArtikl)
        {
            decimal popust = odabraniRacun.Popust;

            if (popust <= 0)
            {
                using (var db = new NjamiNjamEntities())
                {
                    db.Racun.Attach(odabraniRacun);
                    odabraniRacun.Cijena += odabraniArtikl.Cijena - (odabraniArtikl.Cijena * (popust / 100));
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new NjamiNjamEntities())
                {
                    db.Racun.Attach(odabraniRacun);
                    odabraniRacun.Cijena += odabraniArtikl.Cijena - (odabraniArtikl.Cijena * (popust / 100));
                    db.SaveChanges();
                }
            }
        }

        public void UkloniStavku(Stavke_racuna odabranaStavka, Racun odabraniRacun)
        {
            decimal popust = odabraniRacun.Popust;

            if (odabranaStavka != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    if (odabranaStavka.Kolicina == 1)
                    {
                        using (var db = new NjamiNjamEntities())
                        {

                            db.Stavke_racuna.Attach(odabranaStavka);
                            if (popust > 0)
                            {
                                odabranaStavka.Racun.Cijena = odabranaStavka.Racun.Cijena - odabranaStavka.Artikli.Cijena + (odabranaStavka.Artikli.Cijena * popust/100);
                                db.SaveChanges();
                            }
                            else
                            {
                                odabranaStavka.Racun.Cijena -= odabranaStavka.Artikli.Cijena;
                                db.SaveChanges();
                            }

                            db.Stavke_racuna.Attach(odabranaStavka);
                            odabranaStavka.Artikli.Kolicina++;
                            db.SaveChanges();

                            db.Stavke_racuna.Attach(odabranaStavka);
                            db.Stavke_racuna.Remove(odabranaStavka);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        using (var db = new NjamiNjamEntities())
                        {
                            db.Stavke_racuna.Attach(odabranaStavka);
                            odabranaStavka.Kolicina--;
                            db.SaveChanges();

                            db.Racun.Attach(odabranaStavka.Racun);
                            if (popust > 0)
                            {
                                odabranaStavka.Racun.Cijena = odabranaStavka.Racun.Cijena - odabranaStavka.Artikli.Cijena + (odabranaStavka.Artikli.Cijena * popust / 100);
                                db.SaveChanges();
                            }
                            else
                            {
                                odabranaStavka.Racun.Cijena -= odabranaStavka.Artikli.Cijena;
                                db.SaveChanges();
                            }
                            db.SaveChanges();

                            db.Artikli.Attach(odabranaStavka.Artikli);
                            odabranaStavka.Artikli.Kolicina++;
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        public void KreirajRacun(int brojStola, Nacin_placanja odabraniNacin, int popust)
        {
            int zeljeniStol = brojStola + 1;

            using (var db = new NjamiNjamEntities())
            {
                Racun racun = new Racun
                {
                    Broj_stola = zeljeniStol,
                    Vrijeme = DateTime.Now,
                    Cijena = 0,
                    Popust = popust,
                    vk_korisnik = PrijavljeniKorisnik.IDKorisnik,
                    vk_nacin = odabraniNacin.ID,
                    vk_status = 1
                };
                db.Racun.Add(racun);
                db.SaveChanges();
            }
        }
    }
}