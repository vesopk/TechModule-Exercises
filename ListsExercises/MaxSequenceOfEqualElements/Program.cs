using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int maxNumbers = 0;
        int count = 1;
        int maxCount = 1;
        int position = 0;
        while (position < numbers.Count - 1) 
        {
            if (numbers[position] == numbers[position + 1]) 
            {
                count++;
                if (count>maxCount)
                {
                    maxCount = count;
                    maxNumbers = numbers[position];
                }
            }
            else
            {
                count = 1;
            }
            position++;
            if (maxCount==1)
            {
                maxNumbers = numbers[0];
            }
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(maxNumbers);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

