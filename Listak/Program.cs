using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak {
    internal class Program {
        static void Main(string[] args) {
            List<int> szamok = new List<int>();
            Random random = new Random();

            for (int i = 0; i < random.Next(10,100); i++) {
                szamok.Add(random.Next(10, 100));
            }

            foreach(int i in szamok) {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
