using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        bool isPrime = IsPrime(n);
        Console.WriteLine(isPrime);
    }

    private static bool IsPrime(long number)
    {
        if (number == 1 || number == 0)
        {
            return false;
        }
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
        return isPrime;
    }
}

