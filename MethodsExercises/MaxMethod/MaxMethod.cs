using System;


class MaxMethod
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int biggerOfFirstTwo = GetMax(firstNum, secondNum);
        int biggerOfTheRest = GetMax(biggerOfFirstTwo, thirdNum);
        Console.WriteLine(biggerOfTheRest);
    }

    public static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }
}

