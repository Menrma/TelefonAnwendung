using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelefonAnwendung.Model;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Speicherzugriff abc = new Speicherzugriff();
            var test = abc.leseDefaultLaenderVorwahl();
            Assert.AreEqual(test.Count > 0, true);
        }
    }
}
