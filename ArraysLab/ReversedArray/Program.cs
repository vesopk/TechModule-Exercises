using System;

class Program
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] arr = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            arr[i] = number;
        }
        Array.Reverse(arr);
        Console.WriteLine(String.Join(" ", arr));
    }
}

