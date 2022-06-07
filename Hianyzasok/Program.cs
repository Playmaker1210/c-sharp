using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzasok {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Adja meg a hianyzasok szamat");
            int hianyzasok = Convert.ToInt32(Console.ReadLine());
            string szul, into = "";
            
            if(hianyzasok >= 10) {
                Console.WriteLine("Adja meg szuletesi datumat");
                szul = Console.ReadLine();
                into = "";
                if (hianyzasok > 12) into = "figyelmeztetes";
                else if (hianyzasok > 14) into = "osztalyfonoki";
                else if (hianyzasok > 16) into = "igazgatoi";
                else if (hianyzasok > 18) into = "felfuggesztes";
            }

            Console.WriteLine(into);
        }
    }
}
