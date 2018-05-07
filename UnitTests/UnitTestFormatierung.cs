using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonAnwendung.Model;

namespace UnitTests
{
    [TestClass]
    public class UnitTestFormatierung
    {
        [TestMethod]
        public void testFormatierung()
        {
            Formatierung f = new Formatierung();
            var res = f.formatiere("+49 (8024) [990-477]", "DE");
            Assert.AreEqual("+49 8024 990477", res);
        }

        [TestMethod]
        public void testFormatierungFalscheEingaben()
        {
            Formatierung f = new Formatierung();
            var res = f.formatiere("##", "jhy");
            Assert.AreEqual(String.Empty, res);
        }

        [TestMethod]
        public void testFormatierungLeereEingaben()
        {
            Formatierung f = new Formatierung();
            var res = f.formatiere("", "");
            Assert.AreEqual(String.Empty, res);
        }

    }
}
