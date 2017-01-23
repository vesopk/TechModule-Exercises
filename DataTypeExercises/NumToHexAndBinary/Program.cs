using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInDec = int.Parse(Console.ReadLine());
            string numberInHex = Convert.ToString(numberInDec, 16).ToUpper();
            string numberInBinary = Convert.ToString(numberInDec,2).ToUpper();

            Console.WriteLine(numberInHex);
            Console.WriteLine(numberInBinary);
        }
    }
}
