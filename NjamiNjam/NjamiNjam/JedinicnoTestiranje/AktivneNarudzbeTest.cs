using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class AktivneNarudzbeTest
    {
        [TestMethod]
        public void DohvatiSveRacuneZaStol1Test()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            var rezultat = narudzbe.PopuniRacune(1);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Racun>));
        }

        [TestMethod]
        public void DohvatiSveRacuneZaStol10Test()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            var rezultat = narudzbe.PopuniRacune(10);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Racun>));
        }

        [TestMethod]
        public void DohvatiSveStavkeZaOdabraniRacunTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();
            NjamiNjam.Racun racun = new NjamiNjam.Racun();

            var rezultat = narudzbe.PopuniStavke(racun);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Stavke_racuna>));
        }

        [TestMethod]
        public void DohvatiSveArtikleTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            var rezultat = narudzbe.PopuniArtikle();

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Artikli>));
        }

        [TestMethod]
        public void DohvatiSveArtiklePretragomTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            string pretraga = "Coca Cola";
            var rezultat = narudzbe.PretragaTekst(pretraga);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Artikli>));
        }

        [TestMethod]
        public void DohvatiSveArtiklePremaVrstiArtiklaTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            NjamiNjam.Tip tipArtikla = new NjamiNjam.Tip();

            var rezultat = narudzbe.Vrsta(tipArtikla);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Artikli>));
        }

        [TestMethod]
        public void DohvatiSveArtiklePretragomNemaRezultataTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            string pretraga = "Janjetina";
            var rezultat = narudzbe.PretragaTekst(pretraga);

            Assert.IsTrue(rezultat.Count == 0);
        }

        [TestMethod]
        public void DohvatiSveRacuneZaStol50NemaRezultataTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            var rezultat = narudzbe.PopuniRacune(50);

            Assert.IsTrue(rezultat.Count == 0);
        }

        [TestMethod]
        public void DohvatiSveArtiklePremaVrstiArtiklaNemaRezultataTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();

            NjamiNjam.Tip tipArtikla = new NjamiNjam.Tip
            {
                ID = 100,
                Naziv = "Hamburgeri",
                Opis = "",
            };

            var rezultat = narudzbe.Vrsta(tipArtikla);

            Assert.IsTrue(rezultat.Count == 0);
        }

        [TestMethod]
        public void DohvatiSveStavkeZaOdabraniRacunNemaRezultataTest()
        {
            AktivneNarudzbe narudzbe = new AktivneNarudzbe();
            NjamiNjam.Racun racun = new NjamiNjam.Racun();

            racun = null;

            var rezultat = narudzbe.PopuniStavke(racun);

            Assert.IsTrue(rezultat.Count == 0);
        }
    }
}