using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator Calculator;

        [SetUp]
        public void Setup()
        {
            Calculator = new Calculator();
        }

        [Test]
        public void Add_ValidNumbers_ReturnsCorrectResult()
        {
            string num1 = "10";
            string num2 = "5";
            var calculator = new Calculator();

            var action = () => calculator.Add(num1, num2);

            Assert.That(action(), Is.EqualTo("15"));
        }

        [Test]
        public void Add_ValidDecimals_ReturnsCorrectResult()
        {
            string num1 = "10.1";
            string num2 = "5.22";
            var calculator = new Calculator();

            var action = () => calculator.Add(num1, num2);

            Assert.That(action(), Is.EqualTo("15.32"));
        }


        [Test]
        public void Add_InvalidNumbers_ReturnsZero()
        {
            string num1 = "abc";
            string num2 = "5";
            var calculator = new Calculator();

            var action = () => calculator.Add(num1, num2);

            Assert.Throws<ArgumentException>(() => action());
        }

        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            string num1 = "";
            string num2 = "5";
            var calculator = new Calculator();

            var action = () => calculator.Add(num1, num2);

            Assert.Throws<ArgumentException>(() => action());
        }

        [Test]
        public void Subtract_ValidNumbers_ReturnsCorrectResult()
        {
            string num1 = "10";
            string num2 = "5";

            var action = () => Calculator.Subtract(num1, num2);

            Assert.That(action(), Is.EqualTo("5"));
        }

        [Test]
        public void Subtract_ValidDecimals_ReturnsCorrectResult()
        {
            string num1 = "10.1";
            string num2 = "5.22";

            var action = () => Calculator.Subtract(num1, num2);

            Assert.That(action(), Is.EqualTo("4.88"));
        }

        [Test]
        public void Subtract_InvalidNumbers_ThrowsArgumentException()
        {
            string num1 = "abc";
            string num2 = "5";

            var action = () => Calculator.Subtract(num1, num2);
            Assert.Throws<ArgumentException>(() => action());
        }

        [Test]
        public void Subtract_EmptyString_ThrowsArgumentException()
        {
            string num1 = "";
            string num2 = "5";
             
            var action = () => Calculator.Subtract(num1, num2);
            Assert.Throws<ArgumentException>(() => action()); 
        }

        [Test]
        public void Multiply_ValidNumbers_ReturnsCorrectResult()
        {
            string num1 = "10";
            string num2 = "5";

            var action = () => Calculator.Multiply(num1, num2);

            Assert.That(action(), Is.EqualTo("50")); 
        }

        [Test]
        public void Multiply_ValidDecimals_ReturnsCorrectResult()
        {
            string num1 = "10.1";
            string num2 = "5.22";

            var action = () => Calculator.Multiply(num1, num2);

            Assert.That(action(), Is.EqualTo("52.722")); 
        }

        [Test]
        public void Multiply_InvalidNumbers_ThrowsArgumentException()
        {
            string num1 = "abc";
            string num2 = "5";

            var action = () => Calculator.Multiply(num1, num2); 
            Assert.Throws<ArgumentException>(() => action()); 
        }

        [Test]
        public void Multiply_EmptyString_ThrowsArgumentException()
        {
            string num1 = "";
            string num2 = "5";

            var action = () => Calculator.Multiply(num1, num2);
            Assert.Throws<ArgumentException>(() => action()); 
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsCorrectResult()
        {
            string num1 = "10";
            string num2 = "5";

            var action = () => Calculator.Divide(num1, num2);
            Assert.That(action(), Is.EqualTo("2"));  
        }

        [Test]
        public void Divide_ValidDecimals_ReturnsCorrectResult()
        {
            string num1 = "10.1";
            string num2 = "5.05";

            var action = () => Calculator.Divide(num1, num2);
            Assert.That(action(), Is.EqualTo("2"));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsArgumentException()
        {
            string num1 = "10";
            string num2 = "0";

            var action = () => Calculator.Divide(num1, num2);
            Assert.Throws<ArgumentException>(() => action());
        }

        [Test]
        public void Divide_InvalidNumbers_ThrowsArgumentException()
        {
            string num1 = "abc";
            string num2 = "5";

            var action = () => Calculator.Divide(num1, num2);
            Assert.Throws<ArgumentException>(() => action());
        }

        [Test]
        public void Divide_EmptyString_ThrowsArgumentException()
        {
            string num1 = "";
            string num2 = "5";

            var action = () => Calculator.Divide(num1, num2);
            Assert.Throws<ArgumentException>(() => action());
        }
    }
}