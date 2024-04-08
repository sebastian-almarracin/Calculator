using Calculator;
using FluentAssertions;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.0, 2, 4)]
        [InlineData(2.0, 2.0, 4.0)]
        [InlineData(6, 2, 8)]
        public void Add_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal result)
        {
            var action = CalculatorActions.Add(inp1, inp2);
            action.Should().Be(result);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(2.0, 2, 0)]
        [InlineData(2.0, 2.0, 0.0)]
        [InlineData(6, 2, 4)]
        public void Subtract_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal result)
        {
            var action = CalculatorActions.Subtract(inp1, inp2);
            action.Should().Be(result);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.0, 2, 4)]
        [InlineData(2.0, 2.0, 4.0)]
        [InlineData(6, 2, 12)]
        public void Multiply_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal result)
        {
            var action = CalculatorActions.Multiply(inp1, inp2);
            action.Should().Be(result);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2.0, 2, 1)]
        [InlineData(2.0, 2.0, 1.0)]
        [InlineData(6, 2, 3)]
        public void Divide_Numbers_ReturnsCorrectResult(decimal inp1, decimal inp2, decimal result)
        {
            var action = CalculatorActions.Divide(inp1, inp2);
            action.Should().Be(result);
        }

    }
}