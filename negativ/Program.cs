using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativ {
    internal class Program {
        static void Main(string[] args) {
            int num1, num2 = 0;

            do {
                Console.Write("Adj meg egy számot! ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nAdd meg a második számot! ");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num1 == 0 && num2 == 0);

            if (num1 > 0 && num2 > 0) Console.WriteLine("A két szám közül egyik sem negatív");
            else if (num1 > 0 && num2 < 0) Console.WriteLine("A két szám közül a második negatív");
            else if (num1 < 0 && num2 > 0) Console.WriteLine("A két szám közül az első negatív");
            else if (num1 < 0 && num2 < 0) Console.WriteLine("Mindkét szám negatív");

            Console.ReadKey();
        }
    }
}
