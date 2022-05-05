using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hengerteszt {
    public class Henger {
        private double sugar;
        private double magassag;

        public void setSugar(double sugar) {
            this.sugar = sugar;
            if (this.sugar > 55.5 || this.sugar < 10.0)
                throw new Exception("Rossz adat lett megadva!!");
        }

        public void setMagas(double magassag) {
            this.magassag = magassag;
            if (this.magassag > 55.5 || this.magassag < 10.0)
                throw new Exception("Rossz adat lett megadva!!");
        }

        public double getAlapterulet() {
            double eredmeny = (Math.PI * Math.Pow(sugar, 2));
            Console.WriteLine("A henger alapterülete: " + eredmeny);
            return eredmeny;
        }

        public double getFelulet() {
            double eredmeny = (2 * Math.PI * sugar * (sugar + magassag));
            Console.WriteLine("A henger feülete: " + eredmeny);
            return eredmeny;
        }

        public double getTerfogat() {
            double eredmeny = (Math.PI * Math.Pow(sugar, 2) * magassag);
            Console.WriteLine("A henger térfogata: " + eredmeny);
            return eredmeny;
        }
    }
}
