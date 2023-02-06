using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    abstract class Shape
    {
        public List<Point> PointsList { get; }
        public abstract double CountArea();
        public Shape(List<Point> points)
        {
            PointsList = points;
        }

    }
}
