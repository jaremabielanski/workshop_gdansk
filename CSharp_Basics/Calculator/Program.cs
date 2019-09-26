using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dzień dobry - liczymy ...");

            Console.Write("Wczytaj pierwszą cyfrę:");
            string a = Console.ReadLine();

            Console.Write("Wczytaj drugą cyfrę:");
            string b = Console.ReadLine();

            int dod = int.Parse(a) + int.Parse(b);
            int odej = int.Parse(a) - int.Parse(b);
            int mnoz = int.Parse(a) * int.Parse(b);
            int dziel = int.Parse(a) / int.Parse(b);

            Console.WriteLine("Odpowiednio wyniki: dod, odej, mnoż, dziel");
            Console.WriteLine(dod);
            Console.WriteLine(odej);
            Console.WriteLine(mnoz);
            Console.WriteLine(dziel);
            Console.ReadLine();

        }

        public static int Dodawanie(int a, int b)
        {
            return (a + b);
        }
    }
}
