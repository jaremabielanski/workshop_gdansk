using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
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

            char[] intArray = { 'd', 'o', 'm', 'e' };

            Console.WriteLine("Odpowiednio wyniki: dod, odej, mnoż, dziel");
            foreach (char c in intArray)
            {
                Console.WriteLine(Oper(int.Parse(a), int.Parse(b), c));
            }
            Console.ReadLine();
        }

        public static int Oper(int a, int b, char op)
        {
            switch (op)
            {
                case 'd':
                    {
                        return (a + b);
                    }
                case 'o':
                    {
                        return (a - b);
                    }
                case 'm':
                    {
                        return (a * b);
                    }
                case 'e':
                    {
                        return (a / b);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
