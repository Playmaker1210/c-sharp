using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NegyszogUnitTest {
    [TestClass]
    public class UnitTest1 {
        static double oldal = 2.0;
        Negyszog.Negyszog negyszog = new Negyszog.Negyszog(oldal);

        [TestMethod]
        public void TestKerulet() {
            double vartEredmeny = 8.0;
            double kapottEredmeny = negyszog.Kerulet();
            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void TestTerulet() {
            double vartEredmeny = 4.0;
            double kapottEredmeny = negyszog.Terulet();
            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void TestAtlo() {
            double vartEredmeny = 2.83;
            double kapotEredmeny = negyszog.Atlo();
            Assert.AreEqual(vartEredmeny, kapotEredmeny);
        }
    }
}
