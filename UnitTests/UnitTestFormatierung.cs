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
            f.formatiere("+49 (8024) [990-477]", "DE");
        }
    }
}
