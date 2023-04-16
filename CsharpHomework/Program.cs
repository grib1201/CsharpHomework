using CsharpHomework;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapesListNumber1 = new List<Shape>();
        List<Shape> shapesListNumber2 = new List<Shape>();

        // Circles
        var CircleBlueSolid = new Circle(new Point(5, 5), new Color("blue"), new Contour("solid"));
        CircleBlueSolid.Radius = 10;

        var CircleRedSolid = new Circle(new Point(1, 2), new Color("red"), new Contour("solid"));
        CircleRedSolid.Radius = 4;

        var CircleYellowDashed = new Circle(new Point(-1, -4), new Color("yellow"), new Contour("dashed"));
        CircleYellowDashed.Radius = 5;

        //Triangles
        var TriangleYellowDashed = new Triangle(new Point(0, 1), new Point(2, 5), new Point(5, 4), new Color("yellow"), new Contour("dashed"));
        var TriangleWhiteDashDotted = new Triangle(new Point(0, -1), new Point(3, 5), new Point(4, 7), new Color("white"), new Contour("dashDotted"));
        var TriangleBlueDashDotted = new Triangle(new Point(2, 3), new Point(3, 4), new Point(4, 5), new Color("blue"), new Contour("dashDotted"));

        //Rectangles
        var RectangleWhiteSolid = new Rectangle(new Point(0, 3), new Point(1, 4), new Color("white"), new Contour("solid"));
        var RectangleBlueSolid = new Rectangle(new Point(-2, -3), new Point(-1, -4), new Color("blue"), new Contour("solid"));
        var RectangleRedDashDotted = new Rectangle(new Point(2, 8), new Point(3, 8), new Color("red"), new Contour("dashDotted"));

        shapesListNumber1.Add(CircleBlueSolid);
        shapesListNumber1.Add(CircleRedSolid);
        shapesListNumber1.Add(TriangleYellowDashed);
        shapesListNumber1.Add(RectangleWhiteSolid);
        shapesListNumber1.Add(RectangleBlueSolid);

        shapesListNumber1.Add(CircleYellowDashed);
        shapesListNumber1.Add(TriangleWhiteDashDotted);
        shapesListNumber1.Add(TriangleBlueDashDotted);
        shapesListNumber1.Add(RectangleRedDashDotted);

        var allRedShapes = shapesListNumber1
            .Where(x => x.color.colorValue.Equals("red")).ToList();

        Console.WriteLine(String.Join(Environment.NewLine, allRedShapes));

        var allSolidShapes = shapesListNumber1
            .Where(x => x.contour.contourValue.Equals("solid")).ToList();

        Console.WriteLine(String.Join(Environment.NewLine, allSolidShapes));

    }

    //2
    //shapesListNumber1.Sort();
    //shapesListNumber2.Sort();

    //Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber1));
    //Console.WriteLine(String.Join(Environment.NewLine, shapesListNumber2));

    //1
    // Point class exersizes
    //Point point = new Point(0, 6);
    //Point point2 = new Point(1, 1);
    //Point point3 = point.Add(point2);

    //Console.WriteLine($"Point: x={point3.x}, y={point3.y}");

}