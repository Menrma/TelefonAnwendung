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
            string erg = sz.ermittleVorwahl("DE");
            Assert.AreEqual("+49", erg);
        }

        [TestMethod]
        public void testKuerzelErmittlung() {
            Speicherzugriff sz = new Speicherzugriff();
            string erg = sz.ermittleLaenderkuerzel("+49");
            Assert.AreEqual("DE", erg);
        }

        [TestMethod]
        public void testSetzeNeuenDefault()
        {
            Speicherzugriff sz = new Speicherzugriff();
            KuerzelVorwahl neuerDefault = new KuerzelVorwahl();
            neuerDefault.Laenderkuerzel = "BE";
            neuerDefault.Vorwahl = "+32";
            sz.setzeDefaultWert(neuerDefault);
            Assert.AreEqual(neuerDefault, sz.defaultWertLandVorwahl);
        }

    }
}
