using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable {
    internal class Program {
        public static void n_kiir(int?[,] tömb) {
            for (int i = 0; i < tömb.GetLength(0); i++) {
                for (int j = 0; j < tömb.GetLength(1); j++) {
                    if(tömb[i,j] == null) {
                        Console.Write("null");

                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Adja meg hány soros legyen a mátrixa");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány oszlopos legyen a mátrixa");
            int oszlop = Convert.ToInt32(Console.ReadLine());

            int?[,] mátrix = new int?[sor, oszlop];
            n_kiir(mátrix);
            
            string folytatas = "igen";
            while (folytatas == "igen") {
                Console.WriteLine("Írja be vesszővel elválasztva, hogy a maga által megadott sor, oszlop, milyen értéket adjon. Formátum: sorszám,oszlopszám,érték");
                string bekeres = Console.ReadLine();
                string[] beker = bekeres.Split(',');
                sor = Convert.ToInt32(beker[0]);
                oszlop = Convert.ToInt32(beker[1]);
                int ertek = Convert.ToInt32(Math.Round(Convert.ToDouble(beker[2])));

                if (mátrix[sor, oszlop] == null) {
                    mátrix[sor, oszlop] = ertek;
                } else {
                    Console.WriteLine("Ez a hely már foglalt.");

                }

                Console.WriteLine("Akarod emég folytatni?");
                folytatas = Console.ReadLine();

            }


            for (int i = 0; i < mátrix.GetLength(0); i++) {
                for (int j = 0; j < mátrix.GetLength(1); j++) {
                    Console.WriteLine(mátrix[i,j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}