using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NjamiNjam.Klase
{
    public class SpecijalnaPonuda
    {
        public List<Artikli> DohvatiSpecijalnuPonudu(int tip)
        {
            List<Artikli> listaArtikala;
            using (var db = new NjamiNjamEntities())
            {
                var query = from a in db.Artikli
                            where a.vk_tip == tip
                            select a;
                listaArtikala = new List<Artikli>(query.ToList());

            }
            return listaArtikala;
        }

        public void ObrisiSpecijalnuPonudu(Artikli odabrani)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Artikli.Attach(odabrani);
                db.Artikli.Remove(odabrani);
                db.SaveChanges();
            }
        }

        public List<Artikli> SortirajSpecijalnuPonudu(int tip)
        {
            List<Artikli> listaArtikala;
            using (var db = new NjamiNjamEntities())
            {
                var query = from a in db.Artikli
                            where a.vk_tip == tip
                            orderby a.Naziv
                            select a;
                listaArtikala = new List<Artikli>(query.ToList());

            }
            return listaArtikala;
        }

        public List<Artikli> PretraziSpecijalnuPonudu(int tip, string pretraga)
        {
            List<Artikli> listaArtikala;
            using (var db = new NjamiNjamEntities())
            {
                var query = from a in db.Artikli
                            where a.vk_tip == tip && a.Naziv.Contains(pretraga)
                            select a;
                listaArtikala = new List<Artikli>(query.ToList());

            }
            return listaArtikala;
        }

        public void DodajSpecijalnuPonudu(string naziv, decimal cijena, int kolicina, DateTime vrijedi_od, DateTime vrijeme_do, int vkTip)
        {
            using (var db = new NjamiNjamEntities())
            {
                Artikli artikli = new Artikli
                {
                    Naziv = naziv,
                    Cijena = cijena,
                    Kolicina = kolicina,
                    Vrijedi_od = vrijedi_od,
                    Vrijedi_do = vrijeme_do,
                    vk_tip = vkTip
                };
                db.Artikli.Add(artikli);
                db.SaveChanges();
            }
        }

        public void AzurirajSpecijalnuPonudu(Artikli odabrani, string naziv, decimal cijena, int kolicina, DateTime vrijedi_od, DateTime vrijeme_do)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Artikli.Attach(odabrani);
                odabrani.Naziv = naziv;
                odabrani.Cijena = cijena;
                odabrani.Kolicina = kolicina;
                odabrani.Vrijedi_od = vrijedi_od;
                odabrani.Vrijedi_do = vrijeme_do;
                db.SaveChanges();
            }
        }

        public List<Artikli> ProvjeriDostupnostNaziva(string naziv)
        {
            List<Artikli> lista;
            using (var db = new NjamiNjamEntities())
            {
                var provjera = from a in db.Artikli
                               where a.Naziv == naziv
                               select a;
                lista = new List<Artikli>(provjera.ToList());
            }
            return lista;

        }
    }
}
