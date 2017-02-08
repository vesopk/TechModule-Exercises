using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();



        }
        static void PrintReceipt()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string specialSymb = "\u00A9";
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0} SoftUni", specialSymb);
        }


    }
}

      