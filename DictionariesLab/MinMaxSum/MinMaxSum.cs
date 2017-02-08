using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSum
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        List<double> numbers = new List<double>();
        for (int i = 0; i < numbersCount; i++)
        {
            double number = double.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}

