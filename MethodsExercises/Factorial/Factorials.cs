using System;
using System.Numerics;

class Factorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = Factorial(n);
        Console.WriteLine(factorial);
    }
    public static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

