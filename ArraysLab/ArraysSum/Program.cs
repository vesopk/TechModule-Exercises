using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] firstNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = Math.Max(firstNums.Length, secondNums.Length);
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = firstNums[i % firstNums.Length] + secondNums[i % secondNums.Length];

        }
        Console.WriteLine(string.Join(" ", result));
    }
}

