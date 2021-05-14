using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TenMaturitaBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ahoj uživateli, napiš své jméno: ");
            string uzivatelovoJmeno = Console.ReadLine();
            Console.WriteLine("Tvé jméno je: " + uzivatelovoJmeno);

            Console.WriteLine("**********************************");

            int maximalniPocetCisel = 5;

            string[] randomCisla = new string[maximalniPocetCisel];

            for (int i = 0; i < maximalniPocetCisel; i++)
            {
                Console.Write("Napiš nám prosím nějaké random číslo: ");
                string randomCislo = Console.ReadLine();
                randomCisla[i] = randomCislo;
            }

            foreach (string cislo in randomCisla)
            {
                Console.WriteLine(cislo);
            }

            Console.WriteLine("*******************");

            int[] vycistenePole = VycistiPole(randomCisla);

            foreach (int cislo in vycistenePole)
            {
                Console.WriteLine(cislo);
            }

            Console.ReadKey();
        }

        public static int[] VycistiPole(string[] vstupniPole)
        {
            int number;
            List<int> procistenaCisla = new List<int>();

            foreach (string objekt in vstupniPole)
            {
                if (int.TryParse(objekt, out number))
                {
                    /*pro true*/
                    procistenaCisla.Add(Convert.ToInt32(objekt));
                }
                /*pro false*/
            }

            return procistenaCisla.ToArray();
        }


        public static int Soucet(int cisloJedna, int cisloDve)
        {
            return cisloJedna + cisloDve;
        }

        public void ExtraMethod()
        {
            char znak = 'a';
            string retezec;

            retezec = znak.ToString();
            retezec = Convert.ToString(znak);

            string[] poleRetezcu = new string[1];
            poleRetezcu[0] = retezec;

            List<string> kolekceRetezcu = new List<string>();
            kolekceRetezcu.Add(retezec);

            int cislo = 1;
            string konverzniCislo = "1";

            cislo = Convert.ToInt32(konverzniCislo);
            cislo = int.Parse(konverzniCislo);
            

            double desetineCislo = 1.2d;
            float cisloSPohyblivouCarkou = 1.2f;

            /*float cisloSPohyblivouCarkou -> double*/

            desetineCislo = (float)cisloSPohyblivouCarkou;

            /*
             * bod.X = (float) bodXDoubleZDatabase;
             * bod.Y = (float) bodYDoubleZDatabase;
             *
             */

            var dbl = 1.2d;
            var flt = 1.2f;

            String s;
            string s1;

            Int32 i;
            int i1;

            Single f;
            float f1;

            int[] poleCisel;
            List<int> kolekceCisel;

            decimal extraDesetineCislo;
        }
    }
}
