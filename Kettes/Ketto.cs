using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes {
    internal class Ketto {
        private int szam;

        public Ketto() {
            szam = Convert.ToInt32(Console.ReadLine());
            konvertalas();
        }

        public void konvertalas() {
            string binaris = Convert.ToString(szam, 2);
            Console.WriteLine(binaris);
        }
    }
}
