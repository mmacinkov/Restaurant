using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class BrziArtikliTest
    {
        [TestMethod]
        public void ProvjeriPostojanostBrzogArtiklaUBazi()
        {
            BrziArtikl brziArtikl = new BrziArtikl();
            Assert.AreEqual(brziArtikl.ProvjeriDostupnostNaziva("Macchiato").Count, 1);
        }

        [TestMethod]
        public void ProvjeriNePostojanostBrzogArtiklaUBazi()
        {
            BrziArtikl brziArtikl = new BrziArtikl();
            Assert.AreEqual(brziArtikl.ProvjeriDostupnostNaziva("Nesscafe").Count, 0);
        }
    }
}
