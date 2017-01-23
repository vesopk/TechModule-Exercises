using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuriesCount = int.Parse(Console.ReadLine());
            int years = centuriesCount * 100;
            double daysInYear = 365.2422;
            int days = (int)(years * daysInYear);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuriesCount} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
