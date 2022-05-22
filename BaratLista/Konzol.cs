using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratLista {
    public static class Konzol {
        public static int index = 0;
        private static int count;
        private static ConsoleKeyInfo key;

        public static void getCount(int listCount) {
            count = listCount;
        }

        public static void kiir(List<Barat> list) {
            //20 adat kiirasa            
            int tartomany = index + 20;
            for (int i = index; i < tartomany; i++) {
                Console.Write((i+1) + "\t");
                list[i].kiir();
            }
        }

        public static void ReadKey() {
            //Gomb beolvasasa
            key = Console.ReadKey();
            Console.WriteLine(key.Key);
            System.Threading.Thread.Sleep(2000);
        }

        public static void dontes() {
            if (key.Key == ConsoleKey.PageUp) {
                fel();
            } else if (key.Key == ConsoleKey.PageDown) {
                le();
            } else if (key.Key == ConsoleKey.Home) {
                home();
            } else if (key.Key == ConsoleKey.End) {
                end();
            } else if (key.Key == ConsoleKey.Delete) {
                Program.buli();
            } else
                Console.WriteLine("Nem jo gombot nyomott le!!");
        }

        private static void fel() {
            index++;
            if (index == count - 19) index = count - 20;
        }

        private static void le() {
            index--;
            if (index < 0) index = 0;
        }

        private static void home() {
            index = 0;
        }

        private static void end() {
            index = count - 20;
        }
    }
}
