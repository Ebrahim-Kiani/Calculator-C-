using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculate
{
    internal interface ICalculator
    {
        int Plus(int num1, int num2);

        int Minus(int num1, int num2);

        int Divide(int num1, int num2);

        int Multiple(int num1, int num2);

    }
}
