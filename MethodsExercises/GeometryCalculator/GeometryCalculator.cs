using System;

class GeometryCalculator
{
    static void Main()
    {
        string figureType = Console.ReadLine().ToLower();

        if (figureType == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindTriangleArea(side, height));
        }
        else if (figureType == "square")
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindRectangleArea(side, side));
        }
        else if (figureType == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindRectangleArea(width, height));
        }
        else if (figureType == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", FindRectangleArea(radius));
        }
    }

    private static double FindRectangleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    private static double FindRectangleArea(double width, double height)
    {
        double area = width * height;
        return area;
    }

    private static double FindTriangleArea(double side, double height)
    {
        double area = (side * height) / 2;
        return area;
    }
}

