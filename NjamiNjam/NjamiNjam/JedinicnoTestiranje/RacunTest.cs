using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
       [TestClass]
    public class RacunTest
    {
       
        
        [TestMethod]
        public void DohvatiDanasnjeRacune()
        {

            DohvacanjeRacuna racuni = new DohvacanjeRacuna();

            var rezultat = racuni.DohvatiDanasnjeRacune();

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Racun>));
           
       
        }

        [TestMethod]
        public void DohvatiRacuneNaOdredeniDan()
        {
            
            DohvacanjeRacuna racuni = new DohvacanjeRacuna();

            var rezultat = racuni.DohvatiRacuneNaODredenDatum(DateTime.Now);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Racun>));


        }
        [TestMethod]
        public void PromjenaNacinaPlacanjaZaNepostojećiNacinPlacanja()
        {
            Racun rac = new Racun();

            Assert.AreNotEqual(rac.Status_racuna , 0);


        }
        [TestMethod]
        public void RacunImaKorisnikaKojiGaJeNapravio()
        {
            Racun rac = new Racun();

            Assert.IsNotNull(rac.vk_korisnik);

        }
        [TestMethod]
        public void PopustVeciIliJednakNuli()
        {
            Racun rac = new Racun();

            Assert.IsTrue(rac.Popust >= 0);

        }


    }
}
