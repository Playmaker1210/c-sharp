using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratLista {
    public class Program {
        static void Main(string[] args) {
            BaratFajl.Program.Main();

            List<Barat> baratok = new List<Barat>();

            StreamReader reader = new StreamReader("baratok.txt", Encoding.Default);
            int c = 0;
            while(!reader.EndOfStream) {
                if (c % 100000 == 0) Console.WriteLine(c + " beolvasva");
                c++;
                string input = reader.ReadLine();
                string[] adatok = input.Split(',');
                baratok.Add(new Barat(adatok[0], DateTime.Parse(adatok[1]), adatok[2], Convert.ToInt32(adatok[3])));
            }

            for (int i = 0; i < baratok.Count; i++) {
                if (c % 100000 == 0)
                    baratok[i].kiir();
            }

            Console.ReadKey();
        }
    }
}
