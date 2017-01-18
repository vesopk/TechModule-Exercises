using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersEnd = int.Parse(Console.ReadLine());
            
           

            for (int i = 1; i <= numbersEnd; i++)
            {
                bool isSpecial = false;
                int sum = 0;
                int number = 0;
                number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{number} -> {isSpecial}");
                sum = 0;
                i = number;
            }


        }
    }
}
