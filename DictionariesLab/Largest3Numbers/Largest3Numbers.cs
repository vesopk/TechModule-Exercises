using System;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var result = numbers.OrderByDescending(x => x).Take(3);
        Console.WriteLine(String.Join(" ",result));
    }
}

