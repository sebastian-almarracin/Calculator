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

        public static decimal SquareRoot(decimal num)
        {
            try
            {
                double result = double.Parse(num.ToString());
                if (result < 0)
                {
                    throw new ArgumentException("Cannot calculate square root of a negative number.");
                }
                return (decimal)Math.Sqrt(result);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid input. Please provide valid numeric strings.");
            }
        }

    }

}
