using Cacluclator;
using Calculator;
using FluentAssertions;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorProgramTests
    {
        public CalculatorProgram CalculatorProgram { get; set; }

        public CalculatorProgramTests()
        {
            CalculatorProgram = new CalculatorProgram();
        }

        [Theory]
        [InlineData("2", "2", "4", "8", "+")]
        [InlineData("2", "2", "6", "10", "+")]
        [InlineData("2", "2", "8", "12", "+")]
        public void Add_PrevNumbers_ReturnsCorrectResult(string inp1, string inp2, string inp3, string result, string action)
        {
            CalculatorProgram.ReadInput(inp1, action, inp2);
            var programPrevResult = CalculatorProgram.ReadInput(inp3, action, "0");
            programPrevResult.Should().Be(result);
        }
         
        [Theory]
        [InlineData("14", "2", "4", "8", "-")]
        [InlineData("14", "2", "6", "6", "-")]
        [InlineData("14", "2", "8", "4", "-")]
        public void Subtract_PrevNumbers_ReturnsCorrectResult(string inp1, string inp2, string inp3, string result, string action)
        {
            CalculatorProgram.ReadInput(inp1, action, inp2);
            var programPrevResult = CalculatorProgram.ReadInput(inp3, action, "0");
            programPrevResult.Should().Be(result);
        }
         
        [Theory]
        [InlineData("120", "2", "4", "15", "/")]
        [InlineData("120", "2", "6", "10", "/")]
        [InlineData("120", "2", "8", "7.5", "/")]
        public void Divide_PrevNumbers_ReturnsCorrectResult(string inp1, string inp2, string inp3, string result, string action)
        {
            CalculatorProgram.ReadInput(inp1, action, inp2);
            var programPrevResult = CalculatorProgram.ReadInput(inp3, action, "0");
            programPrevResult.Should().Be(result);
        }
         
        [Theory]
        [InlineData("140", "2", "4", "1120", "*")]
        [InlineData("365", "2", "6", "4380", "*")]
        [InlineData("984", "2", "8", "15744", "*")]
        public void Multiply_PrevNumbers_ReturnsCorrectResult(string inp1, string inp2, string inp3, string result, string action)
        {
            CalculatorProgram.ReadInput(inp1, action, inp2);
            var programPrevResult = CalculatorProgram.ReadInput(inp3, action, "0");
            programPrevResult.Should().Be(result);
        }
    }
}
