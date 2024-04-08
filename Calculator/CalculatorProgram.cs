using Calculator;

namespace Cacluclator
{
    public class CalculatorProgram
    {
        private decimal? PreviousResult { get; set; }

        public bool HasPreviousResult => PreviousResult.HasValue;

        public string ReadInput(string value1, string action, string value2)
        {
            var input1 = DeserializeNumber(value1);

            var input2 = PreviousResult ?? DeserializeNumber(value2);
            decimal result;
            if (HasPreviousResult)
            {
                result = PerformAction(input2, input1, action);
            }
            else
            {
                result = PerformAction(input1, input2, action);
            }
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
                "v" => CalculatorActions.SquareRoot(input1),
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
