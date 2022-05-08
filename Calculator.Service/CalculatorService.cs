using Calculator.Service.Interface;

namespace Calculator.Service
{
    public class CalculatorService : ICalculatorService
    {
        public Task<int> Add(int value1, int value2) => Task.FromResult(value1 + value2);
        public Task<int> Divide(int value1, int value2) => Task.FromResult(value1 / value2);
        public Task<int> Multiply(int value1, int value2) => Task.FromResult(value1 * value2);
        public Task<int> Subtract(int value1, int value2) => Task.FromResult(value1 - value2);
    }
}