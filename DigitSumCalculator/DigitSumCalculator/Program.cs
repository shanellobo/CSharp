class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.ReadNumber();
        calculator.CalculateAndDisplaySum();

        Console.ReadKey();
    }
}
