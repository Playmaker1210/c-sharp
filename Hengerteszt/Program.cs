using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerteszt {
    public class Program {
        public static void Main(string[] args) {
            Henger henger = new Henger();
            henger.setSugar(10);
            henger.setMagas(10);
            henger.getAlapterulet();
            henger.getFelulet();
            henger.getTerfogat();
            Console.ReadKey();
        }
    }
}
