using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatar {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Adja meg a pontszamat");
            int pont = Convert.ToInt32(Console.ReadLine());

            if (pont <= 50) Console.WriteLine("Elegtelen");
            else if (pont <= 65) Console.WriteLine("Elegseges");
            else if (pont <= 80) Console.WriteLine("Kozepes");
            else if (pont <= 90) Console.WriteLine("Jo");
            else if (pont > 90) Console.WriteLine("Jeles");
            else Console.WriteLine("Rossz adatot adott meg");
        }
    }
}
