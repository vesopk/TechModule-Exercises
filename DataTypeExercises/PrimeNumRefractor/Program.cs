using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumRefractor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsEnd = int.Parse(Console.ReadLine());
            for (int number = 2; number <= numsEnd; number++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }


        }
    }
}
