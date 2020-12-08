using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static void Calculate()
        {
            ICalculator add = new Add();
            ICalculator multiple = new Multiple();
            ICalculator subtract = new Subtraction();
            ICalculator divide = new Divide();
            add.PerformCalcultion(3, 4);
            multiple.PerformCalcultion(2, 3);
            subtract.PerformCalcultion(4, 4);
            divide.PerformCalcultion(10, 2);
        }
    }
}
