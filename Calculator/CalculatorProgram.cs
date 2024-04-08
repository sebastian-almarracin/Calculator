using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacluclator
{
    public class CalculatorProgram
    {
        private decimal? PreviousResult { get; set; }

        public bool HasPreviousResult => PreviousResult.HasValue;

        public string ReadInput(string value1, string action, string value2)
        {
            var input1 = DeserializeNumber(value1);

            var input2 = PreviousResult.HasValue ? PreviousResult.Value : DeserializeNumber(value2);
            var result = PerformAction(input1, input2, action);
            PreviousResult = result;
            return result.ToString();
        }

        private static decimal PerformAction(decimal input1, decimal input2, string action)
        {
            return action switch
            {
                "+" => CalculatorActions.Add(input1, input2),
                "-" => CalculatorActions.Subtract(input1, input2),
                "*" => CalculatorActions.Multiply(input1, input2),
                "/" => CalculatorActions.Divide(input1, input2),
                _ => throw new ArgumentException("Invalid input. Please provide valid calculator function."),
            };
        }

        private static decimal DeserializeNumber(string str)
        {
            var isValid = decimal.TryParse(str, out decimal result);
            if (isValid)
            {
                return result;
            }
            throw new ArgumentException("Invalid input. Please provide valid numeric strings.");
        }
    }
}
