using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk {
    internal class Program {
        private static int[,] tabla = new int[8, 8];

        public static bool oszlopEllenorzes(int y_index) { 
            for (int x = 0; x < tabla.GetLength(0); x++)
                if (tabla[x, y_index] != 0) //megvizsgaljuk, hogy az adott sorban van e mar babu
                    return false; //ha talaltunk babut return false 

            return true; //ha nem adott vissza eddig semmit akkor adjon vissza igazat
        }

        public static bool sorEllenorzes(int x_index) { 
            for (int y = 0; y < tabla.GetLength(0); y++)
                if (tabla[x_index, y] != 0) //megvizsgaljuk az adott sort az oszlopban
                    return false;   //ha talalt babut akkor return false

            return true; //ha nem talalt sehol se babut akkor return true
        }

        static void Main(string[] args) {
            int lehetosegek = 0;

            for (int i = 0; i < tabla.GetLength(0); i++) {
                for (int j = 0; j < tabla.GetLength(1); j++) {

                }
            }
            

            Console.ReadKey();
        }
    }
}
