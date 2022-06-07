using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermenyJoslas {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Adja meg a termenyt tonnaban");
            int termeny = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int szorzo = random.Next(5, 16);

            int hozam = termeny * szorzo;
            Console.WriteLine("Hozam: " + hozam);

            if (szorzo >= 5 && szorzo <= 8) Console.WriteLine("Atlag alatti");
            else if (szorzo >= 9 && szorzo <= 12) Console.WriteLine("Atlagos");
            else if (szorzo >= 13 && szorzo <= 15) Console.WriteLine("Atlag feletti");
            else Console.WriteLine("Hiba");

        }
    }
}
