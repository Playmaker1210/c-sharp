using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyszog {
    public class Negyszog {
        public double oldal { get; set; }
        public double oszlop;
        
        public Negyszog(double oldal) {
            this.oldal = oldal;
        }

        public void getOszlop(double oszlop) {
            if(oszlop <= 0) {
                throw new ArgumentException("A magasság negativ!");
            } else {
                this.oszlop = oszlop;
            }
        }

        public double Kerulet() {
            return 4.0 * oldal;
        }

        public double Terulet() {
            return oldal*oldal;
        }

        public double Atlo() {
            return Math.Round(Math.Sqrt(oldal*oldal * 2) * 100.0) / 100.0;
        }
    }
}
