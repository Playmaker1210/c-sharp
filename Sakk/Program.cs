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

        public static void kiir() {
            for (int i = 0; i < tabla.GetLength(0); i++) {
                for (int j = 0; j < tabla.GetLength(1); j++) {
                    Console.Write(tabla[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            //problema ha el van tolva a sor vagy az oszlop nem rak le 8 babut
            //csak egy fajta variaciot tud megcsinalni
            Random random = new Random();
            List<int[,]> tablak = new List<int[,]>();
            //int lehetosegek = 0;
            int babuk = 0;
            int akt_sor = 0;
            bool nem_jo_ketszer = false;
            int elozo_poz = 0, elozo_sor = 0;

            while(babuk < 9) {
                int pozicio = random.Next(0, 7);
                Console.WriteLine("pozicio: " + pozicio);
                Console.WriteLine("akt sor:" + akt_sor);
                if(sorEllenorzes(akt_sor) && oszlopEllenorzes(pozicio)) {
                    tabla[akt_sor, pozicio] = 1;
                    elozo_poz = pozicio;    //elozo babu elmentese
                    elozo_sor = akt_sor;
                    babuk++;
                    akt_sor++;
                }

                if(elozo_sor == akt_sor) {
                    nem_jo_ketszer = true;
                    if (nem_jo_ketszer) {
                        tabla = new int[8, 8];
                        babuk = 0,
                    }
                }

                //atnezni van e mar ez a tabla eltarolva
                if(babuk == 8) {
                    tablak.Add(tabla);
                }

                kiir();
            }
            

           

            Console.ReadKey();
        }
    }
}
