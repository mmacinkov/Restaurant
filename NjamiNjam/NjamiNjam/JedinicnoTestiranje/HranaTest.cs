using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class HranaTest
    {
        [TestMethod]
        public void ProvjeriPostojanostHraneUBazi()
        {
            Hrana hrana = new Hrana();
            Assert.AreEqual(hrana.ProvjeriDostupnostNaziva("Brusketi").Count, 1);
        }

        [TestMethod]
        public void ProvjeriNePostojanostHraneUBazi()
        {
            Hrana hrana = new Hrana();
            Assert.AreEqual(hrana.ProvjeriDostupnostNaziva("Bakalar").Count, 0);
        }
    }
}
