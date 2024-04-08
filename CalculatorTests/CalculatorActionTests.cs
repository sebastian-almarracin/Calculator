using Calculator;
using FluentAssertions;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorActionTests
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.0, 2, 4)]
        [InlineData(2.0, 2.0, 4.0)]
        [InlineData(6, 2, 8)]
        public void Add_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal expectedResult)
        {
            var result = CalculatorActions.Add(inp1, inp2);
            result.Should().Be(expectedResult);
        }
         
        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(2.0, 2, 0)]
        [InlineData(2.0, 2.0, 0.0)]
        [InlineData(6, 2, 4)]
        public void Subtract_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal expectedResult)
        {
            var result = CalculatorActions.Subtract(inp1, inp2);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.0, 2, 4)]
        [InlineData(2.0, 2.0, 4.0)]
        [InlineData(6, 2, 12)]
        public void Multiply_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal expectedResult)
        {
            var result = CalculatorActions.Multiply(inp1, inp2);
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2.0, 2, 1)]
        [InlineData(2.0, 2.0, 1.0)]
        [InlineData(6, 2, 3)]
        public void Divide_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal expectedResult)
        {
            var result = CalculatorActions.Divide(inp1, inp2);
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Divide_OfZero_ThrowsArgumentException()
        {
            decimal num = 0;
            Assert.Throws<ArgumentException>(() => CalculatorActions.Divide(num,num));
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        [InlineData(144, 12)]
        [InlineData(0, 0)]
        public void SquareRoot_OfPositiveNumber_ReturnsCorrectResult(decimal num, decimal expectedResult)
        { 
            decimal result = CalculatorActions.SquareRoot(num); 
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void SquareRoot_OfNegativeNumber_ThrowsArgumentException()
        { 
            decimal num = -16; 
            Assert.Throws<ArgumentException>(() => CalculatorActions.SquareRoot(num));
        }
    }
}