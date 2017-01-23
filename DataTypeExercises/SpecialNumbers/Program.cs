using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersEnd = int.Parse(Console.ReadLine());

            for (int number = 1; number <= numbersEnd; number++) 
            {
                int firstNumber = number / 10;
                int secondNumber = number % 10;
                int sum = firstNumber + secondNumber;
                bool canBeDividedBy5 = (sum == 5);
                bool canBeDividedBy7 = (sum == 7);
                bool canBeDividedBy11 = (sum == 1);
                bool isSpecial = canBeDividedBy5 || canBeDividedBy7 || canBeDividedBy11;

                if (isSpecial)
                {
                    Console.WriteLine($"{number} -> {isSpecial}");
                }
                else
                {
                    Console.WriteLine($"{number} -> {isSpecial}");
                }


            }
        }
    }
}
