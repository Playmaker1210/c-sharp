using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kivetelek {
    internal class Program {
        public void fajl_letrehozas() {
            try {
                StreamWriter writer = new StreamWriter(@"test.txt", false, Encoding.Default);
                writer.WriteLine("sor1");
                writer.WriteLine("sor2");
                writer.Close();
            } catch (Exception e) {

                throw;
            }
        }

        static void Main(string[] args) {
            //try catch blokk
            int[] arr = new int[2];
            try {   //a tryba irjuk az a kod (reszletet) ahol a kivetel elofordulhat
                arr[2] = 1;
            } catch (IndexOutOfRangeException e) {  //a catch ag akkor fut le ha megtortenik a kivetel, itt adjuk meg mi torjtenjen
                Console.WriteLine(e.Message);       //miutan megtortent a kivetel
                                                    //nem kotelezo megadni feltetelt csak ha egyeni feltetelunk van
                                                    //vagy egy konkret feltetelt keresunk 
            }

            //mi magunk is letrehozhatunk kivetelt
            try {
                throw new Exception("dobott kivetel");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                int[] array = new int[2];
                array[3] = 10;
            } catch (System.IndexOutOfRangeException) {     //tobb catch agat is lehet egy try blokkhoz irni
                Console.WriteLine("OutOfRange");            //itt figyelni kell arra milyen sorrendbe irjuk oket
            } catch (System.Exception) {
                Console.WriteLine("Exception");
            }

            //sajat kivetel
            try {
                throw new MyException("sajat kivetel dobasa");
            } catch (Exception) {

                throw;
            }

            //Leggyakrabban elofordulo kivetelek
            //FileNotFoundException
            //Ez a kivetel akkor fordul elo amikor a beolvasott fajl:
            //nem letezik vagy rossz eleresi utvonalat adtunk meg
            //ahhoz hogy hasznaljuk ezt a kivetelt importalni kell a System.IO-t

            //fajl_letrehozas();

            try {
                StreamReader reader = new StreamReader("test.txt");
                string s = reader.ReadLine();

            } catch (FileNotFoundException e) {

                Console.WriteLine("A falj nem talalhato!");
            }

            //IndexOutOfRangeException
            //Ez akkor fordul elo amikor az index tulmegy a tomb hatarain

            Console.ReadKey();
        }

        class MyException : Exception {
            public MyException() { }

            public MyException(string message) : base(message) { }
            public MyException(string message, Exception innerException) : base(message, innerException) { }

        }
    }
}
