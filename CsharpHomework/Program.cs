using CsharpHomework;

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(0, 6);
        Point point2 = new Point(1, 1);
        Point point3 = point.Add(point2);

        Console.WriteLine($"Point: x={point3.x}, y={point3.y}");
    }
}