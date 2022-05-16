using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles {
    public class Varosok {
        List<string> varosok = new List<string>();
        string db;

        public string setDb() {
            Console.WriteLine("Adja meg hany db adatot akar eltarolni, ha 0-t vagy semmit ir be akkor addig fut a beolvasas amig ures sort nem ad be");
            db = Console.ReadLine();
            return db;
        }

        public void setNevek() {
            string db = setDb();
            string input = "";

            try {
                if (db == "" || db == "0") {
                    while (true) {
                        Console.WriteLine("Adja meg a varos nevet");
                        input = Console.ReadLine();
                        if (input == "") break;
                        varosok.Add(input);
                    }
                } else {
                    int num_db = Convert.ToInt32(db);
                    for (int i = 0; i < num_db; i++) {
                        Console.WriteLine("Adja meg a varos nevet");
                        input = Console.ReadLine();
                        varosok.Add(input);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }        
        }

        public void getNevek() {
            string kiir = "";
            for (int i = 0; i < varosok.Count; i++) {
                kiir += varosok[i] + ", ";
            }
            kiir.Trim();
            kiir = kiir.Remove(kiir.Length - 2);
            Console.WriteLine(kiir);
        }

        public void getVan() {
            Console.WriteLine("Adja meg a varos nevet");
            string input = Console.ReadLine();

            if(varosok.Contains(input))
                Console.WriteLine("A lista tartalmazza a várost!");
            else
                Console.WriteLine("A lista nem tartalmazza a várost!");
        }

        public void delNev() {
            Console.WriteLine("Adja meg a varos nevet amit torolni akar, ha nincs a listaban akkor hozza lesz adva");
            string input = Console.ReadLine();
            if (varosok.Contains(input))
                varosok.Remove(input);
            else
                varosok.Add(input);
        }

        public void delLast() {
            Console.WriteLine("Utolso elem torlese");
            varosok.RemoveAt(varosok.Count - 1);
        }
    }
}
