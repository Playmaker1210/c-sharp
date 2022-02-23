using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyv {
    internal class Program {

        public static bool hosszu_e(int oldalak) {
            if (oldalak > 150) return true;

            return false;
        }

        static void Main(string[] args) {
            string cim = "";
            int oldalak = 0;
            do {
                Console.Write("Add meg a könyv címét! ");
                cim = Console.ReadLine();
                Console.Write("\nAdd meg az oldalak számát! ");
                if(cim != "") 
                    oldalak = Convert.ToInt32(Console.ReadLine());

                if (hosszu_e(oldalak))
                    Console.WriteLine("A {0} hosszú terjedelmű könyv", cim);
                else Console.WriteLine("A {0} rövid terjedelmű könyv", cim);
            } while (cim != "");
        }
    }
}
