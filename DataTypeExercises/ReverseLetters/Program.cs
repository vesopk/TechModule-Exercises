﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string thirdLetter = Console.ReadLine();

            Console.WriteLine($"{thirdLetter}{secondLetter}{firstLetter}");
        }
    }
}
