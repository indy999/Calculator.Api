using Calculator.Service;
using FluentAssertions;
using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorServiceShould
    {
        private readonly CalculatorService calculatorService;

        public CalculatorServiceShould()
        {
            calculatorService = new CalculatorService();
        }

        [TestCase(1, 2, 3)]
        [TestCase(10, 2, 12)]
        public async Task AddValuesSuccessfully(int value1, int value2, int expectedValue)
        {
            var result = await calculatorService.Add(value1, value2);

            result.Should().Be(expectedValue);
        }

        [TestCase(5, 2, 3)]
        [TestCase(10, 3, 7)]
        public async Task SubtractValuesSuccessfully(int value1, int value2, int expectedValue)
        {
            var result = await calculatorService.Subtract(value1, value2);

            result.Should().Be(expectedValue);
        }

        [TestCase(10, 2, 20)]
        [TestCase(100, 3, 300)]
        public async Task MultiplySuccessfully(int value1, int value2, int expectedValue)
        {
            var result = await calculatorService.Multiply(value1, value2);

            result.Should().Be(expectedValue);
        }

        [TestCase(20, 5, 4)]
        [TestCase(15, 7, 2)]
        public async Task DivideSuccessfully(int value1, int value2, int expectedValue)
        {
            var result = await calculatorService.Divide(value1, value2);

            result.Should().Be(expectedValue);
        }


    }
}