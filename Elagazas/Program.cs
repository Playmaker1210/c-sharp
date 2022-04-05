using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas {
    internal class Program {

        public static void parosok(List<int> lista) {
            foreach(int i in lista) {
                if(i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args) {
            List<int> szamok = new List<int>();
            Random random = new Random();

            for (int i = 0; i < random.Next(30, 200); i++) {
                szamok.Add(random.Next(10, 100));
            }

            parosok(szamok);
            Console.ReadKey();
        }
    }
}
