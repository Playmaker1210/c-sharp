using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorozatok {
    internal class Sorozat {
        private int[] szamok = new int[4];

        public Sorozat() {
            Console.WriteLine("Adja meg a számokat");
            for (int i = 0; i < szamok.Length; i++) {
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            mertani_e();
            szamtani_e();
        }

        public void mertani_e() {
            int elso_hanyados = szamok[szamok.Length - 1] / szamok[szamok.Length - 2];
            bool sorozat_e = true;
            for (int i = szamok.Length -1; i > 0; i--) {
                int akt_hanyados = szamok[i] / szamok[i - 1];
                if (akt_hanyados != elso_hanyados) {
                    Console.WriteLine("A sorozat nem mértani!");
                    sorozat_e = false;
                    break;
                }
            }
            if (sorozat_e) {
                Console.WriteLine("A sorozat mértani!");
            }
        }

        public void szamtani_e() {
            int elso_kulonbseg = szamok[szamok.Length - 1] - szamok[szamok.Length - 2];
            bool sorozat_e = true;
            for (int i = szamok.Length-1; i > 0; i--) {
                int akt_kulonbseg = szamok[i] - szamok[i - 1];
                if(akt_kulonbseg != elso_kulonbseg) {
                    Console.WriteLine("A sorozat nem számtani!");
                    sorozat_e = false;
                    break;
                }
            }
            if (sorozat_e) {
                Console.WriteLine("A sorozat számtani!");
            }

        }
    }
}
