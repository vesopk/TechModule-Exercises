using System;
using System.Linq;

class RectanglePosition
{
    static void Main()
    {
        int[] firstNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Rectangle r1 = new Rectangle { Left = firstNums[0], Top = firstNums[1], Width = firstNums[2], Height = firstNums[3] };
        Rectangle r2 = new Rectangle { Left = secondNums[0], Top = secondNums[1], Width = secondNums[2], Height = secondNums[3] };
        Console.WriteLine(r1.IsInside(r2) ? "Inside" :
        "Not inside");
    }
}

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }
    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    int CalculateArea()
    {
        return Width * Height;
    }

    public bool IsInside(Rectangle r)
    {
        return (r.Left <= Left) && (r.Right >= Right) &&
        (r.Top <= Top) && (r.Bottom >= Bottom);
    }
}