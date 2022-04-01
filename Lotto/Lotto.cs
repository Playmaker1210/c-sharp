using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto {
    internal class Lotto {
        private int[] szamok = new int[5];

        public Lotto() {
            sorsolas();
        }

        public void sorsolas() {
            Random random = new Random();
            bool nincs_benne = true;
            for (int i = 0; i < 5; i++) {
                int sorsolt = random.Next(1, 91);
                for (int j = 0; j < szamok.Length; j++) {
                    if(sorsolt == szamok[i]) {
                        i--;
                        nincs_benne = false;
                    }
                }
                if (nincs_benne) {
                    szamok[i] = sorsolt;
                }
            }

            kiir();
        }

        public void kiir() {
            for (int i = 0; i < szamok.Length; i++) {
                Console.Write(szamok[i] + " ");
            }
        }
    }
}
