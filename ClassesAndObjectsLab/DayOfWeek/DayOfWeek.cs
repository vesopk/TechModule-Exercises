using System;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {
        var input = Console.ReadLine();
        var format = "d-M-yyyy";
        var date = DateTime.ParseExact(input,format,CultureInfo.InvariantCulture);
        var day = date.DayOfWeek;
        Console.WriteLine(day);
        
    }
}

