using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer {
    internal class Atvalto {
        private int szam;
        private int rendszer;

        public Atvalto() {
            szam = Convert.ToInt32(Console.ReadLine());
            rendszer = Convert.ToInt32(Console.ReadLine());
            konvertalas();
        }

        public void konvertalas() {
            string binaris = Convert.ToString(szam, rendszer);
            Console.WriteLine(binaris);
        }
    }
}
