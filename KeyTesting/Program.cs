using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTesting {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("new key");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("\n"+key.Key);
            }
        }
    }
}
