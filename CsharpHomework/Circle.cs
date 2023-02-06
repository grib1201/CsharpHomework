using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpHomework
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(List<Point> points) : base(points)
        {
        }

        public override double CountArea()
        {
            var result = Radius * Radius * Math.PI;
            return result;
        }
    }
}
