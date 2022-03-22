using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet_elemzes {
    internal class Program {
        public static void napi_adat(Nap[] napok, int index) {
            Console.WriteLine(napok[index - 1].napi_adatok());
        }

        public static string havi_adat(Nap[] napok, int honap) {
            int min = Int32.MaxValue, max = Int32.MinValue;
            float atlag = 0;
            for (int i = 0; i < napok.Length; i++) {
                if(napok[i].getHonap() == honap) {
                    if(napok[i].getMinHom() < min) min = napok[i].getMinHom();
                    if(napok[i].getMaxHom() > max) max = napok[i].getMaxHom();
                    atlag += (napok[i].getMaxHom() + napok[i].getMinHom()) / 2.0f;
                }
            }
            atlag /= 30.0f;

            return "Havi minimum: " + min + " havi maximum: " + max + " havi atlag: " + atlag;
        }

        public static string evszak_adat(Nap[] napok, int evszak) {
            int min = Int32.MaxValue, max = Int32.MinValue;
            float atlag = 0;
            for (int i = 0; i < napok.Length; i++) {
                if (napok[i].getEvszak() == evszak) {
                    if (napok[i].getMinHom() < min) min = napok[i].getMinHom();
                    if (napok[i].getMaxHom() > max) max = napok[i].getMaxHom();
                    atlag += (napok[i].getMaxHom() + napok[i].getMinHom()) / 2.0f;
                }
            }
            atlag /= 90.0f;

            return "Evszakban minimum: " + min + " evszakban maximum: " + max + " evszak atlag: " + atlag;
        }

        public static string eves_adat(Nap[] napok) {
            int min = Int32.MaxValue, max = Int32.MinValue;
            float atlag = 0;
            for (int i = 0; i < napok.Length; i++) {
                if (napok[i].getMinHom() < min) min = napok[i].getMinHom();
                if (napok[i].getMaxHom() > max) max = napok[i].getMaxHom();
                atlag += (napok[i].getMaxHom() + napok[i].getMinHom()) / 2.0f;
            }
            atlag /= 360.0f;

            return "Eves minimum: " + min + " eves maximum: " + max + " eves atlag: " + atlag;
        }

        public static void kiir(Nap[] napok) {
            for (int i = 0; i < napok.Length; i++) {
                Console.WriteLine(napok[i].napi_adatok() + " | " + napok[i].getHonap() + " | " + napok[i].getEvszak());
            }
        }

        static void Main(string[] args) {
            Nap[] napok = new Nap[360]; //minden honapra egysegesen 30 napot szamolunk
            short honap = 0;
            short evszak = 4;
            string folytatas = "igen";

            for (int i = 0; i < napok.Length; i++) {
                if(i % 30 == 0) honap++; //megfelelo honap szam hozzarendelese a naphoz
                if (i == 60 || i == 150 || i == 240 || i == 330) //indexeles a honapokra mivel januarral kezdodik az ev
                    if (evszak == 4) evszak = 1; 
                    else evszak++;
                napok[i] = new Nap(evszak, honap);
            }

            while(folytatas == "igen") {
                Console.WriteLine("Mit szeretne tudni?");
                Console.WriteLine("Egy nap adatai (1) | Egy honap adatai (2) | Egy evszak adatai (3) | Az ev adati (4)");
                short kerdes = Convert.ToInt16(Console.ReadLine());

                if (kerdes == 1) {
                    Console.WriteLine("Adja meg a nap számát");
                    short nap = Convert.ToInt16(Console.ReadLine());
                    napi_adat(napok, nap);
                } else if (kerdes == 2) {
                    Console.WriteLine("Adja meg a hónap számát ");
                    honap = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(havi_adat(napok, honap));
                } else if (kerdes == 3) {
                    Console.WriteLine("Adja meg az evszak számát ");
                    evszak = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(evszak_adat(napok, evszak));
                }else if(kerdes == 4) {
                    Console.WriteLine(eves_adat(napok));
                }

                Console.WriteLine("Szeretne még kérdezni? (igen/nem)");
                folytatas = Console.ReadLine();
            }
        }
    }
}
