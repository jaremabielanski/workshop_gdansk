using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class MathData
    {
        public int firstNumber;
        public int secondNumber;
        public char operation;

        public MathData(int first, int second, char op)
        {
            firstNumber = first;
            secondNumber = second;
            operation = op;
        }

        public MathData()
        { 
        }

    }
}
