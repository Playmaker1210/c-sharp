using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris {
    internal class Binaris {
        private string szam;

        public Binaris() {
            Console.WriteLine("Kérem a számot");
            szam = Console.ReadLine();
            egyesek_szama();
        }

        public void egyesek_szama() {
            int count = 0;
            for (int i = 0; i < szam.Length; i++) 
                if (szam[i].Equals('1')) count++;

            Console.WriteLine("Egyesek szama: " + count);
        }

    }
}
