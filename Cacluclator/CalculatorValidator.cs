using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorValidator
    {
        public static bool IsValidInput(string num1, string num2)
        {
            if (!IsValidNumber(num1) || !IsValidNumber(num2))
            { 
                throw new ArgumentException("Invalid input. Please provide valid numeric strings.");
            }
            return true;
        }

        private static bool IsValidNumber(string str)
        {
            decimal result;
            return decimal.TryParse(str, out result);
        }
    }
}
