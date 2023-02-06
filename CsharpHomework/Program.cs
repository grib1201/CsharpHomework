using CsharpHomework;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapesListNumber1 = new List<Shape>();
        List<Shape> shapesListNumber2 = new List<Shape>();

        // Circles
        List<Point> circlePoints1 = new List<Point>() { new Point(5, 5) };
        var Circle1 = new Circle(circlePoints1);
        Circle1.Radius = 10;

        List<Point> circlePoints2 = new List<Point>() { new Point(1, 2) };
        var Circle2 = new Circle(circlePoints2);
        Circle2.Radius = 4;

        List<Point> circlePoints3 = new List<Point>() { new Point(-1, -4) };
        var Circle3 = new Circle(circlePoints3);
        Circle3.Radius = 5;

        //Triangles
        List<Point> trianglePoints1 = new List<Point>() {
            new Point(0, 1),
            new Point(2, 5),
            new Point(5, 4)
        };
        var Triangle1 = new Triangle(trianglePoints1);

        List<Point> trianglePoints2 = new List<Point>() {
            new Point(0, -1),
            new Point(3, 5),
            new Point(4, 7)
        };
        var Triangle2 = new Triangle(trianglePoints2);

        List<Point> trianglePoints3 = new List<Point>() {
            new Point(2, 3),
            new Point(3, 4),
            new Point(4, 5)
        };
        var Triangle3 = new Triangle(trianglePoints3);

        //Rectangles
        List<Point> rectanglePoints1 = new List<Point>() {
            new Point(0, 3),
            new Point(1, 4),
            new Point(2, 3),
            new Point(1, 2)
        };
        var Rectangle1 = new Rectangle(rectanglePoints1);

        List<Point> rectanglePoints2 = new List<Point>() {
            new Point(-2, -3),
            new Point(-1, -4),
            new Point(-2, -3),
            new Point(-1, -2)
        };

        var Rectangle2 = new Rectangle(rectanglePoints2);

        List<Point> rectanglePoints3 = new List<Point>() {
            new Point(2, 8),
            new Point(3, 8),
            new Point(2, -8),
            new Point(-3, -8)
        };
        var Rectangle3 = new Rectangle(rectanglePoints3);

        shapesListNumber1.Add(Circle1);
        shapesListNumber1.Add(Circle2);
        shapesListNumber1.Add(Triangle1);
        shapesListNumber1.Add(Rectangle1);
        shapesListNumber1.Add(Rectangle2);

        shapesListNumber2.Add(Circle3);
        shapesListNumber2.Add(Triangle2);
        shapesListNumber2.Add(Triangle3);
        shapesListNumber2.Add(Rectangle3);

        new DoAreasComparation().SortList(shapesListNumber1);
        new DoAreasComparation().SortList(shapesListNumber2);
        Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber1));
        Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber2));


    }

    public class DoAreasComparation : ISorter
    {
        public void SortList(List<Shape> shapes)
        {
            shapes.Sort(delegate (Shape x, Shape y)
            {
                return x.CountArea().CompareTo(y.CountArea());
            });
        }

    }

    // Point class exersizes
    //Point point = new Point(0, 6);
    //Point point2 = new Point(1, 1);
    //Point point3 = point.Add(point2);

    //Console.WriteLine($"Point: x={point3.x}, y={point3.y}");
    
}