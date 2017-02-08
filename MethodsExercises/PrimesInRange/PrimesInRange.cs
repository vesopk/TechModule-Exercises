using System;
using System.Collections.Generic;

    class PrimesInRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(String.Join(", ", primesInRange));

        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
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
}
