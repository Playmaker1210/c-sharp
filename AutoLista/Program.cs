using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoLista {
    internal class Program {
        static void Main(string[] args) {
            //lista letrehozas
            ListaGen lista = new ListaGen();
            lista.fajlIras();

            List<Auto> autok = new List<Auto>();

            StreamReader reader = new StreamReader(@"autok.txt", Encoding.Default);
            int c = 0;
            while (!reader.EndOfStream) {
                if (c % 100000 == 0) Console.WriteLine(c + " beolvasva");
                c++;
                string input = reader.ReadLine();
                string[] adatok = input.Split(',');
                autok.Add(new Auto(adatok[0], adatok[1], DateTime.Parse(adatok[2]), Convert.ToInt32(adatok[3]), adatok[4]));
            }

            for (int i = 0; i < autok.Count; i++) {
                if (i % 100000 == 0)
                    autok[i].kiir();
            }

            Console.ReadKey();
        }
    }
}
