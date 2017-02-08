using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> squares = new List<int>();

        foreach (int number in numbers)
        {
            if (Math.Sqrt(number) == (int)Math.Sqrt(number))
            {
                squares.Add(number);
            }
        }
        squares.Sort();
        squares.Reverse();
        Console.WriteLine(String.Join(" ",squares));
    }
}

