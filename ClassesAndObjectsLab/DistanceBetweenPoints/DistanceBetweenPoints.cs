using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main()
    {
        double[] pointOneValues = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] pointTwoValues = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        Point firstPoint = new Point { X = pointOneValues[0], Y = pointOneValues[1] };
        Point secondPoint = new Point { X = pointTwoValues[0], Y = pointTwoValues[1] };

        double result = CalculateDistance(firstPoint,secondPoint);
        Console.WriteLine($"{result:f3}");
    }
    public static double CalculateDistance(Point firstPoint,Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y - secondPoint.Y;
        var powX = Math.Pow(diffX,2);
        var powY = Math.Pow(diffY, 2);
        return Math.Sqrt(powX + powY);
    }
}
class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

