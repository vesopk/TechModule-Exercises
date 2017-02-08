using System;

class FactorialTrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zerosCount = GetZerosFromFact(n);
        Console.WriteLine(zerosCount);
    }

    private static int GetZerosFromFact(int n)
    {
        int zerosCount = 0;
        int start = 1;
        while (n >= start)
        {
            start *= 5;
            zerosCount += (int)n / start;
        }
        return zerosCount;
    }
}


