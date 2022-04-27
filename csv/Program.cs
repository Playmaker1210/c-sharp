using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace csv {
    internal class Program {
        static void Main(string[] args) {
            StreamWriter writer = new StreamWriter(@"adatok.csv", false, Encoding.Default);
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (long i = 0; i < 10000000; i++) {
                for (long j = 0; j < 5; j++) {
                    writer.Write(random.Next(-100000, 100000) + ";");
                }
                if (i % 1000000 == 0) { Console.WriteLine(i); }
                writer.WriteLine();
            }

            stopwatch.Stop();

            writer.Close();
            Console.WriteLine("kiiras kesz");
            Console.WriteLine("Eltelt ido: " + stopwatch.Elapsed);
            Console.ReadKey();

        }
    }
}
