using System;

namespace Factorial
{
    class Program
    {
        static int Factorial(int number)
        {
            if (number < 1) return 0;

            else if (number == 1) return 1;

            else return number * Factorial(number - 1);
        }

        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Console.WriteLine("Enter a Number: ");
                isNumber = Int32.TryParse(Console.ReadLine(), out int intNumber);
                if (isNumber) Console.WriteLine(Factorial(intNumber));
                else Console.WriteLine("Enter a Valid Number");

            } while (isNumber);
        }
        static void Main(string[] args)
        {
            RunFactorial();
        }
    }
}
