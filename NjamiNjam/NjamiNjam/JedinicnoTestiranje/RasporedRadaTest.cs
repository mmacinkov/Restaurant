using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class RasporedRadaTest
    {
        [TestMethod]
        public void DohvatiRasporedRadaZaTrenutnogZaposlenikaTest()
        {
            RasporedRada raspored = new RasporedRada();

            var rezultat = raspored.DohvatiRasporedRada(1);

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Tjedni_raspored>));
        }

        [TestMethod]
        public void DohvatiRasporedRadaZaTrenutnogZaposlenikaNemaRezultataTest()
        {
            RasporedRada raspored = new RasporedRada();        

            var rezultat = raspored.DohvatiRasporedRada(50);

            Assert.IsTrue(rezultat.Count == 0);
        }

        [TestMethod]
        public void DohvatiRasporedRadaZaTrenutnogZaposlenikaIdManjiOd0NemaRezultataTest()
        {
            RasporedRada raspored = new RasporedRada();

            var rezultat = raspored.DohvatiRasporedRada(-10);

            Assert.IsTrue(rezultat.Count == 0);
        }

        [TestMethod]
        public void DohvatiRasporedRadaZaSveZaposlenikeTest()
        {
            RasporedRada raspored = new RasporedRada();

            var rezultat = raspored.DohvatiRasporedRadaSve();

            Assert.IsInstanceOfType(rezultat, typeof(List<NjamiNjam.Tjedni_raspored>));
        }

        [TestMethod]
        public void DohvatiRasporedRadaZaSveZaposlenikeBrojRezultataVeciIliJednak0Test()
        {
            RasporedRada raspored = new RasporedRada();

            var rezultat = raspored.DohvatiRasporedRadaSve();

            Assert.IsTrue(rezultat.Count >= 0);
        }

        [TestMethod]
        public void DohvatiRasporedRadaZaSveZaposlenikeBrojRezultataManjiOd0Test()
        {
            RasporedRada raspored = new RasporedRada();

            var rezultat = raspored.DohvatiRasporedRadaSve();

            Assert.IsFalse(rezultat.Count < 0);
        }
    }
}