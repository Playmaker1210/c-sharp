using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBill {
    internal class Program {
        public static void kiir(int[,] tomb) {
            for(int i = 0; i < tomb.GetLength(0); i++) {
                for(int j = 0; j < tomb.GetLength(1); j++) {
                    Console.WriteLine(tomb[i,j]);
                }
            }
        }

        static void Main(string[] args) {
            int sor = Convert.ToInt32(Console.ReadLine());
            int oszlop = Convert.ToInt32(Console.ReadLine());

            int[,] tomb = new int[sor, oszlop];
            double bekeres = 0;

            for (int i = 0; i < tomb.GetLength(0); i++) {
                for(int j = 0; j < tomb.GetLength(1); j++) {
                    Console.WriteLine("Adja meg a kovetkezo elemet");
                    bekeres = Convert.ToDouble(Console.ReadLine());
                    tomb[i,j] = Convert.ToInt32(Math.Round(bekeres));
                }
            }

            kiir(tomb);

            Console.ReadKey();
        }
    }
}
