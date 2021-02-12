using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class SpecijalnaPonudaTest
    {
        [TestMethod]
        public void ProvjeriPostojanostSpecijalnihArtikalaUBazi()
        {
            SpecijalnaPonuda specijalnaPonuda = new SpecijalnaPonuda();
            Assert.AreEqual(specijalnaPonuda.ProvjeriDostupnostNaziva("Tartar biftek").Count, 1);
        }

        [TestMethod]
        public void ProvjeriNePostojanostSpecijalnihArtikalaUBazi()
        {
            SpecijalnaPonuda specijalnaPonuda = new SpecijalnaPonuda();
            Assert.AreEqual(specijalnaPonuda.ProvjeriDostupnostNaziva("Pizza romana").Count, 0);
        }
    }
}
