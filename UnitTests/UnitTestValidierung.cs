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

        [TestMethod]
        public void testGueltigeNummerEins()
        {
            string zuTesten = "+49 0201 123456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerZwei()
        {
            string zuTesten = "+44 0201123456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerDrei()
        {
            string zuTesten = "0033 0201/123456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerVier()
        {
            string zuTesten = "0049201123456";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerFuenf()
        {
            string zuTesten = "(0)201 1234 56";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerSechs()
        {
            string zuTesten = "+49 (941) 790-4780";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerSieben()
        {
            string zuTesten = "015115011900";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerAcht()
        {
            string zuTesten = "+91 09870987 899";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerNeun()
        {
            string zuTesten = "[+49] (0)89-800/849-50";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerZehn()
        {
            string zuTesten = "+49 (8024) [990-477]";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(true, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerElf()
        {
            string zuTesten = "123";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(false, isKorrekteNummer);
        }

        [TestMethod]
        public void testGueltigeNummerZwoelf()
        {
            string zuTesten = "987698679876986969867976978";
            Validierung val = new Validierung();
            bool isKorrekteNummer = val.validiereNummer(zuTesten);
            Assert.AreEqual(false, isKorrekteNummer);
        }

    }
}
