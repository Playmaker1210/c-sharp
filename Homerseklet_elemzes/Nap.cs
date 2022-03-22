using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet_elemzes {
    internal class Nap {
        private int min_homerseklet;
        private int max_homerseklet;
        private int evszak;
        private int honap;

        Random random = new Random();

        public Nap(int evszak, int honap) {
            this.evszak = evszak;
            this.honap = honap;
            genMinHom();
            genMaxHom();
        }

        public int getEvszak() {
            return evszak;
        }
        public int getHonap() {
            return honap;
        }
        public int getMinHom() {
            return min_homerseklet;
        }
        public int getMaxHom() {
            return max_homerseklet;
        }

        private void genMinHom() {
            if (evszak == 1) //tavasz
                min_homerseklet = random.Next(0, 10);
            else if (evszak == 2) //nyar
                min_homerseklet = random.Next(20, 25);
            else if (evszak == 3) //osz
                min_homerseklet = random.Next(0, 10);
            else//tel
                min_homerseklet = random.Next(-10, -5);
        }

        private void genMaxHom() {
            if (evszak == 1) //tavasz
                max_homerseklet = random.Next(15, 25);
            else if (evszak == 2) //nyar
                max_homerseklet = random.Next(25, 35);
            else if (evszak == 3) //osz
                max_homerseklet = random.Next(15, 20);
            else
                max_homerseklet = random.Next(0, 5);
        }

        public string napi_adatok() {
            float atlag = (min_homerseklet + max_homerseklet) / 2.0f;
            return "Minumum hom: " + min_homerseklet + " maximum hom: " + max_homerseklet
                + " atlag hom: " + atlag + "\n";
        }
    }
}