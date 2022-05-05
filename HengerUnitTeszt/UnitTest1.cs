using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HengerUnitTeszt {
    [TestClass]
    public class UnitTest1 {
        Hengerteszt.Henger henger = new Hengerteszt.Henger();

        [TestMethod]
        public void AlapTeruletTeszt() {
            henger.setSugar(10);
            henger.setMagas(10);
            double varteredmeny = 314.159265358979;
            double kapotteredmeny = henger.getAlapterulet();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void FeluletTeszt() {
            henger.setSugar(10);
            henger.setMagas(10);
            double varteredmeny = 1256.63706143592;
            double kapotteredmeny = henger.getFelulet();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TerfogatTeszt() {
            henger.setSugar(10);
            henger.setMagas(10);
            double varteredmeny = 3141.59265358979;
            double kapotteredmeny = henger.getTerfogat();
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
