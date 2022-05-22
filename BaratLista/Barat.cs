using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratLista {
    public class Barat {
        private string nev;
        private DateTime szuletes_ido;
        private string nem;
        private int bulizasi_szam;

        public Barat(string nev, DateTime szul_ido, string nem, int b_szam) {
            this.nev = nev;
            this.nem = nem;
            this.szuletes_ido = szul_ido;
            this.bulizasi_szam = b_szam;
        }

        public DateTime getSzuletes() {
            return szuletes_ido;
        }

        public string getNev() {
            return nev;
        }

        public int getBulizasi_szam() {
            return bulizasi_szam;
        }

        public void kiir() {
            string ido = szuletes_ido.ToShortDateString();
            Console.WriteLine("Név: " + nev + "\tSzületési idő: " + ido + "\tNem: " + nem + "\tBulizasi szam: " + bulizasi_szam);
        }
    }
}
