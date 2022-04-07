using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForEach {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++) {
                list.Add(random.Next(10, 100));
            }

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\nforeach:");

            foreach(int i in list) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
