using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;
using System.Collections.Generic;


namespace JedinicnoTestiranje
{
    [TestClass]
    public class RezervacijeTest
    {
        [TestMethod]
        public void DohvatiRezervacijeZaOvajMjesec()
        {
            UpravljanjeRezervacijom rezervacije = new UpravljanjeRezervacijom();

            var rezultat = rezervacije.DohvatiRezervacije();

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Rezervacija>));
          
        }
        [TestMethod]
        public void DohvacanjeRezervacijaNaDanasnjiDan()
        {
            UpravljanjeRezervacijom rezervacije = new UpravljanjeRezervacijom();
            
            var rezultat = rezervacije.DohvatiRezervacijeNaOdredenDan(DateTime.Today);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Rezervacija>));
        }
        [TestMethod]
        public void BrojStolaManjiIliJednakMaksimalnomBrojuStolova()
        {
            UpravljanjeRezervacijom rezervacije = new UpravljanjeRezervacijom();
            Rezervacija r = new Rezervacija();
            var rez = r.Broj_stola;

            Assert.IsTrue(rez <= 20);
                      
        }
        [TestMethod]
        public void DohvatiRezervacijeRezultatVeciIliJednak0()
        {
            UpravljanjeRezervacijom ur = new UpravljanjeRezervacijom();

            var rezultat = ur.DohvatiRezervacije();
            Assert.IsTrue(rezultat.Count > 0);

        

    
        }
        [TestMethod]
        public void DohvaiRezervacijeBrojRezultataManjiOd0Test()
        {
            UpravljanjeRezervacijom ur = new UpravljanjeRezervacijom();

            var rezultat = ur.DohvatiRezervacije();
            Assert.IsFalse(rezultat.Count<0);


        }
        [TestMethod]
        public void BrojStolaVeciOdMaksimalnogBrojaStolova()
        {
            UpravljanjeRezervacijom rezervacije = new UpravljanjeRezervacijom();
            Rezervacija r = new Rezervacija();
            var rez = r.Broj_stola;

            Assert.IsFalse(rez >= 20);
        }
        [TestMethod]
        public void RezervacijaImaKorisnikaKojiJuJeNapravio()
        {
            Rezervacija r = new Rezervacija();            
            
            var rez = r.Broj_gostiju;

            Assert.IsNotNull(r.vk_korisnik);
        }
    }
}
