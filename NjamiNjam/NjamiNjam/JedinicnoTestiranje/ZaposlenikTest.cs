using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NjamiNjam;
using NjamiNjam.Klase;
using System.ComponentModel;


namespace JedinicnoTestiranje
{
    [TestClass]
    public class ZaposlenikTest
    {
        [TestMethod]
        public void ProvjeriIspravnostEMaila()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.IsTrue(zaposlenik.ProvjeraEmaila("marin@gmail.com"));
        }

        [TestMethod]
        public void ProvjeriNeIspravnostEMaila()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.IsFalse(zaposlenik.ProvjeraEmaila("marin.com"));
        }

        [TestMethod]
        public void ProvjeriPostojanostKorisnikaUBazi()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.AreEqual(zaposlenik.PretraziKorisnike("tklemic").Count, 1);
        }

        [TestMethod]
        public void ProvjeriNePostojiLiKorisnikUBazi()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.AreEqual(zaposlenik.PretraziKorisnike("peropetrovic").Count, 0);
        }

        [TestMethod]
        public void ProvjeriVelikoSlovo()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.IsTrue(zaposlenik.ProvjeriVelikoPocetnoSlovo("Ivo", 0));
        }

        [TestMethod]
        public void ProvjeriAkoNijeVelikoSlovo()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            Assert.IsFalse(zaposlenik.ProvjeriVelikoPocetnoSlovo("ivo", 0));
        }
    }
}
