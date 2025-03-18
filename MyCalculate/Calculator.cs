using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculate
{
    internal class Calculator : ICalculator
    {
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Minus(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiple(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
