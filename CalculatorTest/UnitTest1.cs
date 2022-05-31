using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{ 
    [TestClass]
    public class UnitTest1
    {
        calculator.Kalkulatorr calc = new calculator.Kalkulatorr(5,5,'+');
        
        [TestMethod]
        public void Testosszead()
        {
            int vart = 10;
            int kapott = calc.szamolas();
            Assert.AreEqual(vart, kapott);
        }
    }
}
