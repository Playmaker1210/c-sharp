using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor {
    class Kör {
        private double sugar;

        public double getSugar() { return sugar; }
        public void setSugar() { sugar = Convert.ToDouble(Console.ReadLine()); }

        public double kerulet() {
            return 2*sugar*Math.PI;
        }

        public double terulet() {
            return Math.Pow(sugar, 2) * Math.PI;
        }
    }
}
