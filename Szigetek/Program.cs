using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Szigetek {
    public class Program {
        public static void Main(string[] args) {
            Sziget.setSziget();
            Console.WriteLine("Szigetek szama: {0}", Sziget.vizsgalat()[0]);
            Console.WriteLine("Legtobb osszefuggo szigetek szama: {0}", Sziget.vizsgalat()[1]);
            Thread.Sleep(5000);
        }
    }
}
