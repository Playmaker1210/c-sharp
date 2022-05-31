using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Kalkulatorr cal = new Kalkulatorr(5,5,'+');
            //cal.beker();
            Console.WriteLine(cal.szamolas());
            Console.ReadKey();
        }
    }
}
