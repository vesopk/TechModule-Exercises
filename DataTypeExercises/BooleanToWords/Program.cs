using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string booleanType = Console.ReadLine();
            bool boolean = Convert.ToBoolean(booleanType);
            if (boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
