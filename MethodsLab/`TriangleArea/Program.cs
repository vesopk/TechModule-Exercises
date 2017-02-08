using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
           double area = GetArea(height,width);
            Console.WriteLine(area);
        }

        public static double GetArea(double height, double width)
        {
            double area = (height * width) / 2;
            return area;
        }
    }
}
