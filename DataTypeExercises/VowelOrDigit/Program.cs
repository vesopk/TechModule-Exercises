using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            
            try
            {
                int value = Int32.Parse(input); Console.WriteLine("digit");
            }
            catch (Exception)
            {

                if (input=="a")
                {
                    Console.WriteLine("vowel");
                }
                else if (input=="e")
                {
                    Console.WriteLine("vowel");
                }
                else if (input == "i")
                {
                    Console.WriteLine("vowel");
                }
                else if (input == "o")
                {
                    Console.WriteLine("vowel");
                }
                else if (input == "u")
                {
                    Console.WriteLine("vowel");
                }
                else if (input == "y")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
