using System;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine().Split(' ').ToArray();
        Array.Reverse(text);
        Console.WriteLine(String.Join(" ",text));
    }
}

