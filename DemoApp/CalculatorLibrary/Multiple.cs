using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Multiple : ICalculator
    {
        private int _result = 0;
        public void PerformCalcultion(int firstNumber, int secondNumber)
        {
            _result = firstNumber * secondNumber;
            Console.WriteLine(string.Format("Multltipcation of {0} and {1} = {2}", firstNumber, secondNumber, _result));
        }
    }
}
