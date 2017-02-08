using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var result = new SortedDictionary<double, int>();

        foreach (var number in numbers)
        {
            if (!result.ContainsKey(number))
            {
                result[number] = 0;
            }
            result[number]++;
        }
        foreach (var number in result)
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}

