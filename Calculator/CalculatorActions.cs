using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorActions
    {
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal result = Convert.ToDecimal(num1) + Convert.ToDecimal(num2);
            return result;
        }

        public static decimal Subtract(decimal num1, decimal num2)
        {
            decimal result = Convert.ToDecimal(num1) - Convert.ToDecimal(num2);
            return result;
        }

        public static decimal Multiply(decimal num1, decimal num2)
        {
            decimal result = Convert.ToDecimal(num1) * Convert.ToDecimal(num2);
            return result;
        }

        public static decimal Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            var result = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
            return result;
        }


        //public string SquareRoot(string num)
        //{
        //    var result = (decimal)Math.Sqrt(Convert.ToDouble(num));

        //    return result.ToString();
        //}

        //public string Sine(string angleInDegrees)
        //{
        //    double angle = (double)Convert.ToDecimal(angleInDegrees);
        //    var result = (decimal)Math.Sin(Math.PI * angle / 180.0);
        //    return result.ToString();
        //}

        //public string Cosine(string angleInDegrees)
        //{
        //    double angle = (double)Convert.ToDecimal(angleInDegrees);
        //    var result = (decimal)Math.Cos(Math.PI * angle / 180.0);
        //    return result.ToString();
        //}

        //public string Tangent(string angleInDegrees)
        //{
        //    double angle = (double)Convert.ToDecimal(angleInDegrees);
        //    var result = (decimal)Math.Tan(Math.PI * angle / 180.0);
        //    return result.ToString();
        //}

        //public string Logarithm(string number, string newBase)
        //{
        //    double num = (double)Convert.ToDecimal(number);
        //    double baseVal = (double)Convert.ToDecimal(newBase);
        //    var result = (decimal)Math.Log(num, baseVal);

        //    return result.ToString();
        //}

    }

}
