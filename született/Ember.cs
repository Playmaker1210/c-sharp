using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace született {
    internal class Ember {
        private string nev;
        private string foglalkozas;
        private string nem;
        private int szerencse_szam;
        Random random = new Random();

        public Ember(string nev, string foglalkozas, string nem) {
            this.nev = nev;
            this.foglalkozas = foglalkozas;
            this.nem = nem;
            szerencse_szam = random.Next(1, 51);
        }

        //Getter setters for variables
        public string getNev() {
            return nev;
        }
        public void setNev(string nev) {
            this.nev = nev;
        }

        public string getFoglalkozas() {
            return foglalkozas;
        }
        public void setFoglalozas(string foglalkozas) {
            this.foglalkozas = foglalkozas;
        }

        public string getNem() {
            return nem;
        }
        public void setNem(string nem) {
            this.nev = nem;
        }

        public int getSzerencse_szam() {
            return szerencse_szam;
        }
        public void setSzerencse_szam(int szerencse_szam) {
            this.szerencse_szam = szerencse_szam;
        }

        //Methods
        public string isFerfi() {
            if (nem.Equals("n") || nem.Equals("N"))
                return "nő";

            return "férfi";
        }

        public string kiir() {
            return nev + " egy " + foglalkozas + " " + isFerfi() + " volt, szerencse száma a " + szerencse_szam; 
        }
    }
}
