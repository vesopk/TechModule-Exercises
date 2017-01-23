using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());

            for (int i = startingNum; i <= endingNum; i++)
            {
                Console.Write("{0} ",(char)i);
            }
            Console.WriteLine();
        }
    }
}
