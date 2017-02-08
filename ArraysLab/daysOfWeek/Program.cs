using System;

class Program
{
    static void Main()
    {
        int dayNum = int.Parse(Console.ReadLine());
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        if (dayNum == 1)
        {
            Console.WriteLine(daysOfWeek[0]);
        }
        else if (dayNum == 2)
        {
            Console.WriteLine(daysOfWeek[1]);
        }
        else if (dayNum == 3)
        {
            Console.WriteLine(daysOfWeek[2]);
        }
        else if (dayNum == 4)
        {
            Console.WriteLine(daysOfWeek[3]);
        }
        else if (dayNum == 5)
        {
            Console.WriteLine(daysOfWeek[4]);
        }
        else if (dayNum == 6)
        {
            Console.WriteLine(daysOfWeek[5]);
        }
        else if (dayNum == 7)
        {
            Console.WriteLine(daysOfWeek[6]);
        }
        else
        {
            Console.WriteLine("Invalid day");
        }
    }
}

