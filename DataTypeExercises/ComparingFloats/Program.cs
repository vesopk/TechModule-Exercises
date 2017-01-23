using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double difference = Math.Abs(firstNum-secondNum);
            if (difference < 0.000001)
            {
                Console.WriteLine(true);
            }
            else if (difference == 0.000001)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
