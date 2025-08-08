using System;

namespace OddEvenChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                NumberChecker checker = new NumberChecker();
                if (checker.IsEven(number))
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}

