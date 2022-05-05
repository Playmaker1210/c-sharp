using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oszthat {
    public static class Szam {
        public static int szam;

        public static void setSzam() {
            try {
                szam = Convert.ToInt32(Console.ReadLine());
            } catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void getSzam() { //Teszteles miatt at van adva egy szam alap esetben nincs semmi atadva
            if(szam % 3 == 0)
                Console.WriteLine("harom");
            else if(szam % 5 == 0)
                Console.WriteLine("ot");
            else
                Console.WriteLine(szam);
        }
    }
}
