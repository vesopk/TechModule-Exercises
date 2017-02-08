using System;
using System.Linq;

class NumbersInReverseOrder
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        ReverseNumbers(number);
    }

    private static void ReverseNumbers(string number)
    {
        number = new string(number.ToCharArray().Reverse().ToArray());
        Console.WriteLine(number);

    }
}

