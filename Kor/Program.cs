using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Kérem a kör sugarát");
            Kör kör = new Kör();
            kör.setSugar();

            Console.WriteLine("Kerület {0} ",kör.kerulet());
            Console.WriteLine("Terület {0} ",kör.terulet());

            Console.ReadKey();
        }
    }
}
