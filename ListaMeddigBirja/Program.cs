using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ListaMeddigBirja {
    internal class Program {
        static void Main(string[] args) {

            List<byte> szamok1 = new List<byte>();

            Console.WriteLine("Milyen hosszú legyen a lista?");
            
            Random random = new Random();
            Stopwatch timer = new Stopwatch();

            //int a = Convert.ToInt32(Console.ReadLine());

            timer.Start();

            uint i = 0;
            try {
                for (i = 0; i < Int32.MaxValue; i++) {
                    szamok1.Add(Convert.ToByte(random.Next(1, 10)));
                }
            } catch (OutOfMemoryException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(i);
                timer.Stop();
                while (true);               
            }

            /*for (int i = 0; i < a; i++) {
                Console.WriteLine("{0}/{1}", szamok[i], i);
            }*/

            timer.Stop();
            StreamWriter writer = new StreamWriter("eltelt_ido.txt");
            writer.WriteLine("ido: " + timer.Elapsed);
            writer.Close();
            Console.WriteLine("ido: " + timer.Elapsed);

            Console.ReadKey();

        }
    }
}
