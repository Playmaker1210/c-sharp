using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLista {
    public class Auto {
        private string rendszam;
        private string tipus;
        private DateTime gyartas;
        private int muszaki;
        private string tulajdonos;

        public Auto(string rendszam, string tipus, DateTime gyartas, int muszaki, string tulajdonos) {
            this.rendszam = rendszam;
            this.tipus = tipus;
            this.gyartas = gyartas;
            this.muszaki = muszaki;
            this.tulajdonos = tulajdonos;
        }

        public void kiir() {
            //rendszam, tipus, gyartas, muszaki, tulaj
            Console.WriteLine("Rendszam: " + rendszam + " Tipus: "+tipus + " Gyartasi ev: "+gyartas.ToShortDateString() + " Muszaki: " + muszaki + " Tulajdonos: " + tulajdonos);
        }
    }
}
