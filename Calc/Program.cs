using System;
using System.Threading;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            MathData md = new MathData();
            Console.WriteLine("Dzień dobry, liczymy ...");

            md = Calculations.GetAllValuesFromUser();

            char[] charArray = { 'd', 'o', 'x', 'e' };

            Console.WriteLine("Odpowiednio wyniki: dod, odej, mnoż, dziel");
            foreach (char c in charArray)
                {
                md.operation = c;
                Console.WriteLine(Calculations.Oper(md));
                }

            Console.ReadLine();

        }

    }
}
