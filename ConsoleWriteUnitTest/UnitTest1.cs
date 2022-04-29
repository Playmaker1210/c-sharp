using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleWriteUnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestConsoleWrite() {
            //Arrange
            string vartEredmeny = "Hello World!";

            //Action
            using (var sw  = new StringWriter()) {
                Console.SetOut(sw); //Atallitjuk az outputot 

                ConsoleWrite.Program.Main();

                var kapottEredmeny = sw.ToString().Trim();

                //Assert
                Assert.AreEqual(kapottEredmeny, vartEredmeny);
            }


        }
    }
}
