using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaKezeles {
    public class Program {
        static void Main(string[] args) {
            Varosok varosok = new Varosok();
            //varosok.setDb();
            varosok.setNevek();
            varosok.getNevek();
            varosok.getVan();
            varosok.delNev();
            varosok.getNevek();
            varosok.delLast();
            varosok.getNevek();
            Console.ReadKey();
        }
    }
}
