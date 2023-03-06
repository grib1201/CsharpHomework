using CsharpHomework;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapesListNumber1 = new List<Shape>();
        List<Shape> shapesListNumber2 = new List<Shape>();

        // Circles
        var Circle1 = new Circle(new Point(5, 5));
        Circle1.Radius = 10;

        var Circle2 = new Circle(new Point(1, 2));
        Circle2.Radius = 4;

        var Circle3 = new Circle(new Point(-1, -4));
        Circle3.Radius = 5;

        //Triangles
        var Triangle1 = new Triangle(new Point(0, 1), new Point(2, 5), new Point(5, 4));
        var Triangle2 = new Triangle(new Point(0, -1), new Point(3, 5), new Point(4, 7));
        var Triangle3 = new Triangle(new Point(2, 3), new Point(3, 4), new Point(4, 5));

        //Rectangles
        var Rectangle1 = new Rectangle(new Point(0, 3), new Point(1, 4));
        var Rectangle2 = new Rectangle(new Point(-2, -3), new Point(-1, -4));
        var Rectangle3 = new Rectangle(new Point(2, 8), new Point(3, 8));

        shapesListNumber1.Add(Circle1);
        shapesListNumber1.Add(Circle2);
        shapesListNumber1.Add(Triangle1);
        shapesListNumber1.Add(Rectangle1);
        shapesListNumber1.Add(Rectangle2);

        shapesListNumber2.Add(Circle3);
        shapesListNumber2.Add(Triangle2);
        shapesListNumber2.Add(Triangle3);
        shapesListNumber2.Add(Rectangle3);

        shapesListNumber1.Sort();
        shapesListNumber2.Sort();

        Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber1));
        Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber2));



    }

    //1
    // Point class exersizes
    //Point point = new Point(0, 6);
    //Point point2 = new Point(1, 1);
    //Point point3 = point.Add(point2);

    //Console.WriteLine($"Point: x={point3.x}, y={point3.y}");
    
}