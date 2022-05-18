using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinnye {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Adja meg az atmerot");
            double atmero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adja meg a dinnyek szamat");
            int num = Convert.ToInt32(Console.ReadLine());

            double eredmeny = ((Math.PI * atmero) * 2 + 60) * num / 100.0; //meterbe konvertalva
            Console.WriteLine(eredmeny + " méter szalag kell");

            Console.ReadKey();
        }
    }
}
