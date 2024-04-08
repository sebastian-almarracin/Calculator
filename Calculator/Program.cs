using Cacluclator;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorProgram();

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            while (true)
            {
                try
                {
                    Console.Write("Enter number 1: ");
                    var num1 = Console.ReadLine();

                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                    Console.WriteLine("\tv : SquareRoot");
                    Console.Write("Enter an option: ");
                    var action = Console.ReadLine();

                    Console.Write("Enter number 2: ");
                    var num2 = Console.ReadLine();

                    var result = calc.ReadInput(num1, action, num2);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}