using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam.Klase;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class PiceTest
    {
        [TestMethod]
        public void ProvjeriPostojanostPicaUBazi()
        {
            Piće piće = new Piće();
            Assert.AreEqual(piće.ProvjeriDostupnostNaziva("Coca cola").Count, 1);
        }

        [TestMethod]
        public void ProvjeriNePostojanostPicaUBazi()
        {
            Piće piće = new Piće();
            Assert.AreEqual(piće.ProvjeriDostupnostNaziva("Aperol").Count, 0);
        }
    }
}
