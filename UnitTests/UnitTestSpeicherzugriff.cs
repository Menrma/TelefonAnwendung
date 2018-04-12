using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelefonAnwendung.Model;

namespace UnitTests
{
    [TestClass]
    public class UnitTestSpeicherzugriff
    {
        [TestMethod]
        public void testVorwahlErmittlung()
        {
            Speicherzugriff sz = new Speicherzugriff();
           string erg = sz.ermittleVorwahll("DE");
            Assert.AreEqual("+49", erg);
        }

        [TestMethod]
        public void testKuerzelErmittlung() {
            Speicherzugriff abv = new Speicherzugriff();
            string erg = abv.ermittleLaenderkuerzel("+49");
            Assert.AreEqual("DE", erg);
        }
    }
}
