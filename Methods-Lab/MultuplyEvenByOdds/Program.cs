using System;


namespace MultuplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(numbers);
            Console.WriteLine(result);

        }

        static int GetMultipleOfEvenAndOdds(int n)
        {
            int sumOfEvens = GetSumOfEvenDigits(Math.Abs(n));
            int sumOfOdds = GetSumOfOddDigits(Math.Abs(n));
            int result = sumOfEvens * sumOfOdds;
            return result;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 !=0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

    }
}
