using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }
        static void PrintSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else if (num == 0)
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
            else if (num > 0) 
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
        }

    }
}
