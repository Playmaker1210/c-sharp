using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaratLista {
    public class Program {
        public static List<Barat> baratok = new List<Barat>();

        public static void buli() {
            int ev = DateTime.Now.Year - 20;
            List<Barat> nevek = new List<Barat>();

            for (int i = 0; i < baratok.Count; i++) {
                if (baratok[i].getSzuletes().Year < ev && baratok[i].getBulizasi_szam() >= 5) {
                    if(nevek.Count != 15) {
                        nevek.Add(baratok[i]);
                    } else {
                        int min = 11;
                        int min_i = -1;
                        for (int j = 0; j < nevek.Count; j++) {
                            if (nevek[j].getBulizasi_szam() < min) {
                                min = nevek[j].getBulizasi_szam();
                                min_i = j;
                            }
                        }

                        nevek.RemoveAt(min_i);
                        nevek.Add(baratok[i]);
                    }
                    
                }
            }

            if(nevek.Count > 9) {
                for (int i = 0; i < nevek.Count; i++) {
                    Console.WriteLine(nevek[i].getNev());
                }
            } else {
                Console.WriteLine("Nincs eleg ember a bulizashoz");
            }

            Console.WriteLine("Folytatashoz nyomjon meg egy gombot");
            Console.ReadKey();
        }

        public static void Main() {
            //fajl letrehozasa
            BaratFajl.Program.Main();

            //fajl beolvasasa           
            StreamReader reader = new StreamReader("baratok.txt", Encoding.Default);
            int c = 0;
            while(!reader.EndOfStream) {
                if (c % 100000 == 0) Console.WriteLine(c + " beolvasva");
                c++;
                string input = reader.ReadLine();
                string[] adatok = input.Split(',');
                baratok.Add(new Barat(adatok[0], DateTime.Parse(adatok[1]), adatok[2], Convert.ToInt32(adatok[3])));
            }

            //main loop
            Konzol.getCount(baratok.Count);
            while (true) {
                Console.Clear();
                Console.WriteLine("A PageUp es PageDown gombokkal tud lepkedni a megjelenitendo sorokon");
                Console.WriteLine("A Home es End gombokkal a lista elejere es vegere tud lepni");
                Console.WriteLine("A Del gomb megnyomasaval meg tudja nezni van e eleg fo egy bulihoz");
                Console.WriteLine("Egy gomb megnyomasa utan a program 2 mp-t fog varni\n");

                Konzol.kiir(baratok);
                Konzol.ReadKey();
                Konzol.dontes();
            }
        }
    }
}
