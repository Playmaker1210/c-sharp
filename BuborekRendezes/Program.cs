using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuborekRendezes {
    internal class Program {
        static void Main(string[] args) {
            int[] array = new int[10];
            Random random = new Random();

            //random elemekkel feltoltes
            for (int i = 0; i < array.Length; i++) {
                array[i] = random.Next(1, 100000);
            }

            for (int i = 0; i < array.Length - 1; ++i) {
                for (int j = array.Length - 1; j > i; --j) {
                    if (array[j - 1] > array[j]) {
                        int tmp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
