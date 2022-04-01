using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu {
    internal class Menuk {
        private int valasztas;
        
        public Menuk() {
            menuPont();
        }

        public void setValasztas() {
            Console.WriteLine("Adja meg a menupont szamat");
            valasztas = Convert.ToInt32(Console.ReadLine());
        }

        public void menuPont() {
            while (true) {
                setValasztas();

                if (valasztas == 1) {
                    Console.WriteLine("Elso menupont");
                } else if (valasztas == 2) {
                    Console.WriteLine("Masodik menupont");
                } else if (valasztas == 3) {
                    Console.WriteLine("Harmadik menupont");
                } else if (valasztas == 4) {
                    Console.WriteLine("Negyedik menupont");
                } else if (valasztas == 5) {
                    Console.WriteLine("Kilépés menupont");
                    break;
                }
            }

        }
    }
}
