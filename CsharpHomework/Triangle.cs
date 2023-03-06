using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Triangle : Shape
    {
        public Triangle(List<Point> points) : base(points)
        {
        }

        public override double CountArea()
        {
            var result = (1 / 2) * (p1.x * (p2.y - p3.y) 
                     + PointsList[1].x * (PointsList[2].y - PointsList[0].y)
                     + PointsList[2].x * (PointsList[0].y - PointsList[1].y));
            return result;
        }
    }
}
