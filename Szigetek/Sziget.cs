using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek {
    public static class Sziget {
        private static int sziget_sorozat = 0;
        private static int sziget_sorozat_max = 0;
        private static int sziget_sum = 0;
        private static string sziget = "";
        private static bool sorozat = false;

        public static void setSziget() {
            Console.WriteLine("Adja meg a szigeteket | sziget 1, tenger 0");
            sziget = Console.ReadLine();
        }

        public static int[] vizsgalat() {
            for (int i = 0; i < sziget.Length; i++) {
                if (sziget[i].Equals('1')) {
                    sziget_sum++;
                    sorozat = true;
                    if (sorozat) {
                        sziget_sorozat++;
                    }
                } else {
                    sorozat = false;
                    sziget_sorozat_max = sziget_sorozat;
                    sziget_sorozat = 0;
                }

                if (i == sziget.Length-1) {
                    if (sziget_sorozat_max < sziget_sorozat) {
                        sziget_sorozat_max = sziget_sorozat;
                    }
                }
            }

            int[] tomb = { sziget_sum, sziget_sorozat_max };
            return tomb;
        }

    }
}
