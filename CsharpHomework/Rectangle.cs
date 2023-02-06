using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Rectangle : Shape
    {
        public Rectangle(List<Point> points) : base(points)
        {
        }

        public override double CountArea()
        {
            var result = (PointsList[0].x - PointsList[1].x)*(PointsList[0].y + PointsList[1].y) 
                + (PointsList[1].x - PointsList[2].x)*(PointsList[1].y + PointsList[2].y) 
                + (PointsList[2].x - PointsList[3].x)*(PointsList[2].y + PointsList[3].y) 
                + (PointsList[3].x - PointsList[0].x)*(PointsList[3].y + PointsList[0].y)
                / 2;
            return result;
        }
    }
}
