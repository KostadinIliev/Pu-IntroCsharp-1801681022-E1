using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[] operations = { '+', '-', '*', '/' };
            double result = 0;

            while (true)
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes,no)");
                input = Console.ReadLine();
                if (input == "no")
                {
                    break;
                }
                else if (input == "yes")
                {
                    Console.WriteLine("Enter first number: ");
                    double firstNUmber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter operation: ");
                    string inputOperation = Console.ReadLine();
                    char operation;
                }
            }
        }
    }
}
