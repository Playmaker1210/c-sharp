using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace született {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Add meg a nevet! ");
            string nev = Console.ReadLine();
            Console.Write("\nAdd meg a foglalkozását! ");
            string foglalkozas = Console.ReadLine();
            Console.Write("\nAdd meg a nemét!(f/n) ");
            string nem = Console.ReadLine();
            Ember ember1 = new Ember(nev, foglalkozas, nem);

            Console.Write("Add meg a nevet! ");
            nev = Console.ReadLine();
            Console.Write("\nAdd meg a foglalkozását! ");
            foglalkozas = Console.ReadLine();
            Console.Write("\nAdd meg a nemét!(f/n) ");
            nem = Console.ReadLine();
            Ember ember2 = new Ember(nev, foglalkozas, nem);

            Console.Write("Add meg a nevet! ");
            nev = Console.ReadLine();
            Console.Write("\nAdd meg a foglalkozását! ");
            foglalkozas = Console.ReadLine();
            Console.Write("\nAdd meg a nemét!(f/n) ");
            nem = Console.ReadLine();
            Ember ember3 = new Ember(nev, foglalkozas, nem);

            Console.WriteLine(ember1.kiir());
            Console.WriteLine(ember2.kiir());
            Console.WriteLine(ember3.kiir());

            StreamWriter writer = new StreamWriter(@"szuletettki.txt", false, Encoding.Default);
            writer.WriteLine(ember1.kiir());
            writer.WriteLine(ember2.kiir());
            writer.WriteLine(ember3.kiir());
            writer.Close();

            Console.ReadKey();
        }
    }
}
