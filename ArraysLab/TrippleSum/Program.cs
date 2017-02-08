using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool foundTripple = false;
        for (int a = 0; a < numbers.Length; a++)
        {
            for (int b = a + 1; b < numbers.Length; b++)
            {
                int sum = numbers[a] + numbers[b];
                if (numbers.Contains(sum))
                {
                    foundTripple = true;
                    Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                    
                }

            }
        }
        if (!foundTripple)
        {
            Console.WriteLine("No");
        }
    }
}

