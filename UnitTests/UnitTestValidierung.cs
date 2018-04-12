using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelefonAnwendung.Model;

namespace UnitTests
{
    [TestClass]
    public class UnitTestValidierung
    {
        [TestMethod]
        public void testUngueltigesZeichen()
        {
            string zuTesten = "+49 .6456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(false, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeZeichen()
        {
            string zuTesten = "+49 6456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testZuVieleZiffern()
        {
            string zuTesten = "+123456789012345678901"; // 21 Ziffern
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(false, isKorrekteNummer);
        }
    }
}
