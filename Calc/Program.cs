using System;


namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dzień dobry - liczymy ...");

            int a = GetValueFromUser("Wczytaj pierwszą cyfrę:");

            int b = GetValueFromUser("Wczytaj pierwszą cyfrę:");

            char[] intArray = { 'd', 'o', 'x', 'e' };

            Console.WriteLine("Odpowiednio wyniki: dod, odej, mnoż, dziel");
            foreach (char c in intArray)
            {
                Console.WriteLine(Oper(a, b, c));
            }
            Console.ReadLine();
        }

        public static int Oper(int a, int b, char op)
        {

            switch (op)
            {
                case 'd':
                    {
                        return a + b;
                    }
                case 'o':
                    {
                        return a - b;
                    }
                case 'x':
                case '*':
                case 'm':
                    {
                        return a * b;
                    }
                case '/':
                case 'e':
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Nie dzielimy przez 0");
                            return 0;
                        }

                        return a / b;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        public static int GetValueFromUser(string messege)
        {
            Console.Write("Wczytaj drugą cyfrę:");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int tmp))
            {
                Console.WriteLine("Can parse it: " + a);
                return tmp;
            }
            else
            {
                Console.WriteLine("Cannot parse it: " + tmp);
                Console.ReadLine();
                return tmp;
            }

        }

    }
}
