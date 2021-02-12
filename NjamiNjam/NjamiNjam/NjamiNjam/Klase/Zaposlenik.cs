using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NjamiNjam.Klase
{
    public class Zaposlenik
    {
        public List<Korisnik> DohvatiSveZaposlenike()
        {
            List<Korisnik> listaZaposlenika;
            using (var db = new NjamiNjamEntities())
            {
                var query = from k in db.Korisnik
                            select k;
                listaZaposlenika = new List<Korisnik>(query.ToList());

            }
            return listaZaposlenika;
        }

        public void DodajNovogZaposlenika(string ime, string prezime, string adresa, string broj_telefona, string email, string korisnicko_ime, string lozinka, int vkUloga, int vkStatus)
        {
            using (var db = new NjamiNjamEntities())
            {
                Korisnik novi = new Korisnik
                {
                    Ime = ime,
                    Prezime = prezime,
                    Adresa = adresa,
                    Broj_telefona = broj_telefona,
                    Email = email,
                    Korisnicko_ime = korisnicko_ime,
                    Lozinka = lozinka,
                    vk_uloga = vkUloga,
                    vk_status = vkStatus
                };
                db.Korisnik.Add(novi);
                db.SaveChanges();
            }


        }

        public void AzurirajZaposlenika(Korisnik odabrani, string ime, string prezime, string adresa, string broj_telefona, string email, string korisnicko_ime, string lozinka, int vkUloga, int vkStatus)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Korisnik.Attach(odabrani);
                odabrani.Ime = ime;
                odabrani.Prezime = prezime;
                odabrani.Adresa = adresa;
                odabrani.Broj_telefona = broj_telefona;
                odabrani.Email = email;
                odabrani.Korisnicko_ime = korisnicko_ime;
                odabrani.Lozinka = lozinka;
                odabrani.vk_uloga = vkUloga;
                odabrani.vk_status = vkStatus;
                db.SaveChanges();

            }
        }

        public void ObrisiZaposlenika(Korisnik odabrani)
        {
            using (var db = new NjamiNjamEntities())
            {
                db.Korisnik.Attach(odabrani);
                db.Korisnik.Remove(odabrani);
                db.SaveChanges();
            }
        }

        public List<Korisnik> SortirajZaposlenike()
        {
            List<Korisnik> listaZaposlenika;
            using (var db = new NjamiNjamEntities())
            {
                var query = from k in db.Korisnik
                            orderby k.Prezime
                            select k;
                listaZaposlenika = new List<Korisnik>(query.ToList());

            }
            return listaZaposlenika;
        }

        public List<Korisnik> PretraziKorisnike(string pretraga)
        {
            List<Korisnik> listaZaposlenika;
            using (var db = new NjamiNjamEntities())
            {
                var query = from k in db.Korisnik
                            where k.Ime.Contains(pretraga) || k.Prezime.Contains(pretraga) || k.Korisnicko_ime.Contains(pretraga)
                            select k;
                listaZaposlenika = new List<Korisnik>(query.ToList());

            }
            return listaZaposlenika;
        }

        public List<Korisnik> ProvjeriDostupnostKorImena(string korIme)
        {
            List<Korisnik> lista;
            using (var db = new NjamiNjamEntities())
            {
                var provjera = from k in db.Korisnik
                               where k.Korisnicko_ime == korIme
                               select k;
                lista = new List<Korisnik>(provjera.ToList());
            }
            return lista;

        }


        public bool ProvjeraEmaila(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;

            }
            catch
            {
                return false;
            }
        }

        public bool ProvjeriVelikoPocetnoSlovo(string naziv, int mjesto)
        {
            return Char.IsUpper(naziv, mjesto);
        }
    }
}
