namespace Calculator.Service.Interface
{
    public interface ICalculatorService
    {
        Task<int> Add(int value1, int value2);
        Task<int> Subtract(int value1, int value2);
        Task<int> Multiply(int value1, int value2);
        Task<int> Divide(int value1, int value2);
    }
}