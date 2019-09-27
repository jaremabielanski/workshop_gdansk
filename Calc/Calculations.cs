using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculations
    {

        public static float Oper(MathData md)
        {
            int a = md.firstNumber;
            int b = md.secondNumber;
            char op = md.operation;

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

            string a;

            while (true)
            {

                Console.Write("Wczytaj cyfrę:");
                a = Console.ReadLine();
                if (int.TryParse(a, out int tmp))
                {
                    Console.WriteLine("Can parse it: " + a);
                    return tmp;
                }
                else
                {
                    Console.WriteLine("Cannot parse it: " + tmp);
                    Console.WriteLine("Wczytaj jeszcze raz, podano złe wartości ...");
                }
            }

        }
    
        public static MathData GetAllValuesFromUser()
        {

            int firstNumber = Calculations.GetValueFromUser("Wczytaj pierwszą cyfrę: ");
            int secondNumber = Calculations.GetValueFromUser("Wczytaj pierwszą cyfrę: ");

            MathData mathData = new MathData(firstNumber, secondNumber, 'd');

            return mathData;
        }
    
    }
}
