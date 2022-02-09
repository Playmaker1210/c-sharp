using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string folytatas = "igen";
            string[] opciok = { "ko", "papir", "ollo" };

            while (folytatas == "igen") {
                Random random = new Random();
                int pc_random = random.Next(0, 2);
                string pc_valasztas = opciok[pc_random];

                string user_valsztas = Console.ReadLine();

                Console.WriteLine("PC: {0}",pc_valasztas);

                if (pc_valasztas == "ko" && user_valsztas == "ko") { Console.WriteLine("Dontetlen"); } 
                else if (pc_valasztas == "ko" && user_valsztas == "papir") { Console.WriteLine("Vesztettel"); } 
                else if (pc_valasztas == "ko" && user_valsztas == "ollo") { Console.WriteLine("Nyertel"); } 
                else if (pc_valasztas == "papir" && user_valsztas == "ko") { Console.WriteLine("Vesztettel"); } 
                else if (pc_valasztas == "papir" && user_valsztas == "papir") { Console.WriteLine("Dontetlen"); } 
                else if (pc_valasztas == "papir" && user_valsztas == "ollo") { Console.WriteLine("Nyertel"); } 
                else if (pc_valasztas == "ollo" && user_valsztas == "ko") { Console.WriteLine("Nyertel"); } 
                else if (pc_valasztas == "ollo" && user_valsztas == "papir") { Console.WriteLine("Vesztettel"); } 
                else if (pc_valasztas == "ollo" && user_valsztas == "ollo") { Console.WriteLine("Dontetlen"); } 
                else { Console.WriteLine("Hiba"); }

                Console.WriteLine("Akarsz meg jatszani? (igen/nem)");
                folytatas = Console.ReadLine();
            }
        }
    }
}
