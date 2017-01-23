using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < 'a' + wordCount; firstLetter++) 
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + wordCount; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + wordCount; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
