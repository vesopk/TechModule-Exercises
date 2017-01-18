using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int coursesNeeded = (int)Math.Ceiling((double)capacityOfPeople / capacityOfElevator);

            Console.WriteLine(coursesNeeded);
        }
    }
}
