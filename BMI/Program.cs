using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Adja meg a magassagat cm-ben");
            int magassag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a tomeget");
            int tomeg = Convert.ToInt32(Console.ReadLine());

            double bmi = tomeg / (magassag * magassag);
            Console.WriteLine("BMI-je: " + bmi);
        }
    }
}
