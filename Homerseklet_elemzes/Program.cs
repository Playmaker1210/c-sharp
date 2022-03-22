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

        public static void havi_adat(Nap[] napok, int honap) {

        }

        public static void kiir(Nap[] napok) {
            for (int i = 0; i < napok.Length; i++) {
                Console.WriteLine(napok[i].napi_adatok() + " | " + napok[i].getHonap() + " | " + napok[i].getEvszak());
            }
        }

        static void Main(string[] args) {
            Nap[] napok = new Nap[360];
            short honap = 0;
            short evszak = 4;


            for (int i = 0; i < napok.Length; i++) {
                if(i % 30 == 0) honap++; //megfelelo honap szam hozzarendelese a naphoz
                if (i == 60 || i == 150 || i == 240 || i == 330) //indexeles a honapokra mivel januarral kezdodik az ev
                    if (evszak == 4) evszak = 1; 
                    else evszak++;
                napok[i] = new Nap(evszak, honap);
            }

            Console.Write("Kérem a nap számát az évben ");
            short nap_szam = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            napi_adat(napok, nap_szam);

            
            Console.ReadKey();
        }
    }
}
