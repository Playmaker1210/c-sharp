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
            ulong darab = Convert.ToUInt64(Console.ReadLine());

            for (ulong i = 0; i < darab; i++) {
                szamok.Add(random.Next(10, 100));
            }

            foreach(int i in szamok) {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
