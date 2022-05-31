using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Kalkulatorr
    { 
        private int szam1 = 0;
        private int szam2 = 0;
        private char muvjel;
        private int eredm = 0;
        private string uzen;

        public Kalkulatorr(int szam1, int szam2, char muvjel)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muvjel = muvjel;
        }
        public void beker()
        {
            Console.WriteLine("Adja meg az első számot");
            szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a második számot");
            szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a műveleti jelet");
            muvjel = Convert.ToChar(Console.Read());
        }
        
        public int szamolas()
        {
            switch (muvjel)
            {
                case '+':
                    eredm = szam1 + szam2;
                    break;

                case '-':
                    eredm = szam1 - szam2;
                    break;

                case '*':
                    eredm = szam1 * szam2;
                    break;

                case '/':
                    eredm = szam1 / szam2;
                    break;

                default:
                    uzen = "Hibás műveleti jel";
                    break;
            }

            return eredm;
        }
    }
}
