using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");

        // Try to get user input
        BigInteger number = ReadNumber();

        // Calculate and display the factorial
        BigInteger factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is: {factorial}");
        Console.ReadKey();
    }

    static BigInteger ReadNumber()
    {
        Console.Write("Enter a number: ");
        return BigInteger.Parse(Console.ReadLine());
    }

    static BigInteger CalculateFactorial(BigInteger num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }

        BigInteger result = 1;
        for (BigInteger i = 2; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }
}