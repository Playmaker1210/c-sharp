using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Szigetek;
using System.IO;

namespace SzigetUT {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void testSzam() {
            StringReader sr = new StringReader("10101110");
            Console.SetIn(sr);
            Sziget.setSziget();          
            Assert.AreEqual(Sziget.vizsgalat()[0], 5);
        }

        [TestMethod]
        public void testHossz() {
            StringReader sr = new StringReader("10101110");
            Console.SetIn(sr);
            Sziget.setSziget();
            Assert.AreEqual(Sziget.vizsgalat()[1], 3);
        }
    }
}
