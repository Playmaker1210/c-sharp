using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontoktavolsaga {
    public struct Point {
        public double x;
        public double y;
    }
    
    internal class Program {
        static void Main(string[] args) {
            Point a = new Point();
            Point b = new Point();

            Console.WriteLine("Adja meg a pontok koordinatait egymas utan");
            a.x = Convert.ToDouble(Console.ReadLine());
            a.y = Convert.ToDouble(Console.ReadLine());
            b.x = Convert.ToDouble(Console.ReadLine());
            b.y = Convert.ToDouble(Console.ReadLine());

            double tavolsag = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
            Console.WriteLine("A ket pont tavolsaga: " + tavolsag);
        }
    }
}
