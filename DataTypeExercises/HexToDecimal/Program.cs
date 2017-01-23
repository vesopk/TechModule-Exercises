using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            string hexFormat = Console.ReadLine();
            int hexToDecimal = Convert.ToInt32(hexFormat,16);
            Console.WriteLine(hexToDecimal);
        }
    }
}
