using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Point> points = new List<Point>();
        for (int i = 0; i < n; i++)
        {
            double[] currentPoint = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            points.Add(new Point
            {
                X = currentPoint[0],
                Y = currentPoint[1]
            });
        }

        double minDistanceSoFar = double.MaxValue;
        Point firstPointMax = null;
        Point secondPointMax = null;

        for (int i = 0; i < points.Count - 1; i++)
        {
            for (int j = i+1; j < points.Count; j++)
            {
                Point firstPoint = points[i];
                Point secondPoint = points[j];
                var currentDistance = CalculateDistance(firstPoint,secondPoint);
                if (currentDistance < minDistanceSoFar) 
                {
                    minDistanceSoFar = currentDistance;
                    firstPointMax = firstPoint;
                    secondPointMax = secondPoint;
                }
            }
        }
        Console.WriteLine(minDistanceSoFar);
        Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
        Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");
    }
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y - secondPoint.Y;
        var powX = Math.Pow(diffX, 2);
        var powY = Math.Pow(diffY, 2);
        return Math.Sqrt(powX + powY);
    }
}
class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}

