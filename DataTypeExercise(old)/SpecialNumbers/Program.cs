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
            
            


            for (int number = 1; number <=numbersEnd; number++)
            {

                int firstDigit = number / 10;
                int secondDigit = number % 10;
                int sumOfFirstAndLastDigit = firstDigit + secondDigit;
                bool isSumOfFirstAndLastDigitEqualToFive = (sumOfFirstAndLastDigit == 5);
                bool isSumOfFirstAndLastDigitEqualToSeven = (sumOfFirstAndLastDigit == 7);
                bool isSumOfFirstAndLastDigitEqualToEleven = (sumOfFirstAndLastDigit == 11);

                bool isSpecial = isSumOfFirstAndLastDigitEqualToFive || isSumOfFirstAndLastDigitEqualToSeven || isSumOfFirstAndLastDigitEqualToEleven;


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
