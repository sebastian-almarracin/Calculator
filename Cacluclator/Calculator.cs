using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public string Add(string num1, string num2)
        {
            decimal result = 0.0m;
            if (CalculatorValidator.IsValidInput(num1, num2))
            {
                result = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);
            }
            return result.ToString();
        }

        public string Subtract(string num1, string num2)
        {
            decimal result = 0.0m;
            if (CalculatorValidator.IsValidInput(num1, num2))
            {
                result = Convert.ToDecimal(num1) - Convert.ToDecimal(num2);
            }
            return result.ToString();
        }

        public string Multiply(string num1, string num2)
        {
            decimal result = 0.0m;
            if (CalculatorValidator.IsValidInput(num1, num2))
            {
                result = Convert.ToDecimal(num1) * Convert.ToDecimal(num2);
            }
            return result.ToString();
        }

        public string Divide(string num1, string num2)
        {
            decimal result = 0.0m;

            decimal num2Value = Convert.ToDecimal(num2);
            if (num2Value == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            if (CalculatorValidator.IsValidInput(num1, num2))
            {
                result = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
            }
            return result.ToString(); 
        }

    }

}
