using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OszthatUnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod, ExpectedException(typeof(FormatException))]
        public void setSzamTest() {
            Oszthat.Szam.setSzam();
        }

        [TestMethod]
        public void getSzamTest() {
            Oszthat.Szam.szam = 3;
            Oszthat.Szam.getSzam();
        }
    }
}
