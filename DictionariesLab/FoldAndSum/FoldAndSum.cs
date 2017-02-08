using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int k = numbers.Length / 4;

        var firstLeftRow = numbers
            .Take(k)
            .Reverse()
            .ToArray();

        var firstRightRow = numbers
            .Reverse()
            .Take(k)
            .ToArray();

        var firstRow = firstLeftRow
            .Concat(firstRightRow)
            .ToArray();

        var secondRow = numbers
            .Skip(k)
            .Take(2 * k)
            .ToArray();

        var result = firstRow
            .Zip(secondRow, (x, y) => x + y)
            .ToArray();

        Console.WriteLine(string.Join(" ",result));
    }
}

