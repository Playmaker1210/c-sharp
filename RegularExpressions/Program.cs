using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions {
    internal class Program {
        static void Main(string[] args) {
            /*Hivatalos dokumentáció a Regexről
             *https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
             *https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions
             *https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-6.0
             */

            Regex regex = new Regex("^[1-9][0-9]*");
            //a ^ karakter mondja meg hogy a strng elejétől kezdje
            //a keretes zárójelen belül egy karakter sorozatot adunk meg, ezek között keresi a találatot (ennek a tagadása [^1-9])
            //az első karakter sorozatot az első karakterrel vizsgálja a stringből
            //a következö karaktersorozat pedig az utánna lévő karaktereket vizsgája
            //a * nulla vagy több előfordulást jelent ebben az esetben a második karaktersorozatot nézi az első utáni összes karakterre
            //a $ jel jelöli a string végét

            string s1 = "012345";
            string s2 = "112345";
            string s3 = "2";

            Console.WriteLine("{0} {1}",s1,(regex.IsMatch(s1) ? "természetes szám" : "nem természetes szám"));
            Console.WriteLine("{0} {1}",s2,(regex.IsMatch(s2) ? "természetes szám" : "nem természetes szám"));
            Console.WriteLine("{0} {1}",s3,(regex.IsMatch(s3) ? "természetes szám" : "nem természetes szám"));

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            string s = @"^(\+)[1-9][0-9]{1,2}\s[1-9][0-9]{1,2}\s(\d{3}(-)){2}\d{3}$";
            Regex pattern = new Regex(s);
            //a @ azt jelöli hogy a string tartalmaz speciális karaktereket
            //a + jel elé egy \ kell írni mivel speciális karakter és a Regex is használja
            //a {1,2} az jelöli hogy a plusz jel után minimun egy de max két karakter állhat (az előtte lévő karaktersorozatra vonatkozik)
            //a \s egy szóközt jelöl
            //a \d számokat jelöl ez esetben (\d{3}) azt jelenti hogy 3 db szám jön egymás után pl: 123
            //ez után következzen két db kötőjel és ez kétszer fordul elő
            //majd a végén megismételjük a hármas számsorozatot csak a kötőjel nélkül

            string ss1 = "+36 30 661-345-612";
            string ss2 = "+3630 661-567-233";
            string ss3 = "+56 30 667-876-987-456";
            Console.WriteLine(pattern.IsMatch(ss1)); // true
            Console.WriteLine(pattern.IsMatch(ss2)); // false
            Console.WriteLine(pattern.IsMatch(ss3)); // false 


            ///////////////////////////////////////////////////////////////////////////////////////////
            //További felhasználási módok

            //Egy string részének az átírása
            string pattern2 = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
                         "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern2, String.Empty));


            //    Henry Hunt
            //    Sara Samuels
            //    Abraham Adams
            //    Nicole Norris


            //Duplikáció keresés
            string pattern3 = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            foreach (Match match in Regex.Matches(input, pattern3, RegexOptions.IgnoreCase))
                Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                                  match.Value, match.Groups[1].Value, match.Index);



            Console.ReadKey();
        }
    }
}
